using MySqlConnector;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using waerp_toolpilot.application.RentItem;
using waerp_toolpilot.application.returnItem;
using waerp_toolpilot.dbtools;
using waerp_toolpilot.errorHandling;
using waerp_toolpilot.models;
using waerp_toolpilot.sql;
using waerp_toolpilot.store;

namespace waerp_toolpilot.modules.RentItem
{
    /// <summary>
    /// Interaction logic for BookItemNewWindow.xaml
    /// </summary>
    public partial class BookItemNewWindow : Window
    {
        MySqlConnection conn = new MySqlConnection(SqlConn.GetConnectionString());

        public string locationID;
        public string locationName;
        public bool isNewLocation = false;
        public string locationQuantity;
        public bool isUsedRent = false;
        public DataSet AllLocation = new DataSet();
        public DataRowView CurrentLocationRow;
        public DataSet AllLocations = new DataSet();

        public BookItemNewWindow()
        {
            InitializeComponent();
            GetItemContent();
            GetLocations();

            ReportWrongLocationModel.ItemIdent = CurrentReturnModel.ItemIdentStr;
            ReturnBtn.IsEnabled = false;

            isUsedRent = CurrentReturnModel.ReturnIsUsed;
            CurrentReturnModel.ReturnIsUsed = false;
            Boolean check = false;
            for (int i = 0; i < CurrentReturnModel.ItemIdentStr.Length; i++)
            {
                if (CurrentReturnModel.ItemIdentStr[i].ToString() == "ä" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "ü" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "ö" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "Ä" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "Ü" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "Ö" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "ß" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "%" ||
                    CurrentReturnModel.ItemIdentStr[i].ToString() == "&")
                {
                    check = true;
                }
            }
            if (check == false)
            {

                Barcode.Text = "*" + CurrentReturnModel.ItemIdentStr + "*";
            }
            else
            {
                Barcode.Text = "";
            }
        }

        private void GetItemContent()
        {
            conn.Open();
            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand("Select * from item_objects WHERE item_id = '" + CurrentRentModel.ItemIdent + "'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CurrentReturnModel.ItemIdentStr = reader.GetString("item_ident");
                CurrentReturnModel.ItemDescription = reader.GetString("item_description");
                CurrentReturnModel.ItemDescription2 = reader.GetString("item_description_2");
                ItemDiameter.Text = reader.GetString("item_diameter");

            }

            CurrentReturnModel.ItemIdent = CurrentRentModel.ItemIdent;
            ItemIdent.Text = CurrentReturnModel.ItemIdentStr;
            ItemDescription.Text = CurrentReturnModel.ItemDescription;
            ItemDescription2.Text = CurrentReturnModel.ItemDescription2;

            ItemTotalQuantity.Text = CurrentRentModel.ItemTotalQuantity;

            if (CurrentRentModel.ItemImagePath != "")
            {
                try
                {
                    Uri imageUri = new Uri(CurrentRentModel.ItemImagePath, UriKind.RelativeOrAbsolute);

                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = imageUri;
                    bitmapImage.EndInit();

                    ItemImage.Source = bitmapImage;
                }
                catch (Exception exp)
                {
                    ErrorLogger.LogSysError(exp);
                    Uri imageUri = new Uri("pack://application:,,,/assets/images/default/default.jpg", UriKind.RelativeOrAbsolute);

                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = imageUri;
                    bitmapImage.EndInit();

                    ItemImage.Source = bitmapImage;
                }
            }
            else
            {
                Uri imageUri = new Uri("pack://application:,,,/assets/images/default/default.jpg", UriKind.RelativeOrAbsolute);

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = imageUri;
                bitmapImage.EndInit();

                ItemImage.Source = bitmapImage;

            }


            conn.Close();
        }
        private void GetLocations()
        {


            DataSet ds = TempLocationsQueries.GetItemLocations(CurrentReturnModel.ItemIdent);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    AllLocations = ds;
                    locationData.DataContext = ds;
                    locationData.ItemsSource = new DataView(ds.Tables[0]);
                }
            }
            DataSet ds2 = TempLocationsQueries.GetEmptyLocation(CurrentReturnModel.ItemIdent);
            if (ds2.Tables.Count > 0)
            {
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    locationEmptyData.DataContext = ds2;
                    locationEmptyData.ItemsSource = new DataView(ds2.Tables[0]);
                    AllLocation = TempLocationsQueries.GetEmptyLocation(CurrentReturnModel.ItemIdent);
                }
            }



        }

        private void locationData_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                isNewLocation = false;

                string used = "0";
                if (UsedItems.IsChecked == true)
                {
                    used = "1";
                }
                if (row_selected["item_used"].ToString() != used)
                {
                    ReturnBtn.IsEnabled = false;
                }
                else
                {
                    ReturnBtn.IsEnabled = true;
                }

                locationEmptyData.SelectedIndex = -1;
                locationID = row_selected["location_id"].ToString();
                CurrentReturnModel.ReturnLocationID = locationID;
                CurrentLocationRow = row_selected;
                locationName = row_selected["location_name"].ToString();
                ReportWrongLocationModel.LocationIdent = row_selected["location_name"].ToString();
                locationQuantity = row_selected["item_quantity"].ToString();
            }

        }

        private void locationEmptyData_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                isNewLocation = true;
                locationData.SelectedIndex = -1;
                ReportWrongLocationModel.LocationIdent = row_selected["location_name"].ToString();
                CurrentLocationRow = row_selected;
                locationID = row_selected["compartment_id"].ToString();
                CurrentReturnModel.ReturnLocationID = locationID;
                locationName = row_selected["location_name"].ToString();
                // locationQuantity = row_selected["location_quantity"].ToString();
            }
            ReturnBtn.IsEnabled = true;
        }

        private void searchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (searchBox.Text != "")
            {
                DataSet output = AllLocation.Copy();
                output.Tables[0].Rows.Clear();

                foreach (DataRow row in AllLocation.Tables[0].Rows)
                {
                    if (row["location_name"].ToString().Contains(searchBox.Text))
                    {
                        output.Tables[0].ImportRow(row);
                    }
                }
                locationEmptyData.DataContext = output;
                locationEmptyData.ItemsSource = new DataView(output.Tables[0]);
            }
            else
            {
                locationEmptyData.DataContext = AllLocation;
                locationEmptyData.ItemsSource = new DataView(AllLocation.Tables[0]);

            }
        }

        private void MinusQuantity_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(QuantityInput.Text) > 0)
            {
                int quant = int.Parse(QuantityInput.Text);
                quant--;
                QuantityInput.Text = quant.ToString();

            }
        }

        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PlusQuantity_Click(object sender, RoutedEventArgs e)
        {
            int quant = int.Parse(QuantityInput.Text);
            quant++;
            QuantityInput.Text = quant.ToString();
        }

        private void QuantityNumInput_Click(object sender, RoutedEventArgs e)
        {
            CurrentRentModel.RentQuantity = QuantityInput.Text.ToString();
            RentNumberInputView numberInput = new RentNumberInputView();
            Nullable<bool> dialogResult = numberInput.ShowDialog();
            QuantityInput.Text = CurrentRentModel.RentQuantity.ToString();
        }

        private void ReturnItem(object sender, RoutedEventArgs e)
        {

            string used = "0";
            if (UsedItems.IsChecked == true)
            {
                used = "1";
            }

            if (QuantityInput.Text == "")
            {
                ErrorHandlerModel.ErrorText = (string)FindResource("errorText36");
                ErrorHandlerModel.ErrorType = "NOTALLOWED";
                ErrorWindow showError = new ErrorWindow();
                showError.ShowDialog();
            }

            else
            {
                if (int.Parse(QuantityInput.Text) > 0)
                {

                    if (isNewLocation)
                    {
                        CurrentReturnModel.ReturnQuantity = QuantityInput.Text;
                        ReturnItemQueries.ReturnItemNewLocation("1");
                        CurrentReturnModel.ReturnLocation = locationName;
                        CurrentReturnModel.ReturnQuantity = QuantityInput.Text.ToString();


                        SuccessReturnView successDialog = new SuccessReturnView();
                        Nullable<bool> dialogResult = successDialog.ShowDialog();
                        DialogResult = false;
                    }
                    else
                    {
                        if (CurrentLocationRow["onlyUsed"].ToString() != used || CurrentLocationRow["item_used"].ToString() != used)
                        {
                            ErrorHandlerModel.ErrorText = (string)FindResource("errorText67");
                            ErrorHandlerModel.ErrorType = "NOTALLOWED";
                            ErrorWindow showError = new ErrorWindow();
                            showError.ShowDialog();
                        }
                        else
                        {
                            //if (Convert.ToBoolean(CurrentLocationRow["item_constructed"].ToString()) != CurrentReturnModel.ItemIsConstructed)
                            //{
                            //    ErrorHandlerModel.ErrorText = "Zusammengebautes Werkzeug kann nur mit zusammengebauten zusammen gelagert werden!";
                            //    ErrorHandlerModel.ErrorType = "NOTALLOWED";
                            //    ErrorWindow showError = new ErrorWindow();
                            //    showError.ShowDialog();
                            //    check = false;
                            //}
                            //else
                            //{
                            CurrentReturnModel.ReturnQuantity = QuantityInput.Text;
                            ReturnItemQueries.ReturnItemLocation("1");
                            CurrentReturnModel.ReturnLocation = locationName;
                            CurrentReturnModel.ReturnQuantity = QuantityInput.Text.ToString();


                            SuccessReturnView successDialog = new SuccessReturnView();
                            Nullable<bool> dialogResult = successDialog.ShowDialog();
                            DialogResult = false;
                            //}
                        }

                    }






                    //else
                    //{
                    //    ErrorHandlerModel.ErrorText = (string)FindResource("errorText53");
                    //    ErrorHandlerModel.ErrorType = "NOTALLOWED";
                    //    ErrorWindow showError = new ErrorWindow();
                    //    showError.ShowDialog();
                    //}
                }
                else if (int.Parse(QuantityInput.Text) == 0)
                {
                    ErrorHandlerModel.ErrorText = (string)FindResource("errorText61");
                    ErrorHandlerModel.ErrorType = "NOTALLOWED";
                    ErrorWindow showError = new ErrorWindow();
                    showError.ShowDialog();
                }
                else
                {
                    ErrorHandlerModel.ErrorText = (string)FindResource("errorText36");
                    ErrorHandlerModel.ErrorType = "NOTALLOWED";
                    ErrorWindow showError = new ErrorWindow();
                    showError.ShowDialog();
                }

            }
        }

        private void CloseCurrentDialog(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ReportErrorLocationBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UsedItems_Click(object sender, RoutedEventArgs e)
        {
            string used = "0";
            if (UsedItems.IsChecked == true)
            {
                used = "1";
                CurrentReturnModel.ReturnIsUsed = true;
            }
            else
            {
                if (isUsedRent)
                {
                    ErrorHandlerModel.ErrorText = (string)FindResource("errorText68");
                    ErrorHandlerModel.ErrorType = "INFO";
                    ErrorWindow showInfo = new ErrorWindow();
                    showInfo.ShowDialog();
                }
                CurrentReturnModel.ReturnIsUsed = false;
            }

            if (CurrentLocationRow != null)
            {
                if (CurrentLocationRow["item_used"].ToString() != used)
                {
                    ReturnBtn.IsEnabled = false;
                }
                else
                {
                    ReturnBtn.IsEnabled = true;

                }
            }
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ResizeWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
