using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

//.NET Connector Library
using MySql.Data.MySqlClient;
using MySql.Data.Types;

//Library to enable putting 
//the configuration settings
using System.Configuration;


namespace SMSCollegeResultsSystem._Class
{
    class clsResult
    {
        //Read connection string from application settings file
        //Configuration settings
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader updateDataReader;

        private String mod_Code { get; set; }
        private String stud_ID { get; set; }
        private String marks { get; set; }
        private String grade { get; set; }

        public clsResult(String mod_Code, String stud_ID, 
            String marks, String grade)
        {
            this.mod_Code = mod_Code;
            this.stud_ID = stud_ID;
            this.marks = marks;
            this.grade = grade;

        }

        public clsResult()
        { }

        public void AddResults(String mod_Code, String stud_ID,
            String marks, String grade)
        {
            string insertSQL =
                   "INSERT INTO Result (modCode, studID, marks, grade) VALUES ('"
                   + mod_Code + "', '" + stud_ID + "', '" + marks + "', '" + grade + "')";

            con = new MySqlConnection(conString);

            MySqlCommand cmd = new MySqlCommand(insertSQL, con);
            con.Open();


            cmd.ExecuteNonQuery();

            con.Close();



            string insertCompletedSubjSQL =
                   "INSERT INTO CompletedModulesResults (modCode, studID, marks, grade) VALUES ('"
                   + mod_Code + "', '" + stud_ID + "', '" + marks + "', '" + grade + "')";

            con = new MySqlConnection(conString);

            MySqlCommand command = new MySqlCommand(insertCompletedSubjSQL, con);
            con.Open();


            command.ExecuteNonQuery();

            con.Close();
        }

        public void View_EditResults(String mod_Code, String stud_ID,
            String marks, String grade)
        {
            
            string updateSQL =
               "UPDATE Result SET marks ='" + marks + "', grade='" 
               + grade + "' WHERE modCode='" + mod_Code + "' AND studID='" + stud_ID + "'";

            con = new MySqlConnection(conString);
            MySqlCommand com = new MySqlCommand(updateSQL, con);

            con.Open();
            updateDataReader = com.ExecuteReader();

            con.Close();




            string updateCompletedSubjSQL =
               "UPDATE CompletedModulesResults SET marks ='" + marks + "', grade='"
               + grade + "' WHERE modCode='" + mod_Code + "' AND studID='" + stud_ID + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(updateCompletedSubjSQL, con);

            con.Open();
            updateDataReader = cmd.ExecuteReader();

            con.Close();
        }

        public void DeleteResults(String mod_Code, String stud_ID,
            String marks, String grade)
        {
            string deleteSQL =
                "DELETE FROM Result WHERE modCode='" + mod_Code + "' AND studID='" + stud_ID + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            string deleteStudModSQL =
                "DELETE FROM StudMod WHERE modCode='" + mod_Code + "' AND studID='" + stud_ID + "'";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(deleteStudModSQL, con);
            con.Open();

            command.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetResultsTable()
        {
            string selectSQL =
                "SELECT * FROM Result";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            con.Open();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            
            con.Close();
            
            return dataTable;

        }

        public void DeleteAllResults()
        {
            string deleteSQL =
                    "DELETE FROM Result";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


            string deleteStudModSQL =
                    "DELETE FROM StudMod";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(deleteStudModSQL, con);
            con.Open();

            command.ExecuteNonQuery();

            con.Close();
        }
    }
}
