using System.Windows;
using waerp_toolpilot.errorHandling;
using waerp_toolpilot.sql;
using waerp_toolpilot.store;

namespace waerp_toolpilot.modules.Administration.MeasureEquipAdministration
{
    /// <summary>
    /// Interaction logic for DeleteMeasureEquipWindow.xaml
    /// </summary>
    public partial class DeleteMeasureEquipWindow : Window
    {
        public DeleteMeasureEquipWindow()
        {
            InitializeComponent();
        }

        private void CancleBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            AdministrationQueries.RunSqlExec($"DELETE FROM measuring_equip_objects WHERE measuring_equip_id = {TempLocationsModel.MeasureEquipID}");
            AdministrationQueries.RunSqlExec($"DELETE FROM measuring_equip_location_relations WHERE measuring_equip_id = {TempLocationsModel.MeasureEquipID}");
            ErrorHandlerModel.ErrorText = "Das Messmittel wurde erfolgreich gelöscht!";
            ErrorHandlerModel.ErrorType = "SUCCESS";
            ErrorWindow showSuccess = new ErrorWindow();
            showSuccess.ShowDialog();
            DialogResult = false;
        }
    }
}
