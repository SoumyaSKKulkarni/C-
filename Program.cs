using System;

namespace Assignment_3Q_1
{
    interface IStudent
    {
        void Register();
        void PostCourseWork(string work);
    }
    class Employee
    {
        public int empId;
        public string eName;
        public Employee(int id,string name)
        {
            empId = id;
            eName = name;
            Console.WriteLine(empId + " " + eName);
        }

    }
    class PartTimeStudent : Employee,IStudent
    {

        string LibCardNumber;
        string Year;
        public PartTimeStudent(string lcn,string year,int id,string name):base(id,name)
        {
            LibCardNumber = lcn;
            Year = year;
            Console.WriteLine(LibCardNumber + " " + Year);
        }
        public void Register()
        {
            Console.WriteLine(eName + ", you have successfully registered as student.\n" + LibCardNumber + "is your Library card number");
        }
        public void PostCourseWork(string work)
        {
            Console.WriteLine("You have completed your course on " + work + " that began on" + Year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  Employee e = new Employee(234,"Abhay Kashyap");
            PartTimeStudent pts = new PartTimeStudent("L124", "24/08/2020", 234, "Abhay Kashyap");
            pts.Register();
            pts.PostCourseWork("Data Structures");
        }
    }
}
