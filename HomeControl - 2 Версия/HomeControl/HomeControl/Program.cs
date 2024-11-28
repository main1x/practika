using System.Data.SQLite;

namespace HomeControl
{
    internal static class Program
    {
        public static string connection = @"Data Source=database.db;";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
        }
    }
}