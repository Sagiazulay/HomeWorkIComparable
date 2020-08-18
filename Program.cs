using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Icomparable
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Person[] Persons = new Person[]
            {
                new Person(1111, 13, 1.58f, "Avi"),
                new Person(2222, 16, 1.82f, "Yossi"),
                new Person(1212, 10, 1.13f, "Yali"),
                new Person(1000, 80, 1.65f, "Baba"),
                new Person(988, 102, 1.54f, "Yakov")
            };
            Console.WriteLine("Compare By ID====================================");
            Array.Sort(Persons);
            PrintPersonArray(Persons);
            Console.WriteLine();
            Console.WriteLine("Compare By Name====================================");
            Array.Sort(Persons, Person.NameComparer);
            PrintPersonArray(Persons);
            Console.WriteLine();
            Console.WriteLine("Compare By Height====================================");
            Array.Sort(Persons, Person.HeightComparer);
            PrintPersonArray(Persons);
            Console.WriteLine();
            Console.WriteLine("Compare By Age====================================");
            Array.Sort(Persons, Person.AgeComparer);
            PrintPersonArray(Persons);
        }
        static void PrintPersonArray(Person[] p)
        {
            
            foreach (Person item in p)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
