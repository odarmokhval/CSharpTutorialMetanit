using System;

namespace _4_Structures
{
    struct User
    {
        public string name;
        public int age;

        public User(string name, int age)
        {
            //cannot in struct
            //public string name = "Sam";     // ! Ошибка
            //public int age = 23;            // ! Ошибка

            this.name = name;
            this.age = age;
        }

        public void GetInfo() {
            Console.WriteLine($"Name: {name} and age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User { name = "Tom", age = 77 };
            //tom.name = "Tom";

            //cannot get the field before the struct initialisation
            //int x = tom.age;
            //tom.GetInfo();

            //User ivan = new User();
            tom.GetInfo();


            Console.ReadKey();
        }
    }
}
