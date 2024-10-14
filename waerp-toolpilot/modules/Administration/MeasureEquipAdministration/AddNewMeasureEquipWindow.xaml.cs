using System.Data;
using System.Windows;
using waerp_toolpilot.errorHandling;
using waerp_toolpilot.sql;

namespace waerp_toolpilot.modules.Administration.MeasureEquipAdministration
{
    /// <summary>
    /// Interaction logic for AddNewMeasureEquipWindow.xaml
    /// </summary>
    public partial class AddNewMeasureEquipWindow : Window
    {
        public AddNewMeasureEquipWindow()
        {
            InitializeComponent();
            GetAuditors();
        }

        private void GetAuditors()
        {
            DataSet ds = AdministrationQueries.RunSql("SELECT * FROM measuring_equip_auditor_objects");
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    AuditorCombobox.Items.Add(ds.Tables[0].Rows[i]["auditor_name"]);
                }
            }
        }

        private void CloseDialog_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void CreateItem_Click(object sender, RoutedEventArgs e)
        {
            if (MeasureEquipName.Text.Length <= 0)
            {
                ErrorHandlerModel.ErrorText = "Bitte gebe einen Messmittelnamen an!";
                ErrorHandlerModel.ErrorType = "NOTALLOWED";
                ErrorWindow showError = new ErrorWindow();
                showError.ShowDialog();
            }
            else if (SerialNumber.Text.Length <= 0)
            {
                ErrorHandlerModel.ErrorText = "Bitte gebe die Seriennummer zum Messmittel an!";
                ErrorHandlerModel.ErrorType = "NOTALLOWED";
                ErrorWindow showError = new ErrorWindow();
                showError.ShowDialog();
            }
            else
            {
                DataSet ds_name = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_objects WHERE measuring_equip_name = '{MeasureEquipName.Text}'");

                DataSet ds_serialnumber = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_objects WHERE measuring_equip_serialnumber = '{SerialNumber.Text}'");

                if (ds_name.Tables[0].Rows.Count == 0 && ds_serialnumber.Tables[0].Rows.Count == 0)
                {
                    AdministrationQueries.RunSqlExec($"INSERT INTO measuring_equip_objects (measuring_equip_serialnumber, measuring_equip_name, measuring_equip_vendor,measuring_equip_auditor_id, measuring_equip_lastCheckUp) VALUES (" +
                        $"'{SerialNumber.Text}'," +
                        $"'{MeasureEquipName.Text}'," +
                        $"''," +
                        $"{AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_auditor_objects WHERE auditor_name = '{AuditorCombobox.SelectedItem}'").Tables[0].Rows[0]["auditor_id"]}," +
                        $"'0000-00-00 00:00:00')");
                    ErrorHandlerModel.ErrorText = "Das Messmittel wurde erfolgreich angelegt!";
                    ErrorHandlerModel.ErrorType = "SUCCESS";
                    ErrorWindow showSuccess = new ErrorWindow();
                    showSuccess.ShowDialog();
                    DialogResult = false;
                }
                else
                {
                    ErrorHandlerModel.ErrorText = "Dieses Messmittel existiert bereits in der Datenbank!";
                    ErrorHandlerModel.ErrorType = "NOTALLOWED";
                    ErrorWindow showError = new ErrorWindow();
                    showError.ShowDialog();
                }
            }
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
