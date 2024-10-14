using System.Data;
using System.Windows;
using waerp_toolpilot.errorHandling;
using waerp_toolpilot.sql;
using waerp_toolpilot.store;

namespace waerp_toolpilot.modules.Administration.MeasureEquipAdministration
{
    /// <summary>
    /// Interaction logic for EditMeasureEquipWindow.xaml
    /// </summary>
    public partial class EditMeasureEquipWindow : Window
    {
        public EditMeasureEquipWindow()
        {
            InitializeComponent();
            MeasureEquipName.Text = TempLocationsModel.MeasureEquipName;
            SerialNumber.Text = TempLocationsModel.SerialNumber;
            GetAuditors();

        }

        private void GetAuditors()
        {
            DataSet ds = AdministrationQueries.RunSql("SELECT * FROM measuring_equip_auditor_objects");
            int selectIndex = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["auditor_id"].ToString() == TempLocationsModel.AuditorID)
                    {
                        selectIndex = i;
                    }
                    AuditorCombobox.Items.Add(ds.Tables[0].Rows[i]["auditor_name"]);
                }
            }
            AuditorCombobox.SelectedIndex = selectIndex;
        }

        private void CloseDialog_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            bool checkName = false;
            bool checkSN = false;

            if (MeasureEquipName.Text == TempLocationsModel.MeasureEquipName)
            {
                checkName = true;
            }
            if (SerialNumber.Text == TempLocationsModel.SerialNumber)
            {
                checkSN = true;
            }

            if (checkName && checkSN)
            {
                AdministrationQueries.RunSqlExec($"UPDATE measuring_equip_objects SET measuring_equip_auditor_id = " +
                    $"{AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_auditor_objects WHERE auditor_name = '{AuditorCombobox.SelectedItem}'").Tables[0].Rows[0]["auditor_id"]} WHERE measuring_equip_id = {TempLocationsModel.MeasureEquipID}");
                ErrorHandlerModel.ErrorText = "Das Messmittel wurde erfolgreich bearbeitet!";
                ErrorHandlerModel.ErrorType = "SUCCESS";
                ErrorWindow showSuccess = new ErrorWindow();
                showSuccess.ShowDialog();
                DialogResult = false;
            }
            else
            {
                DataSet equipName = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_objects WHERE measuring_equip_name = '{MeasureEquipName.Text}'");
                DataSet equipSN = AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_objects WHERE measuring_equip_serialnumber = '{SerialNumber.Text}'");
                if (checkSN && !checkName)
                {
                    if (equipName.Tables[0].Rows.Count > 0)
                    {
                        ErrorHandlerModel.ErrorText = "Es existiert bereits ein Messmittel mit diesem Namen! Bitte wählen Sie einen andern Namen aus.";
                        ErrorHandlerModel.ErrorType = "NOTALLOWED";
                        ErrorWindow showError = new ErrorWindow();
                        showError.ShowDialog();
                    }
                    else
                    {
                        AdministrationQueries.RunSqlExec($"UPDATE measuring_equip_objects SET measuring_equip_name = '{MeasureEquipName.Text}', measuring_equip_auditor_id = {AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_auditor_objects WHERE auditor_name = '{AuditorCombobox.SelectedItem}'").Tables[0].Rows[0]["auditor_id"]} WHERE measuring_equip_id = {TempLocationsModel.MeasureEquipID}");
                        ErrorHandlerModel.ErrorText = "Das Messmittel wurde erfolgreich bearbeitet!";
                        ErrorHandlerModel.ErrorType = "SUCCESS";
                        ErrorWindow showSuccess = new ErrorWindow();
                        showSuccess.ShowDialog();
                        DialogResult = false;
                    }
                }
                else if (!checkSN && checkName)
                {
                    if (equipSN.Tables[0].Rows.Count > 0)
                    {
                        ErrorHandlerModel.ErrorText = "Es existiert bereits ein Messmittel mit dieser Seriennummer! Bitte wählen Sie einen andere Seriennummer aus.";
                        ErrorHandlerModel.ErrorType = "NOTALLOWED";
                        ErrorWindow showError = new ErrorWindow();
                        showError.ShowDialog();
                    }
                    else
                    {
                        AdministrationQueries.RunSqlExec($"UPDATE measuring_equip_objects SET measuring_equip_serialnumber = '{SerialNumber.Text}', measuring_equip_auditor_id = {AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_auditor_objects WHERE auditor_name = '{AuditorCombobox.SelectedItem}'").Tables[0].Rows[0]["auditor_id"]} WHERE measuring_equip_id = {TempLocationsModel.MeasureEquipID}");
                        ErrorHandlerModel.ErrorText = "Das Messmittel wurde erfolgreich bearbeitet!";
                        ErrorHandlerModel.ErrorType = "SUCCESS";
                        ErrorWindow showSuccess = new ErrorWindow();
                        showSuccess.ShowDialog();
                        DialogResult = false;
                    }
                }
                else
                {
                    if (equipName.Tables[0].Rows.Count > 0 && equipSN.Tables[0].Rows.Count > 0)
                    {
                        ErrorHandlerModel.ErrorText = "Es existiert bereits ein Messmittel mit dieser Seriennummer und Namen! Bitte wählen Sie einen andere Seriennummer und Namen aus.";
                        ErrorHandlerModel.ErrorType = "NOTALLOWED";
                        ErrorWindow showError = new ErrorWindow();
                        showError.ShowDialog();
                    }
                    else
                    {
                        AdministrationQueries.RunSqlExec($"UPDATE measuring_equip_objects SET measuring_equip_name = '{MeasureEquipName.Text}', measuring_equip_serialnumber = '{SerialNumber.Text}', measuring_equip_auditor_id = {AdministrationQueries.RunSql($"SELECT * FROM measuring_equip_auditor_objects WHERE auditor_name = '{AuditorCombobox.SelectedItem}'").Tables[0].Rows[0]["auditor_id"]} WHERE measuring_equip_id = {TempLocationsModel.MeasureEquipID}");
                        ErrorHandlerModel.ErrorText = "Das Messmittel wurde erfolgreich bearbeitet!";
                        ErrorHandlerModel.ErrorType = "SUCCESS";
                        ErrorWindow showSuccess = new ErrorWindow();
                        showSuccess.ShowDialog();
                        DialogResult = false;
                    }

                }
            }

        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
