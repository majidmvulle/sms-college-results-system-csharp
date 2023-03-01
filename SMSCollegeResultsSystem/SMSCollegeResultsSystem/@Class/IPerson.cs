using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSCollegeResultsSystem._Class
{
   public interface IPerson
    {


        void AddPerson(String ICPsp, String FName,String LName,
            String Phone, String Gender, String Email, String assignID);

        void View_EditPerson(String ICPsp, String FName, String LName,
            String Phone, String Gender, String Email, String personID);

        void DeletePerson(String ICPsp, String FName, String LName,
            String Phone, String Gender, String Email, String personID);


    }
}
