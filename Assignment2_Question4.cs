using System;
//A person has several attributes that include name,
//date of birth, address
//and marital status (single, married, divorced or widowed).
  
namespace Assignment_2_Q4
{
    class Person
    {
        //Create a four parameter constructor to initialise the fields
        public string name;
        public string dob;
        public string address;
        public string marital_status;
        public Person(string name,string dob,string address,string marital_status)
        {
            this.name = name;
            this.dob = dob;
            this.address = address;
            this.marital_status = marital_status;
        }
        //Add properties for the fields
        public string Name
        {
            get;
            set;
        }
        public string Dob
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Marital_status
        {
            get;
            set;
        }
        //Write a method GetAge() to return the age of the person  
        //13-01-1999
        public int GetAge()
        {
            string year = dob.Substring(6);
            int y = int.Parse(year);
            return 2021 - y;
        }
        //Write a method CanMarry() to return true or false if
        //a person can get married (people can get married over
        //the age of 18 if they are not already maried)
        public bool CanMarry()
        {
            string year = dob.Substring(6);
            int y = int.Parse(year);
            int age=2021 - y;
            if(age<18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Override the ToString() method to display the persons details to the screen
        //(format = Fred lives at 21 Lancaster road, born on 12/12/1980, single, 20 years old
        //and can marry)  
        public override string ToString()
        {
            int age = GetAge();
            bool status = CanMarry();
            if(status==false)
            {
                return $"{name} lives at {address},born on {dob},{marital_status},{age} years old and can marry";
            }
            else
            {
                return $"{name} lives at {address},born on {dob},{marital_status},{age} years old.";
            }
        }
        
                 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Abhay", "15/08/2005", "Delhi", "Single");
            Console.WriteLine("Age= " + p1.GetAge());
            bool status = p1.CanMarry();
            if(status==true)
            {
                string ms = p1.Marital_status;
                if(ms=="Single")
                {
                    Console.WriteLine("You can get married");
                }
                
            }
            else
            {
                Console.WriteLine("You are minor(below 18)");
            }
            Console.WriteLine();
            Console.WriteLine(p1.ToString());



        }

    }
}
