using System;

namespace OOPConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = Employee.Create(1000, "Issam", "A.");

            Console.WriteLine(e1.DisplayName());
            Console.ReadKey();
        }
    }

    public class Employee
    {
        private Employee() { }
        private Employee(int id, string fname, string lname)
        {
            this.id = id;
            this.fName = fname;
            this.lName = lname;

        }

        public static Employee Create(int id, string fname, string lname)
        {
            return new Employee(id, fname, lname);
        }

        private int id;
        private string fName;
        private string lName;

       public string DisplayName()
        {
            return $"Id: {id} Name:{fName} {lName}\n";
        }
    }
}
