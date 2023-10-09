using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring  variables
            string name = "Matimba";
            int age;

            // initialization

            name = "Matimba";
            age = 10;

            // What will be seen on the console
            Console.WriteLine("There was once a boy called " + name);
            Console.WriteLine(name+ "was" + age  + "of age.");
            Console.WriteLine(name + "Really never liked his name");

            // change variables values
            age = 18;
            name = "Mabasa";

            Console.WriteLine("At age" + age + "changed his name to" + name);

            // To free the console

            Console.ReadLine();

        }
    }
}
