using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;

namespace SMSCollegeResultsSystem._Class
{
    class clsSchool
    {
        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader updateDataReader;

        private String sch_name { get; set; }
        private String deanID { get; set; }

        public clsSchool(String sch_Name, String deanID)
        {
            this.sch_name = sch_name;
            this.deanID = deanID;
        }
    
        public void AddSchool(String sch_Name, String deanID)
        {
            string insertSQL =
                    "INSERT INTO School (deanID, schName ) VALUES ('"
                    + deanID + "', '" + sch_Name + "')";

            con = new MySqlConnection(conString);

            MySqlCommand cmd = new MySqlCommand(insertSQL, con);
            con.Open();


            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void View_EditSchool(String sch_Name, String deanID)
        {
            string updateSQL =
               "UPDATE School SET deanID ='" + deanID + "' WHERE schName='" + sch_Name +"'";
                       
            con = new MySqlConnection(conString);
            MySqlCommand com = new MySqlCommand(updateSQL, con);

            con.Open();
            updateDataReader = com.ExecuteReader();

            con.Close();
        }

        public void DeleteSchool(String sch_Name, String deanID)
        {
            string deleteSQL =
                "DELETE FROM School WHERE schName='" + sch_Name + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
