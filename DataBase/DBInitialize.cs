using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Election_Management_System.DataBase
{

    internal class DBInitialize
    {
        public static void CreateUserTable()
        {
            //DBConnection db = new DBConnection();
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = @" CREATE TABLE IF NOT EXISTS login
               (    id integer primary key autoincrement, 
                    Username TEXT NOT NULL,
                    Cnic TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Age TEXT NOT NULL,
                    Gender TEXT NOT NULL,
                    Contact TEXT ,
                    HasVoted INTEGER DEFAULT 0,
                    Role TEXT NOT NULL
                   
                 );";



                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
            }
        }
        public static void CreateCandidateTable()
        {

            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string vquery = @" CREATE TABLE IF NOT EXISTS candidate
                 (
                   id integer primary key autoincrement,
                    name TEXT NOT NULL,
                    gender TEXT NOT NULL,
                    age TEXT NOT NULL,
                    seat TEXT NOT NULL,
                    symbol TEXT NOT NULL,
                    party TEXT NOT NULL 
                 );";

                SQLiteCommand cmd = new SQLiteCommand(vquery, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
            }
        }
            //}
            //public static void CreateVoterTable()
            //{
            //    DBConnection db = new DBConnection();
            //    using (SQLiteConnection conn = DBConnection.GetConnection())
            //    {
            //        conn.Open();
            //        string query = @" CREATE TABLE IF NOT EXISTS VOTER
            //         (
            //            ID integer primary key autoincrement,
            //            Name TEXT NOT NULL,
            //            Password TEXT NOT NULL,
            //            contact TEXT ,
            //            Age TEXT NOT NULL,
            //            Gender TEXT NOT NULL,
            //            Cnic TEXT NOT NULL
            //         );";

            //        SQLiteCommand cmd = new SQLiteCommand(query, conn);
            //        cmd.ExecuteNonQuery();
            //        //conn.Close();
            //    }
            //}
            public static void CreateVotes()
        {

            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string CreateVotes = @" CREATE TABLE IF NOT EXISTS Votes
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CandidateId INTEGER,
                    CNIC TEXT
                );";

                SQLiteCommand cmd = new SQLiteCommand(CreateVotes, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
            }
        }
    }
}