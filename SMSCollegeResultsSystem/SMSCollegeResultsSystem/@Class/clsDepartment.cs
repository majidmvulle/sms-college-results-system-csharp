using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;

namespace SMSCollegeResultsSystem._Class
{
    class clsDepartment
    {

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader updateDataReader;


        private String hod_ID { get; set; }
        private String dept_Name { get; set; }
        private String dean_ID { get; set; }


        public clsDepartment(String hod_ID, String dept_Name, String dean_ID)
        {
            this.hod_ID = hod_ID;
            this.dept_Name = dept_Name;
            this.dean_ID = dean_ID;
        }


        public void AddDepartment(String hod_ID, String dept_Name, String dean_ID)
        {
            string insertSQL =
                    "INSERT INTO Dept (hodID, deptName, deanID) VALUES ('"
                    + hod_ID + "', '" + dept_Name + "', '" + dean_ID + "')";

            con = new MySqlConnection(conString);

            MySqlCommand cmd = new MySqlCommand(insertSQL, con);
            con.Open();


            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void View_EditDepartment(String hod_ID, String dept_Name, String dean_ID)
        {
            string updateSQL =
              "UPDATE Dept SET deptName ='" + dept_Name + "', hodID ='" + hod_ID + "' WHERE deanID='" 
              + dean_ID + "'";

            con = new MySqlConnection(conString);
            MySqlCommand com = new MySqlCommand(updateSQL, con);

            con.Open();
            updateDataReader = com.ExecuteReader();

            con.Close();
        }

        public void DeleteDepartment(String hod_ID, String dept_Name, String dean_ID)
        {
            string deleteSQL =
                "DELETE FROM Dept WHERE hodID='" + hod_ID + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
