using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;

namespace SMSCollegeResultsSystem._Class
{
    class clsStudent : IPerson
    {

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;

        MySqlDataReader updateDataReader;

        private String icPsp { get; set; }
        private String fName { get; set; }
        private String lName { get; set; }
        private String phone { get; set; }
        private String email { get; set; }
        private String assignId { get; set; }
        private String gender { get; set; }

        public clsStudent(String assignId)
        {
            this.assignId = assignId;
        }

        public clsStudent(String icPsp, String fName, String lName,
            String phone, String gender, String email, String assignId)//, String studentID)
        {
            this.icPsp = icPsp;
            this.fName = fName;
            this.lName = lName;
            this.phone = phone;
            this.email = email;
            this.assignId = assignId;
            this.gender = gender;
          
        }

        public clsStudent() { }

        public void AddPerson(String ICPsp, String FName, String LName,
          String Phone, String Gender, String Email, String assignID)
        {
            string insertSQL =
                    "INSERT INTO Student (studID, ICPsp, fName, lName, gender, phone, email) VALUES ('"
                    + assignID + "', '" + ICPsp + "', '" +
                    FName + "', '" +
                    LName + "', '" +
                    Gender + "', '" + Phone + "', '" +
                    Email + "')";

            con = new MySqlConnection(conString);

            MySqlCommand cmd = new MySqlCommand(insertSQL, con);
            con.Open();


            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void View_EditPerson(String ICPsp, String FName, String LName,
            String Phone, String Gender, String Email, String assignID)
        {
            string updateSQL =
                "UPDATE Student SET fName ='" + FName + "',lName='" + LName +
                "',ICPsp ='" + ICPsp + "',gender='" + Gender +
                "',email='" + Email + "',phone='" + Phone +
                "' WHERE studID ='" + assignID + "'";

            con = new MySqlConnection(conString);
            MySqlCommand com = new MySqlCommand(updateSQL, con);

            con.Open();
            updateDataReader = com.ExecuteReader();

            con.Close();

        }

        public void DeletePerson(String ICPsp, String FName, String LName,
            String Phone, String Gender, String Email, String assignId)
        {
            string deleteSQL =
                "DELETE FROM Student WHERE studID='" + assignId + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

        }

        public DataTable GetStudModTable()
        {
            string selectSQL =
                "SELECT * FROM StudMod";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            con.Open();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            con.Close();

            return dataTable;

        }

        public void DeleteAllStudMod()
        {
            string deleteSQL =
                    "DELETE FROM StudMod";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }


        public DataTable GetPreregTable()
        {
            string selectSQL =
                "SELECT * FROM Preregistration";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            con.Open();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            con.Close();

            return dataTable;

        }



        public void DeleteAllPrereg()
        {
            string deleteSQL =
                    "DELETE FROM Preregistration";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }


        public DataTable GetStudentsTable()
        {
            string selectSQL =
                "SELECT * FROM Student";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            con.Open();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            con.Close();

            return dataTable;

        }

    }
}
