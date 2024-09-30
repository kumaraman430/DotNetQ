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

    class Destructor
    {
        //class Employee
        //{
        //    public Employee()
        //    {
        //        Console.WriteLine("Constructor Invoked");
        //    }
        //    ~Employee()
        //    {
        //        Console.WriteLine("Destructor Invoked");
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

    class this_Example
    {
        //class Employee
        //{
        //    int Id;
        //    string Name;
        //    float Salary;
        //    public Employee(int id, string name, float salary)
        //    {
        //        this.Id = id;
        //        this.Name = name;
        //        this.Salary = salary;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine("Id : {0}\nName : {1}\nSalary : {2}", Id, Name, Salary);
        //    }
        //}
        //class EmployeeTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Employee emp1 = new Employee(1, "Aman", 45000);
        //        Employee emp2 = new Employee(2, "Jack", 45000000);

        //        emp1.Display();
        //        emp2.Display();
        //    }
        //}
    }

    class static_Example
    {
        //class Account
        //{
        //    int accno;
        //    string name;
        //    public static float rateofinterest = 8.8f;
        //    public static int count = 0;
        //    public Account(int AccNo, string Name)
        //    {
        //        this.accno = AccNo;
        //        this.name = Name;
        //        count++;
        //    }

        //    public void Display()
        //    {
        //        Console.WriteLine(accno + " " + name + " " + rateofinterest);
        //    }
        //}
        //class AccountTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Account.rateofinterest = 10.5f; //Changing value

        //        Account acc1 = new Account(101, "Aman");
        //        Account acc2 = new Account(102, "Jack");
        //        Account acc3 = new Account(103, "Spaorrow");

        //        acc1.Display();
        //        acc2.Display();
        //        acc3.Display();

        //        Console.WriteLine("Total objects are : " + Account.count);
        //    }
        //}
    }

    class static_class_Example
    {
        //static class myMath
        //{
        //    public static float PI = 3.14f;
        //    public static int cube(int n)
        //    {
        //        return n * n * n;
        //    }
        //}
        //class myMathTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Value of PI is : {0}", myMath.PI);
        //        Console.WriteLine("Cube of 3 is : {0}",myMath.cube(3));
        //    }
        //}
    }

    class static_Constructor_Example
    {
        //class Account
        //{
        //    int id;
        //    string name;
        //    static float rateofinterest;
        //    public Account(int Id, string Name)
        //    {
        //        this.id = Id;
        //        this.name = Name;
        //    }
        //    static Account()
        //    {
        //        rateofinterest = 9.5f;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine(id + " " + name + " " + rateofinterest);
        //    }
        //}
        //class AccountTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Account acc1 = new Account(101, "Aman");
        //        Account acc2 = new Account(102, "Jack");

        //        acc1.Display();
        //        acc2.Display();
        //    }
        //}
    }

    class struct_Example
    {
        //public struct Rectangle
        //{
        //    public int width, height;
        //}
        //class RectangleTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Rectangle r = new Rectangle();
        //        r.width = 4;
        //        r.height = 5;

        //        Console.WriteLine("Area of Rectangle is : " + (r.width * r.height));
        //    }
        //}
    }

    class struct_Contructor_Example
    {
        //struct Rectangle
        //{
        //    int width, height;

        //    public Rectangle(int w, int h)
        //    {
        //        width = w;
        //        height = h;
        //    }
        //    public void areaofRectangle()
        //    {
        //        Console.WriteLine("Area of Rectangle is : {0}", (width * height));
        //    }
        //}
        //class RectangleTest
        //{
        //    static void Main(string[] args)
        //    {
        //        Rectangle rect = new Rectangle(5, 6);
        //        rect.areaofRectangle();
        //    }
        //}
    }

    class Enum_Example
    {
        //class Simple_Enum_Example
        //{
        //    enum Season { WINTER, SPRING, SUMMER, FALL }
        //    static void Main(string[] args)
        //    {
        //        int x = (int)Season.WINTER;
        //        int y = (int)Season.SUMMER;

        //        Console.WriteLine("WINTER = {0}", x);
        //        Console.WriteLine("SUMMER = {0}", y);
        //    }
        //}

        //class Change_Start_Index_Enum_Example
        //{
        //    enum Season { WINTER = 10, SPRING, SUMMER, FALL }
        //    static void Main(string[] args)
        //    {
        //        int x = (int)Season.WINTER;
        //        int y = (int)Season.SUMMER;

        //        Console.WriteLine("WINTER = {0}", x);
        //        Console.WriteLine("SUMMER = {0}", y);
        //    }
        //}

        //class Days_Enum_Example
        //{
        //    enum Days { Sun, Mon, Tue, Wed, Thus, Fri, Sat }

        //    static void Main(string[] args)
        //    {
        //        int x = (int)Days.Sun;
        //        int y = (int)Days.Mon;
        //        int z = (int)Days.Sat;

        //        Console.WriteLine("Sun = {0}", x);
        //        Console.WriteLine("Mon = {0}", y);
        //        Console.WriteLine("Sat = {0}", z);
        //    }
        //}

        //class traversing_Enum_Example
        //{
        //    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }

        //    static void Main(string[] args)
        //    {
        //        foreach (string s in Enum.GetNames(typeof(Days))) // Traversing all value using getNames()
        //        {
        //            Console.WriteLine(s);
        //        }

        //        foreach (Days d in Enum.GetValues(typeof(Days))) // Traversing all values using getValues()
        //        {
        //            Console.WriteLine(d);
        //        }
        //    }
        //}
    }
}
