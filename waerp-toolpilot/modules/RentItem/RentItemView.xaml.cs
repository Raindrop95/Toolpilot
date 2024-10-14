using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using waerp_toolpilot.application.rentItem;
using waerp_toolpilot.dbtools;
using waerp_toolpilot.errorHandling;
using waerp_toolpilot.main;
using waerp_toolpilot.modules.RentItem;
using waerp_toolpilot.sql;
using waerp_toolpilot.store;

namespace waerp_toolpilot
{
    static class SearchParams
    {





        public static int counter = 1;
        public static string machine;
        public static string filter_1;
        public static string currentSelectedFilter;
        public static List<string> breadcrumbList = new List<string> { "", "", "", "", "", "" };
        public static string filter_1_id;
        public static string selectedItem;
        public static string[] breadcrumbs = new string[5];
        public static string[] SearchParamArr = new string[5];
        public static DataSet CurrentItemSet = new DataSet();
    }



    /// <summary>
    /// Interaction logic for rentItem.xaml
    /// </summary>
    /// 
    public partial class rentItem : UserControl
    {

        MySqlConnection conn = new MySqlConnection(SqlConn.GetConnectionString());
        public rentItem()
        {


            InitializeComponent();

            SearchParams.counter = 1;
            SearchParams.filter_1 = "";
            SearchParams.currentSelectedFilter = "";
            SearchParams.filter_1_id = "";
            SearchParams.selectedItem = "";
            SearchParams.breadcrumbs = new string[5];
            SearchParams.breadcrumbList = new List<string> { "", "", "", "", "", "" };
            SearchParams.SearchParamArr = new string[5];


            //machineData.DataContext = RentItemQueries.GetAllMachines();
            //machineData.ItemsSource = new DataView(RentItemQueries.GetAllMachines().Tables[0]);



            dataGridFilter.DataContext = RentItemQueries.GetAllFilters_1();
            dataGridFilter.ItemsSource = new DataView(RentItemQueries.GetAllFilters_1().Tables[0]);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM item_objects ORDER BY item_ident ASC", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            SearchParams.CurrentItemSet = ds;
            dataGridItems.DataContext = ds;
            dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
            conn.Close();
        }






        private void filterData_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                CurrentRentModel.ItemIdent = "";
                nextBtn.IsEnabled = true;
                //OpenRentBtn.IsEnabled = false;
                nextBtn.IsEnabled = true;

                SearchParams.currentSelectedFilter = row_selected["filter_id"].ToString();
                SearchParams.SearchParamArr[SearchParams.counter - 1] = row_selected["filter_id"].ToString();
                List<string> itemsReturnList = new List<string>();
                int index = SearchParams.counter - 1;
                SearchParams.breadcrumbs[SearchParams.counter - 1] = row_selected["name"].ToString();
                SearchParams.breadcrumbList[index] = row_selected["name"].ToString();
                breadcrumbBuild(false);


                String stageSearchStr = "";

                for (int i = 1; i <= SearchParams.counter; i++)
                {
                    stageSearchStr += "filter" + i.ToString() + "_id = '" + SearchParams.SearchParamArr[i - 1] + "'";
                    if (i != SearchParams.counter)
                    {
                        stageSearchStr += " AND ";
                    }
                }

                DataSet ds = RentItemQueries.GetItemFilterRelations(stageSearchStr);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ds = RentItemQueries.GetItemDetails(ItemIDBuilder(ds));
                    SearchParams.CurrentItemSet = ds;
                    dataGridItems.DataContext = ds;
                    dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
                    stageSearchStr = "";
                    checkButtons(ds);
                }
                else
                {
                    DataSet empty = new DataSet();
                    empty.Tables.Add("empty");
                    dataGridItems.DataContext = empty;
                    dataGridItems.ItemsSource = new DataView(empty.Tables[0]);

                }

            }
        }
        private string[] FilterIDBuilder(DataSet ds, int id)
        {
            List<string> strDetailIDList = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row[$"filter{id}_id"].ToString() != "")
                {
                    strDetailIDList.Add(row[$"filter{id}_id"].ToString());
                }
            }

            String[] tmpArr = new string[strDetailIDList.Count];
            for (int i = 0; i < strDetailIDList.Count; i++)
            {
                tmpArr[i] = strDetailIDList[i].ToString();
            }
            return tmpArr;

        }
        private string[] ItemIDBuilder(DataSet ds)
        {
            List<string> strDetailIDList = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                strDetailIDList.Add(row["item_id"].ToString());
            }

            String[] tmpArr = new string[strDetailIDList.Count];
            for (int i = 0; i < strDetailIDList.Count; i++)
            {
                tmpArr[i] = strDetailIDList[i].ToString();
            }
            return tmpArr;

        }

        private void machineData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                if (CurrentRentModel.ItemIdent != "")
                {
                    //OpenRentBtn.IsEnabled = true;
                }
                else
                {
                    //OpenRentBtn.IsEnabled = false;
                }
                SearchParams.machine = row_selected["name"].ToString();
                CurrentRentModel.MachineID = row_selected["machine_id"].ToString();
            }
        }

        private void breadcrumbBuild(Boolean itemSelected)
        {
            breadcrumbData.Text = "";
            if (itemSelected == true)
            {
                breadcrumbData.Text = "❯❯ " + SearchParams.breadcrumbList.ElementAt(0);
                if (SearchParams.counter > 1)
                {
                    for (var i = 1; i < SearchParams.counter; i++)
                    {
                        breadcrumbData.Text += " ❯ " + SearchParams.breadcrumbList.ElementAt(i);
                    }
                }
                breadcrumbData.Text = breadcrumbData.Text + " ➔ " + CurrentRentModel.ItemIdentStr;

            }
            else
            {
                if (SearchParams.counter == 1)
                {
                    breadcrumbData.Text = "❯❯ " + SearchParams.breadcrumbList.ElementAt(0);
                }

                else
                {
                    breadcrumbData.Text = "❯❯ " + SearchParams.breadcrumbList.ElementAt(0);
                    for (var i = 1; i < SearchParams.counter; i++)
                    {
                        breadcrumbData.Text += " ❯ " + SearchParams.breadcrumbList.ElementAt(i);
                    }
                }
            }
        }




        private void getNextStage(object sender, RoutedEventArgs e)
        {
            if (SearchParams.counter == 0)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM item_objects ORDER BY item_ident ASC", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);
                dataGridItems.DataContext = ds;
                dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
                conn.Close();
            }
            else
            {
                if (SearchParams.counter < 5)
                {
                    DataSet ds = new DataSet();
                    ds = RentItemQueries.GetItemFilterRelationsSQL(SearchParams.counter, SearchParams.SearchParamArr);
                    String[] Filters = FilterIDBuilder(ds, SearchParams.counter + 1);

                    if (Filters.Length > 0)
                    {
                        ds = RentItemQueries.GetFilterNames(SearchParams.counter + 1, Filters);
                        dataGridFilter.DataContext = ds;
                        dataGridFilter.ItemsSource = new DataView(ds.Tables[0]);
                        SearchParams.counter++;

                    }




                    backBtn.IsEnabled = true;
                    nextBtn.IsEnabled = false;

                }
                else
                {

                }

            }

        }



        private void checkButtons(DataSet ds)
        {
            List<string> strDetailIDList = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                strDetailIDList.Add(row["item_id"].ToString());
            }

            String[] tmpArr = new string[strDetailIDList.Count];
            for (int i = 0; i < strDetailIDList.Count; i++)
            {
                tmpArr[i] = strDetailIDList[i].ToString();
            }
            if (tmpArr.Length == 1)
            {
                nextBtn.IsEnabled = false;
            }
            else
            {
                nextBtn.IsEnabled = true;
            }


        }

        private void getLastStage(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            if (SearchParams.counter == 2)
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM item_objects ORDER BY item_ident ASC", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();

                adp.Fill(ds2);
                SearchParams.CurrentItemSet = ds2;
                dataGridItems.DataContext = ds2;
                dataGridItems.ItemsSource = new DataView(ds2.Tables[0]);
                conn.Close();
                ds = RentItemQueries.GetLastStage(SearchParams.counter - 1, SearchParams.SearchParamArr);
                dataGridFilter.DataContext = ds;
                dataGridFilter.ItemsSource = new DataView(ds.Tables[0]);
                SearchParams.counter--;
                breadcrumbBuild(false);
                backBtn.IsEnabled = false;
                nextBtn.IsEnabled = false;
            }
            else
            {


                if (SearchParams.counter <= 5)
                {

                    SearchParams.SearchParamArr[SearchParams.counter - 2] = "";
                    ds = RentItemQueries.GetItemFilterRelationsSQL(SearchParams.counter - 2, SearchParams.SearchParamArr);
                    ds = RentItemQueries.GetFilterNames(SearchParams.counter - 1, FilterIDBuilder(ds, SearchParams.counter - 1));
                    dataGridFilter.DataContext = ds;
                    SearchParams.CurrentItemSet = ds;
                    dataGridFilter.ItemsSource = new DataView(ds.Tables[0]);
                    SearchParams.counter--;
                    breadcrumbBuild(false);
                    nextBtn.IsEnabled = false;
                }
            }
            if (SearchParams.counter == 1)
            {

                breadcrumbData.Text = "";
            }

        }

        private void resetSearch(object sender, EventArgs e)
        {
            CurrentRentModel.ResetParams();
            SearchParams.counter = 1;
            SearchParams.filter_1 = "";
            SearchParams.currentSelectedFilter = "";
            SearchParams.filter_1_id = "";
            SearchParams.selectedItem = "";
            SearchParams.breadcrumbs = new string[5];
            SearchParams.SearchParamArr = new string[5];
            AddItemButton.IsEnabled = false;
            OpenRentBtn.IsEnabled = false;
            breadcrumbData.Text = "..::";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM item_objects ORDER BY item_ident ASC", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();

            adp.Fill(ds2);
            dataGridItems.DataContext = ds2;
            dataGridItems.ItemsSource = new DataView(ds2.Tables[0]);
            conn.Close();
            dataGridFilter.ItemsSource = null;
            dataGridFilter.DataContext = null;
            //machineData.DataContext = RentItemQueries.GetAllMachines();
            //machineData.ItemsSource = new DataView(RentItemQueries.GetAllMachines().Tables[0]);
            dataGridFilter.DataContext = RentItemQueries.GetAllFilters_1();
            dataGridFilter.ItemsSource = new DataView(RentItemQueries.GetAllFilters_1().Tables[0]);
        }

        private void ItemData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddItemButton.IsEnabled = true;
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                if (int.Parse(row_selected["item_quantity_total"].ToString()) == 0)
                {
                    OpenRentBtn.IsEnabled = false;
                    CurrentRentModel.ItemIdent = row_selected["item_id"].ToString();
                    CurrentRentModel.ItemIdentStr = row_selected["item_ident"].ToString();
                    CurrentRentModel.ItemDescription = row_selected["item_description"].ToString();
                    CurrentRentModel.ItemTotalQuantity = row_selected["item_quantity_total"].ToString();
                    CurrentRentModel.ItemImagePath = row_selected["item_image_path"].ToString();
                    breadcrumbBuild(true);
                }
                else
                {
                    OpenRentBtn.IsEnabled = true;
                    CurrentRentModel.ItemIdent = row_selected["item_id"].ToString();
                    CurrentRentModel.ItemIdentStr = row_selected["item_ident"].ToString();
                    CurrentRentModel.ItemDescription = row_selected["item_description"].ToString();
                    CurrentRentModel.ItemTotalQuantity = row_selected["item_quantity_total"].ToString();
                    CurrentRentModel.ItemImagePath = row_selected["item_image_path"].ToString();
                    breadcrumbBuild(true);
                }

            }
            else
            {
                nextBtn.IsEnabled = false;
            }
        }

        private void openRentWindow(object sender, RoutedEventArgs e)
        {
            DataSet rents = AdministrationQueries.RunSql($"SELECT * FROM item_rents WHERE user_id = {MainWindowViewModel.UserID} AND item_id = {CurrentRentModel.ItemIdent}");
            //  int totalRents = AdministrationQueries.RunSql($"SELECT * FROM item_rents WHERE user_id = {MainWindowViewModel.UserID}").Tables[0].Rows.Count;
            //  int maxRents = int.Parse(AdministrationQueries.RunSql($"SELECT * FROM company_settings WHERE settings_id = 25").Tables[0].Rows[0]["settings_value"].ToString());

            if (rents.Tables[0].Rows.Count > 0)
            {
                ErrorHandlerModel.ErrorText = "Sie haben bereits diesen Artikel ausgeliehen! Bitte denken Sie daran den Artikel wieder zurück zu geben oder ggf. zu verschrotten!";
                ErrorHandlerModel.ErrorType = "WARNING";
                ErrorWindow showError = new ErrorWindow();
                showError.ShowDialog();
            }
            RentSelectedItemView test = new RentSelectedItemView();
            test.ShowDialog();
            String stageSearchStr = "";

            for (int i = 1; i < SearchParams.counter; i++)
            {

                if (SearchParams.SearchParamArr[i - 1] != null)
                {
                    stageSearchStr += "filter" + i.ToString() + "_id = '" + SearchParams.SearchParamArr[i - 1] + "'";
                    if (i != SearchParams.counter - 1)
                    {
                        stageSearchStr += " AND ";
                    }
                }
            }

            if (stageSearchStr != "")
            {
                DataSet ds = RentItemQueries.GetItemFilterRelations(stageSearchStr);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ds = RentItemQueries.GetItemDetails(ItemIDBuilder(ds));
                    SearchParams.CurrentItemSet = ds;
                    dataGridItems.DataContext = ds;
                    dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
                    stageSearchStr = "";
                    checkButtons(ds);
                }
                else
                {


                    DataSet items = AdministrationQueries.RunSql("SELECT * FROM item_objects ORDER BY item_ident ASC");
                    SearchParams.CurrentItemSet = items;
                    dataGridItems.DataContext = items;
                    dataGridItems.ItemsSource = new DataView(items.Tables[0]);



                }
            }
            else
            {


                DataSet items = AdministrationQueries.RunSql("SELECT * FROM item_objects ORDER BY item_ident ASC");
                SearchParams.CurrentItemSet = items;
                dataGridItems.DataContext = items;
                dataGridItems.ItemsSource = new DataView(items.Tables[0]);



            }

            AddItemButton.IsEnabled = false;
            OpenRentBtn.IsEnabled = false;


        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchBox.Text != "")
            {
                DataSet output = SearchParams.CurrentItemSet.Copy();
                output.Tables[0].Rows.Clear();

                foreach (DataRow row in SearchParams.CurrentItemSet.Tables[0].Rows)
                {
                    if (row["item_ident"].ToString().ToLower().Contains(searchBox.Text.ToLower()) | row["item_description"].ToString().ToLower().Contains(searchBox.Text.ToLower()) | row["item_description_2"].ToString().ToLower().Contains(searchBox.Text.ToLower()) | row["item_diameter"].ToString().ToLower().Contains(searchBox.Text.ToLower()))
                    {
                        output.Tables[0].ImportRow(row);
                    }
                }
                dataGridItems.DataContext = output;
                dataGridItems.ItemsSource = new DataView(output.Tables[0]);
            }
            else
            {
                dataGridItems.DataContext = SearchParams.CurrentItemSet;
                dataGridItems.ItemsSource = new DataView(SearchParams.CurrentItemSet.Tables[0]);
            }
        }

        private void resetSearch(object sender, RoutedEventArgs e)
        {
            SearchParams.machine = "";
            SearchParams.counter = 1;
            SearchParams.filter_1 = "";
            SearchParams.currentSelectedFilter = "";
            SearchParams.filter_1_id = "";
            SearchParams.selectedItem = "";
            SearchParams.breadcrumbs = new string[5];
            SearchParams.breadcrumbList = new List<string> { "", "", "", "", "", "" };
            SearchParams.SearchParamArr = new string[5];
            //machineData.DataContext = null;
            //machineData.ItemsSource = null;
            dataGridFilter.DataContext = null;
            dataGridFilter.ItemsSource = null;
            dataGridItems.DataContext = null;
            dataGridItems.ItemsSource = null;
            breadcrumbData.Text = "";
            //machineData.DataContext = RentItemQueries.GetAllMachines();
            //machineData.ItemsSource = new DataView(RentItemQueries.GetAllMachines().Tables[0]);
            dataGridFilter.DataContext = RentItemQueries.GetAllFilters_1();
            dataGridFilter.ItemsSource = new DataView(RentItemQueries.GetAllFilters_1().Tables[0]);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM item_objects ORDER BY item_ident ASC", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            SearchParams.CurrentItemSet = ds;
            dataGridItems.DataContext = ds;
            dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
            AddItemButton.IsEnabled = false;
            OpenRentBtn.IsEnabled = false;

            conn.Close();
        }



        private void CopyItemIdent(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(CurrentRentModel.ItemIdentStr);
        }

        private void CopyDescription(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(CurrentRentModel.ItemDescription);
        }

        private void CopyAll(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(CurrentRentModel.ItemIdentStr + "; " + CurrentRentModel.ItemDescription + "; Bestand:" + CurrentRentModel.ItemTotalQuantity);
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            BookItemNewWindow openBook = new BookItemNewWindow();
            openBook.ShowDialog();
            String stageSearchStr = "";

            for (int i = 1; i < SearchParams.counter; i++)
            {

                if (SearchParams.SearchParamArr[i - 1] != null)
                {
                    stageSearchStr += "filter" + i.ToString() + "_id = '" + SearchParams.SearchParamArr[i - 1] + "'";
                    if (i != SearchParams.counter - 1)
                    {
                        stageSearchStr += " AND ";
                    }
                }
            }

            if (stageSearchStr != "")
            {
                DataSet ds = RentItemQueries.GetItemFilterRelations(stageSearchStr);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ds = RentItemQueries.GetItemDetails(ItemIDBuilder(ds));
                    SearchParams.CurrentItemSet = ds;
                    dataGridItems.DataContext = ds;
                    dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
                    stageSearchStr = "";
                    checkButtons(ds);
                }
                else
                {


                    DataSet items = AdministrationQueries.RunSql("SELECT * FROM item_objects ORDER BY item_ident ASC");
                    SearchParams.CurrentItemSet = items;
                    dataGridItems.DataContext = items;
                    dataGridItems.ItemsSource = new DataView(items.Tables[0]);



                }
            }
            else
            {


                DataSet items = AdministrationQueries.RunSql("SELECT * FROM item_objects ORDER BY item_ident ASC");
                SearchParams.CurrentItemSet = items;
                dataGridItems.DataContext = items;
                dataGridItems.ItemsSource = new DataView(items.Tables[0]);



            }

            AddItemButton.IsEnabled = false;
            OpenRentBtn.IsEnabled = false;

        }

        private void dataGridItems_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dataGridItems.SelectedIndex > -1)
            {


                DataSet rents = AdministrationQueries.RunSql($"SELECT * FROM item_rents WHERE user_id = {MainWindowViewModel.UserID} AND item_id = {CurrentRentModel.ItemIdent}");
                //  int totalRents = AdministrationQueries.RunSql($"SELECT * FROM item_rents WHERE user_id = {MainWindowViewModel.UserID}").Tables[0].Rows.Count;
                //  int maxRents = int.Parse(AdministrationQueries.RunSql($"SELECT * FROM company_settings WHERE settings_id = 25").Tables[0].Rows[0]["settings_value"].ToString());





                if (rents.Tables[0].Rows.Count > 0)
                {
                    ErrorHandlerModel.ErrorText = "Sie haben bereits diesen Artikel ausgeliehen! Bitte denken Sie daran den Artikel wieder zurück zu geben oder ggf. zu verschrotten!";
                    ErrorHandlerModel.ErrorType = "WARNING";
                    ErrorWindow showError = new ErrorWindow();
                    showError.ShowDialog();
                }
                RentSelectedItemView test = new RentSelectedItemView();
                test.ShowDialog();
                String stageSearchStr = "";

                for (int i = 1; i < SearchParams.counter; i++)
                {

                    if (SearchParams.SearchParamArr[i - 1] != null)
                    {
                        stageSearchStr += "filter" + i.ToString() + "_id = '" + SearchParams.SearchParamArr[i - 1] + "'";
                        if (i != SearchParams.counter - 1)
                        {
                            stageSearchStr += " AND ";
                        }
                    }
                }


                if (stageSearchStr != "")
                {
                    DataSet ds = RentItemQueries.GetItemFilterRelations(stageSearchStr);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        ds = RentItemQueries.GetItemDetails(ItemIDBuilder(ds));
                        SearchParams.CurrentItemSet = ds;
                        dataGridItems.DataContext = ds;
                        dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
                        stageSearchStr = "";
                        checkButtons(ds);
                    }
                    else
                    {


                        DataSet items = AdministrationQueries.RunSql("SELECT * FROM item_objects ORDER BY item_ident ASC");
                        SearchParams.CurrentItemSet = items;
                        dataGridItems.DataContext = items;
                        dataGridItems.ItemsSource = new DataView(items.Tables[0]);



                    }
                }
                else
                {


                    DataSet items = AdministrationQueries.RunSql("SELECT * FROM item_objects ORDER BY item_ident ASC");
                    SearchParams.CurrentItemSet = items;
                    dataGridItems.DataContext = items;
                    dataGridItems.ItemsSource = new DataView(items.Tables[0]);



                }



                AddItemButton.IsEnabled = false;
                OpenRentBtn.IsEnabled = false;
            }
        }

        private void dataGridFilter_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dataGridFilter.SelectedIndex > -1)
            {
                if (SearchParams.counter == 0)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM item_objects ORDER BY item_ident ASC", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adp.Fill(ds);
                    dataGridItems.DataContext = ds;
                    dataGridItems.ItemsSource = new DataView(ds.Tables[0]);
                    conn.Close();
                }
                else
                {
                    if (SearchParams.counter < 5)
                    {
                        DataSet ds = new DataSet();
                        ds = RentItemQueries.GetItemFilterRelationsSQL(SearchParams.counter, SearchParams.SearchParamArr);
                        String[] Filters = FilterIDBuilder(ds, SearchParams.counter + 1);

                        if (Filters.Length > 0)
                        {
                            ds = RentItemQueries.GetFilterNames(SearchParams.counter + 1, Filters);
                            dataGridFilter.DataContext = ds;
                            dataGridFilter.ItemsSource = new DataView(ds.Tables[0]);
                            SearchParams.counter++;

                        }




                        backBtn.IsEnabled = true;
                        nextBtn.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Es wurden keine weiteren Filter gefunden!");
                    }

                }
            }
        }


    }


}
