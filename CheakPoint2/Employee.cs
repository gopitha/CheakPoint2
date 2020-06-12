using System;
using System.Collections.Generic;
using System.Text;

namespace CheakPoint2
{
    class Employee:Person
    {
        
     public int HireDate { get;  set; }

     public Employee()
        { }

        public Employee(int HireDate) : base ("Employee",23 )
        {
            this.HireDate = HireDate;

        }

      

        public static string Describe()

        {
            return "The Employee class gives info about name, age and hiredate.";

        }



    }
}
