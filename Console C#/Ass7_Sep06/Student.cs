using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7_Sep06
{
    public class Student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

        public static void Change()
        {
            college = "CODEGYM";
        }

        //method to display values
        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}
