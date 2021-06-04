using _3_ClassObject;
using printer = System.Console;
using PersonUser = _4_Namespaces.User;
using _51_CreateClassLibrary;

namespace _4_Namespaces
{
    class Program
    {
        class Account
        {
            public int Id { get; set; }
            public Account(int _id)
            {
                Id = _id;
            }
        }

        static void Main(string[] args)
        {
            Account accoynt = new Account(4);
            Person person = new Person();
            PersonLibrary personLibrary = new PersonLibrary { name = "Tom", age = 25 };
            PersonUser personUser = new PersonUser();
            printer.WriteLine("Hello!");
            printer.WriteLine(personLibrary.age);
            printer.ReadKey();
        }
    }

    class User
    {
        public string Name;
    }
}
