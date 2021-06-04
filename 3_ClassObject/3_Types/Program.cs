using System;

namespace _3_Types
{
    class Country
    {
        public int x;
        public int y;
    }

    struct State
    {
        public int x;
        public int y;
        public Country country;
    }

    public class Person
    {
        public string name;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country();
            Country country2 = new Country();
            State state1 = new State();
            State state2 = new State();

            state2.x = 1;
            state2.y = 2;

            state1 = state2;
            state2.x = 5;

            Console.WriteLine(state1.x);
            Console.WriteLine(state2.x);

            country1.x = 5;
            country1.y = 6;

            country1 = country2;
            country2.x = 7;

            Console.WriteLine(country1.x);
            Console.WriteLine(country2.x);

            Person p = new Person { name = "Mike", age = 33 };
            ChangePerson(p);

            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            Console.Read();
        }

        public static void ChangePerson(Person person)
        {
            person.name = "Alise";

            person = new Person { name = "Bill", age = 45};
            Console.WriteLine(person);
        }
    }
}
