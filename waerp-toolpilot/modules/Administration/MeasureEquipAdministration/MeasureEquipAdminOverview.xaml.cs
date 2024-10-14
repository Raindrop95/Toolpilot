using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using waerp_toolpilot.sql;
using waerp_toolpilot.store;

namespace waerp_toolpilot.modules.Administration.MeasureEquipAdministration
{
    /// <summary>
    /// Interaction logic for MeasureEquipAdminOverview.xaml
    /// </summary>
    public partial class MeasureEquipAdminOverview : UserControl
    {
        public DataSet allItems = new DataSet();
        public MeasureEquipAdminOverview()
        {
            InitializeComponent();
            initPage();
        }

        private void initPage()
        {
            DataSet Locations = AdministrationQueries.RunSql("SELECT * FROM measuring_equip_locations");

            if (Locations.Tables[0].Rows.Count > 0)
            {
                measureEquipLocations.DataContext = Locations;
                measureEquipLocations.ItemsSource = new DataView(Locations.Tables[0]);

                measureEquipLocations.SelectedIndex = 0;
                EditMeasureLocation.IsEnabled = true;
                DeleteMeasureLocation.IsEnabled = true;
            }
            else
            {
                EditMeasureLocation.IsEnabled = false;
                DeleteMeasureLocation.IsEnabled = false;
            }



            allItems = AdministrationQueries.RunSql("SELECT * FROM measuring_equip_objects");
            if (allItems.Tables[0].Rows.Count > 0)
            {

                allItems.Tables[0].Columns.Add("measuring_equip_auditor_name");
                for (int i = 0; i < allItems.Tables[0].Rows.Count; i++)
                {
                    DataSet auditor = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_auditor_objects WHERE auditor_id = {allItems.Tables[0].Rows[i]["measuring_equip_auditor_id"]}");
                    allItems.Tables[0].Rows[i]["measuring_equip_auditor_name"] = auditor.Tables[0].Rows[0]["auditor_name"];
                }

                allItems.Tables[0].Columns.Add("nextCheckUp");
                allItems.Tables[0].Columns.Add("lastCheckUp");

                if (allItems.Tables[0].Rows.Count > 0)
                {
                    for (var i = 0; i < allItems.Tables[0].Rows.Count; i++)
                    {
                        if (DateTime.TryParse(allItems.Tables[0].Rows[i]["measuring_equip_lastCheckUp"].ToString(), out DateTime parsedDateTime))
                        {
                            string toInsert = DateTime.Parse(allItems.Tables[0].Rows[i]["measuring_equip_lastCheckUp"].ToString()).ToString("d");
                            allItems.Tables[0].Rows[i]["lastCheckUp"] = toInsert;
                        }




                        DataSet currentHistoryLogs = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_history WHERE measuring_equip_id = {allItems.Tables[0].Rows[i]["measuring_equip_id"]} AND measuring_equip_history_isChecked = 0");
                        if (currentHistoryLogs.Tables[0].Rows.Count > 0)
                        {
                            for (int j = 0; j < currentHistoryLogs.Tables[0].Rows.Count; j++)
                            {
                                allItems.Tables[0].Rows[i]["nextCheckUp"] = DateTime.Parse(currentHistoryLogs.Tables[0].Rows[j]["measuring_equip_planned_date"].ToString()).ToString("d");
                            }

                        }

                    }


                    dataGridItems.DataContext = allItems;
                    dataGridItems.ItemsSource = new DataView(allItems.Tables[0]);

                    dataGridItems.SelectedIndex = 0;

                    EditMeasureItem.IsEnabled = true;
                    DeleteMeasureItem.IsEnabled = true;
                }
                else
                {
                    EditMeasureItem.IsEnabled = false;
                    DeleteMeasureItem.IsEnabled = false;
                }
            }
        }
        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddMeasureItem_Click(object sender, RoutedEventArgs e)
        {
            AddNewMeasureEquipWindow openAdd = new AddNewMeasureEquipWindow();
            openAdd.ShowDialog();
            initPage();
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchBox.Text != "")
            {
                DataSet output = allItems.Copy();
                output.Tables[0].Rows.Clear();

                foreach (DataRow row in allItems.Tables[0].Rows)
                {
                    if (row["measuring_equip_name"].ToString().Contains(searchBox.Text) | row["measuring_equip_serialnumber"].ToString().Contains(searchBox.Text))
                    {
                        output.Tables[0].ImportRow(row);
                    }
                }
                dataGridItems.DataContext = output;
                dataGridItems.ItemsSource = new DataView(output.Tables[0]);
            }
            else
            {
                dataGridItems.DataContext = allItems;
                dataGridItems.ItemsSource = new DataView(allItems.Tables[0]);

                dataGridItems.SelectedIndex = 0;
            }

        }

        private void dataGridItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                TempLocationsModel.MeasureEquipID = row_selected["measuring_equip_id"].ToString();
                TempLocationsModel.MeasureEquipName = row_selected["measuring_equip_name"].ToString();
                TempLocationsModel.SerialNumber = row_selected["measuring_equip_serialnumber"].ToString();
                TempLocationsModel.AuditorID = row_selected["measuring_equip_auditor_id"].ToString();
            }
        }

        private void DeleteMeasureItem_Click(object sender, RoutedEventArgs e)
        {
            DeleteMeasureEquipWindow openDelete = new DeleteMeasureEquipWindow();
            openDelete.ShowDialog();
            initPage();
        }

        private void measureEquipLocations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                TempLocationsModel.ContainerName = row_selected["mlocation_name"].ToString();
                TempLocationsModel.ContainerID = row_selected["mlocation_id"].ToString();
            }

        }

        private void DeleteMeasureLocation_Click(object sender, RoutedEventArgs e)
        {
            DeleteMeasureEquipLocationWindow openDelete = new DeleteMeasureEquipLocationWindow();
            openDelete.ShowDialog();
            initPage();
        }

        private void EditMeasureLocation_Click(object sender, RoutedEventArgs e)
        {
            EditMeasureEquipLocationWindow openEdit = new EditMeasureEquipLocationWindow();
            openEdit.ShowDialog();
            initPage();
        }

        private void AddMeasureLocation_Click(object sender, RoutedEventArgs e)
        {
            AddMeasureEquipLocationWindow openAdd = new AddMeasureEquipLocationWindow();
            openAdd.ShowDialog();
            initPage();
        }

        private void EditMeasureItem_Click(object sender, RoutedEventArgs e)
        {
            EditMeasureEquipWindow openEdit = new EditMeasureEquipWindow();
            openEdit.ShowDialog();
            initPage();
        }
    }
}
