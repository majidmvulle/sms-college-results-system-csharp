using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;

//MySQL .NET connector libraries 
//(added to the project as References)
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;

namespace SCRS_SMS
{
    class clsResultsSMS
    {

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlConnection connection;
        MySqlConnection connection1;
        MySqlDataReader DataReader;
        MySqlDataReader DataReader2;


        private string stud_ID { get; set; }
        private string ICPsp_No { get; set; }

        //Initialize an ArrayList
        ArrayList modCode_Arr = new ArrayList();
        
        //Constructor
        public clsResultsSMS(string stud_ID, string ICPsp_No)
        {
            this.stud_ID = stud_ID;
            this.ICPsp_No = ICPsp_No;
        }

        //Returns the student's results as string or any other appropriate
        //message
        public string giveStudentResults(string stud_ID, string ICPsp_No)
        {
            string results = "Sorry...Results NOT found!"+
                "\nCould be incorrect Student ID and/or "+
                "IC/Passport No. OR Student's Results are NOT available.";

            //Check if student with ID and ICPsp No. Exists
            try
            {
                string selectSQL =
                        "SELECT * FROM Student s WHERE s.studID ='" + stud_ID +
                        "' AND s.ICPsp='" + ICPsp_No + "'";

                con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(selectSQL, con);

                con.Open();

                DataReader = command.ExecuteReader();
                DataReader.Read();

                //If Student Exists
                if (DataReader.HasRows)
                {
                    try
                    {
                        //Check if student results are available
                        string selectResultsSQL =
                        "SELECT modCode, grade FROM Result r WHERE r.studID ='" + stud_ID + "'";

                        connection = new MySqlConnection(conString);

           
                        MySqlCommand comm = new MySqlCommand(selectResultsSQL, connection);
                        
                        connection.Open();

                        DataTable dataTable = new DataTable();
                       
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comm);

                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            //String Builder, to copy contents of the datatable
                            StringBuilder stringBuilder = new StringBuilder();

                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                foreach (DataColumn dataColumn in dataTable.Columns)
                                {
                                    stringBuilder.AppendFormat("{0}  ", (dataRow[dataColumn.ColumnName] == Convert.DBNull) ? string.Empty : dataRow[dataColumn.ColumnName].ToString());
                                }

                                stringBuilder.Append("\r\n");
                            }

                            //Convert String Builder to type string
                            results = "Latest Results;\n" + stringBuilder.ToString();
                        }

                        else
                            results = "Sorry...Results NOT found!" +
                    "\nCould be Student's Results are NOT available. See your HOD.";

                        connection.Close();
                    }
                    catch{
                        results = "Sorry...Results NOT found!" +
                    "\nCould be Student's Results are NOT available. See your HOD.";
                    }
                }
            }
            catch{

                results = "Sorry...Results NOT found!" +
                    "\nCould be incorrect Student ID and/or " +
                    "IC/Passport No.";
            }

            finally
            {
                DataReader.Close();
                con.Close();
            }

            return results;
        }

        //Return subjects to be offered next semester
        public string giveSubjectsOfferedNext(string stud_ID, string ICPsp_No)
        {
            string subjectsOffered = "Sorry...Subjects NOT found!" +
                "\nCould be incorrect Student ID and/or " +
                "IC/Passport No. OR next sem. subjects are NOT available.";

            //Check if student with ID and ICPsp No. Exists
            try
            {
                string selectSQL =
                        "SELECT * FROM Student s WHERE s.studID ='" + stud_ID +
                        "' AND s.ICPsp='" + ICPsp_No + "'";

                con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(selectSQL, con);

                con.Open();

                DataReader = command.ExecuteReader();
                DataReader.Read();

                //If Student Exists
                if (DataReader.HasRows)
                {
                    try
                    {
                        /********************/
                        string NIL = "NIL";
                        string failed = "F";

                        //Check if modules offered next are available and student completed prerequisites
                        string selectResultsSQL =
                        "SELECT modCode FROM ModulesOffered m WHERE m.modCode IN (SELECT modCode FROM Module d WHERE d.modPre = '" + NIL + 
                       "' OR d.modPre IN (SELECT modCode FROM CompletedModulesResults c WHERE c.studID = '" + stud_ID + "' AND c.grade <> '"+failed+"'))";

                        connection = new MySqlConnection(conString);


                        MySqlCommand comm = new MySqlCommand(selectResultsSQL, connection);

                        connection.Open();

                        DataTable dataTable = new DataTable();

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comm);

                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            //String Builder, to copy contents of the datatable
                            StringBuilder stringBuilder = new StringBuilder();

                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                foreach (DataColumn dataColumn in dataTable.Columns)
                                {
                                    stringBuilder.AppendFormat("{0}  ", (dataRow[dataColumn.ColumnName] == Convert.DBNull) ? string.Empty : dataRow[dataColumn.ColumnName].ToString());
                                }

                                stringBuilder.Append("\r\n");
                            }

                            //Convert String Builder to type string
                            subjectsOffered = "Next sem. Subjects;\n" + stringBuilder.ToString();
                        }
                        else
                            subjectsOffered = "Sorry...Subjects NOT found!" +
                    "\nMaybe next sem. subjects are NOT available OR you don't satisfy Prereqs.";
                            
                        connection.Close();
                    }
                    
                    catch {

                        subjectsOffered = "Sorry...Subjects NOT found!" +
                    "\nMaybe next sem. subjects are NOT available OR you don't satisfy Prereqs.";

                    }
                }
            }

            catch {

                subjectsOffered = "Sorry...Subjects NOT found!" +
                    "\nCould be incorrect Student ID and/or " +
                    "IC/Passport No.";
            }

            finally
            {
                DataReader.Close();
                con.Close();
            }

            return subjectsOffered;

        }
        
        //Preregistration
        public string preRegister(string stud_ID, string ICPsp_No)
        {
            string Prereg = "Preregistration failed!" +
                 "\nCould be incorrect Student ID and/or " +
                 "IC/Passport No. OR preregistration subjects are NOT available.";

            //Check if student with ID and ICPsp No. Exists
            try
            {
                string selectSQL =
                        "SELECT * FROM Student s WHERE s.studID ='" + stud_ID +
                        "' AND s.ICPsp='" + ICPsp_No + "'";

                con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(selectSQL, con);

                con.Open();

                DataReader = command.ExecuteReader();
                DataReader.Read();

                //If Student Exists
                if (DataReader.HasRows)
                {
                    try
                    {

                        string NIL = "NIL";
                        string failed = "F";

                        //Check if modules offered next are available and student completed prerequisites
                        string selectResultsSQL =
                        "SELECT modCode FROM ModulesOffered m WHERE m.modCode IN (SELECT modCode FROM Module d WHERE d.modPre = '" + NIL +
                        "' OR d.modPre IN (SELECT modCode FROM CompletedModulesResults c WHERE c.studID = '" + stud_ID + "' AND c.grade <> '" + failed + "'))";


                        connection1 = new MySqlConnection(conString);


                        MySqlCommand comm1 = new MySqlCommand(selectResultsSQL, connection1);

                        connection1.Open();

                        DataReader2 = comm1.ExecuteReader();

                   
                        if (DataReader2.HasRows)
                        {
                            while (DataReader2.Read())
                            {
                                //Store each module code in ArrayList
                                modCode_Arr.Add(DataReader2.GetString("modCode").ToString());

                            }

                            StringBuilder stringBuilder = new StringBuilder();

                            for (int i = 0; i < modCode_Arr.Count; i++)
                            {
                                string value = modCode_Arr[i] as string;

                                string insertSQL = "INSERT INTO Preregistration (studID, modCode) VALUES ('" + stud_ID + "', '" + value + "')";

                                connection = new MySqlConnection(conString);
                                connection.Open();

                                MySqlCommand comm2 = new MySqlCommand(insertSQL, connection);


                                stringBuilder.AppendFormat("{0}", (value.ToString()));

                                stringBuilder.Append("\n");
                                comm2.ExecuteNonQuery();

                                connection.Close();

                            }

                            //Convert String Builder to type string
                            string subjects = stringBuilder.ToString();

                           Prereg = "Successfully Preregistered for: " + subjects + ". See your HOD for details";

                        }

                        else
                        {
                            Prereg = "PreRegistration failed!\nStudent doesn't meet Prerequisites requirements.See your HOD";
                            return Prereg;
                        }

                      
                    }

                    catch
                    {
                        Prereg = "Preregistration failed!" +
                "\nYou could have performed Preregistration already.See your HOD";
                    }

                    finally
                    {
                        DataReader2.Close();
                        connection1.Close();
                    }

                }

                    
                }

            catch{
                Prereg = "Preregistration failed!" +
                 "\nCould be incorrect Student ID and/or " +
                 "IC/Passport No. OR preregistration subjects are NOT available.";
            }
            
            finally{

                DataReader.Close();
                con.Close();
            }


            return Prereg;
        }
    }
}
