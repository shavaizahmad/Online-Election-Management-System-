using Election_Management_System;

namespace Election_Management_System.DataBase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DBInitialize.CreateUserTable();
            DBInitialize.CreateCandidateTable();
            DBInitialize.CreateVotes();
            Application.Run(new Form1());

        }
    }
}