using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;


namespace SMSCollegeResultsSystem._Class
{
    class clsStudMod
    {
        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;

        private String mod_Code { get; set; }
        private String stud_ID { get; set; }

        public clsStudMod(String mod_Code, String stud_ID)
        {
            this.mod_Code = mod_Code;
            this.stud_ID = stud_ID;
        }

        public void RegStudMod(String mod_Code, String stud_ID)
        {
            string insertSQL =
                    "INSERT INTO StudMod (modCode, studID) VALUES ('"
                    + mod_Code + "', '" + stud_ID + "')";

            con = new MySqlConnection(conString);

            MySqlCommand cmd = new MySqlCommand(insertSQL, con);
            con.Open();


            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void DeRegStudMod(String mod_Code, String stud_ID)
        {
            string deleteSQL =
                "DELETE FROM StudMod WHERE studID='" + stud_ID + "' AND modCode='" + mod_Code + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
