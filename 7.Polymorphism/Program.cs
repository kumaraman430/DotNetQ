using System;

namespace _7.Polymorphism
{
    // Method Overloading :
    // Purpose : To add more methods with the same name but different parameters
    // Type : Compile-time Polymorphism
    // Keywords : No special keywords required

    // Method Overriding : 
    // Purpose : To change the behaviour of an inherited method
    // Type : Run-time Polymorphism
    // Keywords : Uses override keyword in the derived class and virtual keyword in the base class
    class Member_Overloading
    {
        // If we create two or more members having same name but different in number or type of parameter, it is known as member overloading. In C# we can overload : 
        // 1.Methods , 2.Constructors , 3.Indexed properties
        // It is because these members have parameters only.

        // Having two or more methods with same name but different in parameters, is known as method overloading in C#.
        // The advantage of method overloading is that it increases the readability of the program because we don't need to use different name for same actions. It can performed by two ways
        // 1. By changing number of arguments
        // 2. By changing data type of arguments
        // 3. By changing order of parameters of methods
        class Method_Overloading
        {
            class By_Changing_Number_of_Arguments
            {
                //    class cal
                //    {
                //        public static int add(int a, int b)
                //        {
                //            return a + b;
                //        }
                //        public static int add(int a, int b, int c)
                //        {
                //            return a + b + c;
                //        }
                //    }
                //    class CalTest
                //    {
                //        static void Main(string[] args)
                //        {
                //            Console.WriteLine(cal.add(12, 12));
                //            Console.WriteLine(cal.add(12, 12, 12));
                //        }
                //    }
            }
            class By_Changing_Datatype_of_Arguments
            {
                //    class cal
                //    {
                //        public static int add(int a, int b)
                //        {
                //            return a + b;
                //        }
                //        public static float add(float a, float b)
                //        {
                //            return a + b;
                //        }
                //    }
                //    class CalTest
                //    {
                //        static void Main(string[] args)
                //        {
                //            Console.WriteLine(cal.add(12, 23));
                //            Console.WriteLine(cal.add(12.4f, 21.3f));
                //        }
                //    }
            }
            class By_Changing_order_of_Parameters_of_methods
            {
                //class DNT
                //{
                //    public void Identity(string name, int id)
                //    {
                //        Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
                //    }
                //    public void Identity(int id, string name)
                //    {
                //        Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
                //    }
                //}
                //class DNTTest
                //{
                //    static void Main(string[] args)
                //    {
                //        DNT dNT = new DNT();
                //        dNT.Identity("Aman", 101);
                //        dNT.Identity(102, "Kumar");
                //    }
                //}
            }
        }

        // If derived class defines same method as defined in its base class, it is known as method overriding in C#.
        // It is used to achieve runtime polymorphism
        // To perform method overriding in C#, we need to use virtual keyword with base class method and override keyword with derived class method.
        // There are three types of keywords for method overriding : Virtual keyword, Override keyword, Base keyword
        class Method_Overriding
        {
            //class Animal
            //{
            //    public virtual void eat()
            //    {
            //        Console.WriteLine("Eating...");
            //    }
            //}
            //class Dog : Animal
            //{
            //    public override void eat()
            //    {
            //        Console.WriteLine("Eating... bread");
            //    }
            //}
            //class Method_OverridingTest
            //{
            //    static void Main(string[] args)
            //    {
            //        Dog dog = new Dog();
            //        dog.eat();
            //    }
            //}
        }

        // Base keyword is used to access fields, constructors and methods of base class
        class BaseKeyword
        {
            class BaseKeyword_access_base_class_field
            {
                //class Animal
                //{
                //    public string color = "white";
                //}
                //class Dog : Animal
                //{
                //    string color = "black";
                //    public void showcolor()
                //    {
                //        Console.WriteLine(base.color);
                //        Console.WriteLine(color);
                //    }
                //}
                //class BaseKeyword_access_base_class_fieldTest
                //{
                //    static void Main(string[] args)
                //    {
                //        Dog dog = new Dog();
                //        dog.showcolor();
                //    }
                //}
            }
            class BaseKeyword_access_base_class_method
            {
                //class Animal
                //{
                //    public virtual void eat()
                //    {
                //        Console.WriteLine("Eating...");
                //    }
                //}
                //class Dog : Animal
                //{
                //    public override void eat()
                //    {
                //        base.eat();
                //        Console.WriteLine("Eating...bread");
                //    }
                //}
                //class BaseKeyword_access_base_class_methodTest
                //{
                //    static void Main(string[] args)
                //    {
                //        Dog dog = new Dog();
                //        dog.eat();
                //    }
                //}
            }
            class BaseKeyword_access_base_class_constructor
            {
                // class Animal
                // {
                //     public Animal()
                //     {
                //         Console.WriteLine("Animal...");
                //     }
                // }
                // class Dog : Animal
                // {
                //     public Dog()
                //     {
                //         Console.WriteLine("Dog...");
                //     }
                // }
                //class BaseKeyword_access_base_class_constructorTest
                // {
                //     static void Main(string[] args)
                //     {
                //         Dog dog = new Dog();
                //     }
                // }
            }
        }

        class Polymorphism
        {
            class Runtime_Polymorphism_Example1
            {
                //class Animal
                //{
                //    public virtual void eat()
                //    {
                //        Console.WriteLine("Eating...");
                //    }
                //}
                //class Dog : Animal
                //{
                //    public override void eat()
                //    {
                //        Console.WriteLine("Eating...bread");
                //    }
                //}
                //class Runtime_PolymorphismTest
                //{
                //    static void Main(string[] args)
                //    {
                //        Animal a = new Animal();
                //        Animal b = new Dog();

                //        a.eat();
                //        b.eat();
                //    }
                //}
            }
            class Runtime_Polymorphism_Example2
            {
                //class Shape
                //{
                //    public virtual void draw()
                //    {
                //        Console.WriteLine("drawing...");
                //    }
                //}
                //class triangle : Shape
                //{
                //    public override void draw()
                //    {
                //        Console.WriteLine("Triangle...");
                //    }
                //}
                //class square : Shape
                //{
                //    public override void draw()
                //    {
                //        Console.WriteLine("Square...");
                //    }
                //}
                //class Runtime_PolymorphismTest
                //{
                //    static void Main(string[] args)
                //    {
                //        Shape s1 = new Shape();
                //        Shape s2 = new triangle();
                //        Shape s3 = new square();

                //        s1.draw();
                //        s2.draw();
                //        s3.draw();  
                //    }
                //}
            }
            class Runtime_Polymorphism_with_datamembers
            {
                //class Animal
                //{
                //    public string color = "white";
                //}
                //class Dog : Animal
                //{
                //    public string color = "black";
                //}
                //class Runtime_Polymorphism_with_datamembersTest
                //{
                //    static void Main(string[] args)
                //    {
                //        Animal a = new Dog();
                //        Console.WriteLine(a.color); // Output : white
                //    }
                //}

                //class Animal
                //{
                //    public virtual string color => "white";
                //}
                //class Dog : Animal
                //{
                //    public override string color => "black";
                //}
                //class Runtime_Polymorphism_with_datamembersTest
                //{
                //    static void Main(string[] args)
                //    {
                //        Animal a = new Dog();
                //        Console.WriteLine(a.color); // Output : black
                //    }
                //}
            }
        }

        // Sealed keyword applies restrictions on the class and method.
        // Sealed class cannot be derived.
        // Sealed method cannot be overridden.
        class Sealed
        {
            class Sealed_class
            {
                //sealed public class Animal
                //{
                //    public void eat()
                //    {
                //        Console.WriteLine("eating...");
                //    }
                //}
                //class Dog : Animal
                //{
                //    public void bark()
                //    {
                //        Console.WriteLine("barking...");
                //    }
                //}
                //class Sealed_class_Test
                //{
                //    static void Main(string[] args)
                //    {
                //        Dog d = new Dog();
                //        d.eat(); // Compile-time error : 'Dog' cannot derive from sealed type 'Animal'
                //        d.bark();
                //    }
                //}
            }
            class Sealed_method
            {
                //class Animal
                //{
                //    public virtual void eat()
                //    {
                //        Console.WriteLine("eating...");
                //    }
                //    public virtual void run()
                //    {
                //        Console.WriteLine("running...");
                //    }
                //}
                //class Dog : Animal
                //{
                //    public override void eat()
                //    {
                //        Console.WriteLine("eating bread...");
                //    }
                //    public sealed override void run()
                //    {
                //        Console.WriteLine("running slowly...");
                //    }
                //}
                //class BabyDog : Dog
                //{
                //    public override void eat()
                //    {
                //        Console.WriteLine("eating biscits...");
                //    }
                //    public override void run() // cannot override inherited member 'Dog.run()' becoz it is sealed
                //    {
                //        Console.WriteLine("running slowly...");
                //    }
                //}
                //class Sealed_methodTest
                //{
                //    static void Main(string[] args)
                //    {
                //        BabyDog d = new BabyDog();
                //        d.eat();
                //        d.run();
                //    }
                //}
            }
        }
    }
}