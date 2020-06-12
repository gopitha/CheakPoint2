using System;




namespace CheakPoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Checkpoint, uke 2";

          

            Person FirstPerson = new Person();
            FirstPerson.Name = "Gunnil Moen";
            FirstPerson.Age = 40;

            Console.WriteLine("Navn: " + FirstPerson.Name + ", Alder: " + FirstPerson.Age);

            Company FirstCompany = new Company();
            FirstCompany.EmployeeCount = 30;

            Console.WriteLine("Selskapet har: " + FirstCompany.EmployeeCount + " ansatte.");

            Employee FirstEmployee = new Employee();
            FirstEmployee.Name = "Hans Petter";
            FirstEmployee.Age = 30;
            FirstEmployee.HireDate= 12032002;

            
            Console.WriteLine("Navn:" + FirstEmployee.Name +  "  " + " Gammel:"+ FirstEmployee.Age + "  "+" Ansettelsesdato:" + FirstEmployee.HireDate);
            Employee.Describe();
            Console.WriteLine(Employee.Describe());

            Console.ReadLine();
           
        }
    }

}
