using System;

namespace ConsoleApp1
{
    /*In C# as class can have fields, functions, properties, events, nested classesdata of the 
    classs is called Fields.
    operations of the class is called Functions or member functions
    properties are smart functions with get/set block.
    Fields are usually hidden members(Private)..
    To access fields we use properties: get/set
    as a class is user defined type,we need definition of the class.THe definition tells
     what your user defnied type does: what data it will represent, what operations it does, what data it holds*/
    //The actual variable of the class created using new operator in c# . This variable is called OBJECT in OOP.
    class Employee
    {
        int id;
        string name, address;
        long phone;

        //creating property in C#
        public int EmployeeID
        {
            get { return id; }
            set { id = value;  }
        }

        public String EmpName
        {
            get { return name; }
            set { name = value; }
        }

        public string EmpAddres
        {
            get { return address;  }
            set { address = value; }
        }

        public long EmpPhone
        {
            get { return phone; }
            set { phone = value; }   
        }

        static boolean isValidDate(int year, int month, int day)
        {
            if(year < 12)
            {
                
            }
            return false;
        }


    }

    class ClassDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeID = 123;
            emp.EmpName = "Sachin Kumar";
            emp.EmpAddres = "Bangalore";
            emp.EmpPhone = 237283829382;
            Console.WriteLine($"The name of the Employee is {emp.EmpName} from {emp.EmpAddres} who can can be contacted 

        }
    }
}