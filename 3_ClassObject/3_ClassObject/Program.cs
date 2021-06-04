using System;

namespace _3_ClassObject
{
    public class Person
    {
        //public Person() { name = "Undefined"; age = 18; }
        //public Person(string n) { name = n; age = 18; }
        //public Person(string n, int b) { name = n; age = b; }

        public string name;
        public int age;

        public Person(): this("Undefined")
        {
        }

        public Person(string name) : this(name, 18)
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo() {
            Console.WriteLine($"Name is: {name} and age is: {age}");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.GetInfo();

            //tom.name = "Tomas";
            //tom.age = 55;
            //tom.GetInfo();

            //Person bob = new Person();
            //Person john = new Person("John");
            //Person sam = new Person("Sam", 38);

            //bob.GetInfo();
            //john.GetInfo();
            //sam.GetInfo();

            Person sam = new Person { name = "Sam", age = 18 };
            sam.GetInfo();

            Console.ReadKey();
        }
    }
}
