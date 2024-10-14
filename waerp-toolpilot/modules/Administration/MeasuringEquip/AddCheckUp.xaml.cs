using System;
using System.Data;
using System.IO;
using System.Windows;
using waerp_toolpilot.errorHandling;
using waerp_toolpilot.models;
using waerp_toolpilot.sql;

namespace waerp_toolpilot.modules.Administration.MeasuringEquip
{
    /// <summary>
    /// Interaction logic for AddCheckUp.xaml
    /// </summary>
    public partial class AddCheckUp : Window
    {
        public AddCheckUp()
        {
            InitializeComponent();
            MeasureEquipName.Text = MeasuringEquipModel.MeasuringEquipID;
            MeasureEquipVendor.Text = MeasuringEquipModel.MeasuringEquipName;
            MeasureEquipQuant.Text = MeasuringEquipModel.MeasuringEquipVendor;
        }

        private void CloseDialog_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

        }
        private void CreateCheckUp_Click(object sender, RoutedEventArgs e)
        {
            DataSet SystemConfig = AdministrationQueries.RunSql("SELECT * FROM company_settings");
            DateTime current = DateTime.Now;

            string pathToSaveTo = Path.Combine(SystemConfig.Tables[0].Rows[23][2].ToString(), Path.Combine(SystemConfig.Tables[0].Rows[23][2].ToString(), Path.GetFileName(PDFFilePath.Text) + "_" + current.ToString("yyyy") + "_" + current.ToString("MM") + "_" + current.ToString("dd") + "_" + current.ToString("HH") + "_" + current.ToString("mm") + "_" + current.ToString("ss") + ".pdf"));
            pathToSaveTo = pathToSaveTo.Replace("\\", "\\\\");

            if (selectedDate.Text != null && selectedDate.Text != "")
            {
                if (PDFFilePath.Text != "" && File.Exists(PDFFilePath.Text))
                {
                    DateTime selectedDateStr = DateTime.Parse(selectedDate.Text);
                    string formattedStringDate = selectedDateStr.ToString("yyyy-MM-dd HH:mm:ss");

                    DataSet check1 = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_history WHERE measuring_equip_planned_date = '{formattedStringDate}' AND measuring_equip_id = {MeasuringEquipModel.MeasuringEquipID} AND measuring_equip_history_isChecked = 0");

                    if (check1.Tables[0].Rows.Count > 0)
                    {
                        AdministrationQueries.RunSqlExec($"UPDATE measuring_equip_history SET measuring_equip_history_protocol_path = '{Path.GetFileName(pathToSaveTo)}', measuring_equip_checkedOn = '{formattedStringDate}', measuring_equip_history_isChecked = 1 WHERE measuring_equip_id = {MeasuringEquipModel.MeasuringEquipID} AND measuring_equip_planned_date = '{formattedStringDate}'");
                    }
                    else
                    {
                        AdministrationQueries.RunSqlExec($"INSERT INTO measuring_equip_history (measuring_equip_history_id, measuring_equip_id, measuring_equip_planned_date, measuring_equip_checkedOn, measuring_equip_history_protocol_path, measuring_equip_history_isChecked) VALUES ({AdministrationQueries.GetMaxId(AdministrationQueries.RunSql("SELECT * FROM measuring_equip_history"), "measuring_equip_history_id")}, {MeasuringEquipModel.MeasuringEquipID}, '{formattedStringDate}', '{formattedStringDate}', '{Path.GetFileName(pathToSaveTo)}',1)");
                    }
                    AdministrationQueries.RunSql($"UPDATE measuring_equip_objects SET measuring_equip_lastCheckUp = '{formattedStringDate}' WHERE measuring_equip_id = {MeasuringEquipModel.MeasuringEquipID}");
                    File.Copy(PDFFilePath.Text, pathToSaveTo);
                    ErrorHandlerModel.ErrorType = "SUCCESS";
                    ErrorHandlerModel.ErrorText = (string)FindResource("measureEquipHistory5");
                    ErrorWindow openSuccess = new ErrorWindow();
                    openSuccess.ShowDialog();
                    DialogResult = false;
                }
                else
                {
                    ErrorHandlerModel.ErrorText = (string)FindResource("measureEquipHistory4");
                    ErrorHandlerModel.ErrorType = "NOTALLOWED";
                    ErrorWindow openError = new ErrorWindow();
                    openError.ShowDialog();
                }

            }
            else
            {
                ErrorHandlerModel.ErrorText = (string)FindResource("measureEquipHistory3");
                ErrorHandlerModel.ErrorType = "NOTALLOWED";
                ErrorWindow openError = new ErrorWindow();
                openError.ShowDialog();
            }






        }

        private void selectPdfDocument(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog(); openFileDialog.Filter = "PDF Dokument|*.pdf";
            if (openFileDialog.ShowDialog() == true)
            {
                PDFFilePath.Text = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
