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
    class clsModule
    {
        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader updateDataReader;

        private String mod_Code { get; set; }
        private String mod_Name { get; set; }
        private String mod_Preq { get; set; }
        private String hod_ID { get; set; }

        public clsModule(String mod_Code, String mod_Name, String mod_Preq, String hod_ID)
        {
            this.mod_Code = mod_Code;
            this.mod_Name = mod_Name;
            this.mod_Preq = mod_Preq;
            this.hod_ID = hod_ID;

        }

        public clsModule(String mod_Code, String hod_ID)
        {
           
            this.mod_Code = mod_Code;
            this.hod_ID = hod_ID;
        }

        public clsModule(String mod_Code)
        {

            this.mod_Code = mod_Code;
            
        }
        
        public clsModule(){ }


        public void AddModule(String mod_Code, String mod_Name, String mod_Preq, String hod_ID)
        {
            string insertSQL =
                    "INSERT INTO Module (modCode, modName, modPre, hodID) VALUES ('"
                    + mod_Code + "', '" + mod_Name + "', '" + mod_Preq + "', '" + hod_ID +"')";

            con = new MySqlConnection(conString);

            MySqlCommand cmd = new MySqlCommand(insertSQL, con);
            con.Open();


            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void View_EditModule(String mod_Code, String mod_Name, String mod_Preq, String hod_ID)
        {
            string updateSQL =
              "UPDATE Module SET modName ='" + mod_Name + "', modPre ='" + mod_Preq + "' WHERE modCode='" 
              + mod_Code +"'";

            con = new MySqlConnection(conString);
            MySqlCommand com = new MySqlCommand(updateSQL, con);

            con.Open();
            updateDataReader = com.ExecuteReader();

            con.Close();
        }

        public void DeleteModule(String mod_Code, String mod_Name, String mod_Preq, String hod_ID)
        {
            string deleteSQL =
                "DELETE FROM Module WHERE modCode='"+ mod_Code + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void AddModulesOfferedNext(String mod_Code, String hod_ID)
        {
            string insertSQL =
                    "INSERT INTO ModulesOffered (modCode, hodID) VALUES ('"+ mod_Code + 
                    "', '"+ hod_ID + "')";

            con = new MySqlConnection(conString);

            MySqlCommand cmd = new MySqlCommand(insertSQL, con);
            con.Open();


            cmd.ExecuteNonQuery();

            con.Close();
     
        }

        public void RemoveModuleOfferedNext(String mod_Code)
        {
            string deleteSQL =
                "DELETE FROM ModulesOffered WHERE modCode='" + mod_Code + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetModulesOfferedNextTable()
        {
            string selectSQL =
                "SELECT * FROM ModulesOffered";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            con.Open();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            con.Close();

            return dataTable;

        }

        public void RemoveAllModulesOffered()
        {
            string deleteSQL =
                    "DELETE FROM ModulesOffered";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(deleteSQL, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetModulesTable()
        {
            string selectSQL =
                "SELECT * FROM Module";

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
