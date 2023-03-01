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
    class clsLecturer:IPerson
    {
        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader updateDataReader;
        

        private String icPsp { get; set; }
        private String fName { get; set; }
        private String lName { get; set; }
        private String phone { get; set; }
        private String gender { get; set; }
        private String email { get; set; }
        private String assignId { get; set; }
     

        public clsLecturer(String icPsp, String fName, String lName,
           String phone, String gender, String email, String assignId)
          
        {
            this.icPsp = icPsp;
            this.fName = fName;
            this.lName = lName;
            this.phone = phone;
            this.email = email;
            this.assignId = assignId;      

        }

        public clsLecturer() { }

       

        public void AddPerson(String ICPsp, String FName, String LName,
            String Phone, String Gender, String Email, String assignID)
        {
            string insertSQL =
                    "INSERT INTO Lecturer (lectID, ICPsp, fName, lName, gender, phone, email) VALUES ('"
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
            String Phone, String Gender, String Email, String assignId)
        {
            string updateSQL =
               "UPDATE Lecturer SET fName ='" + FName + "',lName='" + LName +
               "',ICPsp ='" + ICPsp + "',gender='" + Gender +
               "',email='" + Email + "',phone='" + Phone +
               "' WHERE lectID ='" + assignId + "'";

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
                "DELETE FROM Lecturer WHERE lectID='" + assignId + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetLecturerTable()
        {
            string selectSQL =
                "SELECT * FROM Lecturer";

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
