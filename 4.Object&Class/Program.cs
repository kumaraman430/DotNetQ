using System;

namespace _4.Object_Class
{
    class Object_Class_Example
    {
        //class Student
        //{
        //    public int id;      //By default field is private. To access it we have to make it public
        //    public string name; //By default field is private. To access it we have to make it public
        //}
        //static void Main(string[] args)
        //{
        //    Student st = new Student();
        //    st.id = 1;
        //    st.name = "Aman Kumar";

        //    Console.WriteLine(st.id);
        //    Console.WriteLine(st.name);
        //    Console.ReadKey();
        //}
    }
    class Having_Main_in_another_Class
    {
        //class Student
        //{
        //    public int Id;
        //    public string Name;
        //}
        //class TestStudent
        //{
        //    static void Main(string[] args)
        //    {
        //        Student st = new Student();
        //        st.Id = 1;
        //        st.Name = "Aman Kumar";

        //        Console.WriteLine(st.Id);
        //        Console.WriteLine(st.Name);
        //        Console.ReadKey();
        //    }
        //}
    }
    class Initialize_and_Display_through_Method
    {
        //class Student
        //{
        //    int Id;
        //    string Name;

        //    public void Insert(int i, string n)
        //    {
        //        Id = i;
        //        Name = n;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine(Id + " " + Name);
        //    }
        //}

        //class StudentTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Student st1 = new Student();
        //        Student st2 = new Student();

        //        st1.Insert(1, "Aman Kumar");
        //        st2.Insert(2, "Jack Sparrow");
        //        st1.Display();
        //        st2.Display();
        //        Console.ReadKey();
        //    }
        //}
    }
    class Store_and_display_Employee_Example
    {
        //class Employee
        //{
        //    int EmpId;
        //    string EmpName;
        //    float EmpSalary;
        //    public void Insert(int id, string name, float salary)
        //    {
        //        EmpId = id;
        //        EmpName = name;
        //        EmpSalary = salary;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine("Id : " + EmpId);
        //        Console.WriteLine("Name : " + EmpName);
        //        Console.WriteLine("Salary : " + EmpSalary);
        //    }
        //}
        //class EmployeeInfo
        //{
        //    static void Main(String[] args)
        //    {
        //        Employee emp1 = new Employee();
        //        Employee emp2 = new Employee();
        //        emp1.Insert(1,"Aman Kumar", 50000);
        //        emp2.Insert(2, "Jack Sparrow", 500000);
        //        emp1.Display();
        //        emp2.Display();
        //        Console.ReadKey();
        //    }
        //}
    }

    class Default_Constructor
    {
        //class Employee
        //{
        //    public Employee()
        //    {
        //        Console.WriteLine("Default Constructor");
        //    }
        //}
        //class EmployeeTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Employee emp1 = new Employee();
        //        Employee emp2 = new Employee();
        //    }
        //}
    }
    class Parameterized_Constructor
    {
        //class Employee
        //{
        //    int Id;
        //    string Name;
        //    float Salary;
        //    public Employee(int id, string name, float salary)
        //    {
        //        Id = id;
        //        Name = name;
        //        Salary = salary;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine("Id : " + Id);
        //        Console.WriteLine("Name : " + Name);
        //        Console.WriteLine("Salary : " + Salary);
        //    }
        //}
        //class EmployeeTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Employee emp1 = new Employee(1, "Aman Kumar", 45000);
        //        Employee emp2 = new Employee(2, "Jack Sparrow", 500000);

        //        emp1.Display();
        //        emp2.Display();

        //        Console.ReadKey();
        //    }
        //}
    }
}
