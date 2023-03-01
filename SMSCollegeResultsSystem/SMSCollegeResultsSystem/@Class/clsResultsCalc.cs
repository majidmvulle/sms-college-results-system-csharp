using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSCollegeResultsSystem._Class
{
    class clsResultsCalc
    {
        private double marks { get; set; }

        public clsResultsCalc(double marks)
        {
            this.marks = marks;
        }

        public float getMarks(float marks)
        {
            return marks;
        }

        public String calcGrade()
        {
            // float newmarks;
            string grade = "";

            if (marks >= 70 && marks < 101)
            {
                grade = "A";

            }
            else if (marks >= 60 && marks < 70)
            {
                grade = "B+";

            }
            else if (marks >= 50 && marks < 60)
            {
                grade = "B";

            }
            else if (marks >= 41 && marks < 50)
            {
                grade = "C";

            }
            else if (marks == 40)
            {
                grade = "D";

            }
            else if (marks < 40 && marks > 0)
            {
                grade = "F";

            }
            else
            {
                grade = "X";

            }
            return grade;
        }

    }
}
