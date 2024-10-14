using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using waerp_toolpilot.models;
using waerp_toolpilot.sql;

namespace waerp_toolpilot.modules.Administration.MeasuringEquip
{
    /// <summary>
    /// Interaction logic for MeasuringEquipHistoryWindow.xaml
    /// </summary>
    public partial class MeasuringEquipHistoryWindow : Window
    {
        DataRow currentSelectedItem = null;
        DataSet companySettings = new DataSet();
        public MeasuringEquipHistoryWindow()
        {
            InitializeComponent();

            DataSet historyDatesData = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_history WHERE measuring_equip_id = {MeasuringEquipModel.MeasuringEquipID}");
            historyDatesData.Tables[0].Columns.Add("plannedDate");
            historyDatesData.Tables[0].Columns.Add("checkedDate");

            companySettings = AdministrationQueries.RunSql("SELECT * FROM company_settings");

            if (historyDatesData.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < historyDatesData.Tables[0].Rows.Count; i++)
                {

                    if (DateTime.TryParse(historyDatesData.Tables[0].Rows[i]["measuring_equip_planned_date"].ToString(), out DateTime parsedDateTime))
                    {
                        DateTime tmp1 = DateTime.Parse(historyDatesData.Tables[0].Rows[i]["measuring_equip_planned_date"].ToString());
                        historyDatesData.Tables[0].Rows[i]["plannedDate"] = tmp1.ToString("d");
                        if (DateTime.TryParse(historyDatesData.Tables[0].Rows[i]["measuring_equip_checkedOn"].ToString(), out DateTime parsedDateTime2))
                        {
                            tmp1 = DateTime.Parse(historyDatesData.Tables[0].Rows[i]["measuring_equip_checkedOn"].ToString());
                            historyDatesData.Tables[0].Rows[i]["checkedDate"] = tmp1.ToString("d");
                        }
                    }
                }

                historyDates.DataContext = historyDatesData;
                historyDates.ItemsSource = new DataView(historyDatesData.Tables[0]);
            }


        }

        private void historyDates_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                if (row_selected.Row[3].ToString() != null && row_selected.Row[3].ToString() != "")
                {
                    EditHistoryEntry.IsEnabled = true;

                    currentSelectedItem = row_selected.Row;
                }
                else
                {
                    EditHistoryEntry.IsEnabled = false;
                }


            }
        }

        private void CloseDialog_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void CreateCheckUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenProtocolBtn_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(companySettings.Tables[0].Rows[23][2].ToString() + "\\" + currentSelectedItem[4].ToString()))
            {
                try
                {
                    Process.Start(companySettings.Tables[0].Rows[23][2].ToString() + "\\" + currentSelectedItem[4].ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening PDF file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("PDF file does not exist.");
            }
        }

        private void EditHistoryEntry_Click(object sender, RoutedEventArgs e)
        {
            MeasuringEquipModel.CurrentSelectedHistory_CheckDate = DateTime.Parse(currentSelectedItem[3].ToString());
            MeasuringEquipModel.CurrentSelectedHistory_DocPath = currentSelectedItem[4].ToString();

            EditCheckUp openEdit = new EditCheckUp();
            openEdit.ShowDialog();

        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
