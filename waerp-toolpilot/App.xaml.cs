using Microsoft.Win32;
using MySqlConnector;
using System;
using System.Threading;
using System.Windows;
using waerp_toolpilot.dbtools;
using waerp_toolpilot.errorHandling;
using waerp_toolpilot.FirstTimeStartup;
using waerp_toolpilot.loginHandling;
using waerp_toolpilot.sql;
using waerp_toolpilot.ViewModels;

namespace waerp_toolpilot
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);




            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\toolpilot", true);
            if (key != null)
            {
                Thread databaseThread = new Thread(CheckDatabaseReachability);
                ResourceDictionary languageDictionary;
                if (checkDBConnect())
                {
                    //int globalLanguageID = int.Parse(AdministrationQueries.RunSql("SELECT * FROM company_settings WHERE settings_name = 'global_culture_id'").Tables[0].Rows[0][2].ToString());
                    int globalLanguageID = 4;
                    string selectedLanguage = AdministrationQueries.RunSql($"SELECT * FROM culture_objects WHERE culture_id = {globalLanguageID}").Tables[0].Rows[0]["culture_code"].ToString();
                    languageDictionary = new ResourceDictionary
                    {
                        Source = new Uri($"/Language/{selectedLanguage}.xaml", UriKind.Relative)
                    };


                    Resources.MergedDictionaries.Add(languageDictionary);
                }

                // Set the thread as a background thread
                databaseThread.IsBackground = true;

                // Start the thread
                databaseThread.Start();
                loginView mainWindow = new loginView
                {
                    DataContext = new MainViewModel()
                };
            }
            else
            {
                FirstTimeStartUpWindow openInstallation = new FirstTimeStartUpWindow();
                openInstallation.Show();
            }












            // Create an instance of the StartupWindow and show it
            // The MainWindow will be automatically created and displayed



        }
        private void CheckDatabaseReachability()
        {
            while (true)
            {
                // Perform the database reachability check here
                // You can use a try-catch block to catch any exceptions

                try
                {
                    // Attempt to connect to the MySQL database
                    using (var connection = new MySqlConnection(SqlConn.GetConnectionString()))
                    {
                        connection.Open();
                    }

                }
                catch (Exception ex)
                {

                    ErrorHandlerModel.ErrorText = "Die Datenbank ist nicht erreichbar. Bitte prüfen Sie Ihre Netzwerkverbindung oder wenden Sie sich an den Systemadministrator!";
                    ErrorHandlerModel.ErrorType = "NOTALLOWED";
                    ErrorWindow openError = new ErrorWindow();
                    openError.ShowDialog();
                    ErrorLogger.LogSqlError(ex);
                }

                // Wait for 10 seconds before performing the next reachability check
                Thread.Sleep(10000);
            }
        }
        private bool checkDBConnect()
        {
            try
            {
                // Attempt to connect to the MySQL database
                using (var connection = new MySqlConnection(SqlConn.GetConnectionString()))
                {
                    connection.Open();
                }
                return true;

            }
            catch (Exception ex)
            {

                ErrorHandlerModel.ErrorText = "Die Datenbank ist nicht erreichbar. Bitte prüfen Sie Ihre Netzwerkverbindung oder wenden Sie sich an den Systemadministrator!";
                ErrorHandlerModel.ErrorType = "NOTALLOWED";
                ErrorWindow openError = new ErrorWindow();
                openError.ShowDialog();
                ErrorLogger.LogSqlError(ex);
                return false;
            }
        }
    }
}
