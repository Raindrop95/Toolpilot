using System.Data;
using System.Windows;
using System.Windows.Controls;
using waerp_toolpilot.sql;

namespace waerp_toolpilot.modules.Administration.MeasureEquipAdministration
{
    /// <summary>
    /// Interaction logic for MeasureEquipAuditorOverview.xaml
    /// </summary>
    public partial class MeasureEquipAuditorOverview : UserControl
    {
        public DataSet allItems = new DataSet();
        public MeasureEquipAuditorOverview()
        {
            InitializeComponent();
            allItems = AdministrationQueries.RunSql("SELECT * FROM measuring_equip_auditor_objects");
            if (allItems.Tables.Count > 0)
            {
                dataGridItems.DataContext = allItems;
                dataGridItems.ItemsSource = new DataView(allItems.Tables[0]);
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

        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dataGridItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddAuditor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveAuditor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
