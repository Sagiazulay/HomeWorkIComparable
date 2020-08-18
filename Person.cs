using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Person_Icomparable
{
    class Person : IComparable<Person>
    {
        public int ID { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        private static readonly IComparer<Person> idComparer;

        private static readonly IComparer<Person> ageComparer;

        private static readonly IComparer<Person> heightComparer;

        private static readonly IComparer<Person> nameComparer;

        public static IComparer<Person> IDComparer { get { return idComparer; } }
        public static IComparer<Person> AgeComparer { get{ return ageComparer; } }
        public static IComparer<Person> HeightComparer { get{ return heightComparer; } }
        public static IComparer<Person> NameComparer { get { return nameComparer; } }

        private static IComparer<Person> DefaultComparer;

        public Person(int iD, int age, float height, string name)
        {
            ID = iD;
            Age = age;
            Height = height;
            Name = name;
        }
        static Person()
        {
            idComparer = new PersonCompareById();
            ageComparer = new PersonCompareByAge();
            heightComparer = new PersonCompareByHeight();
            nameComparer = new PersonCompareByName();
        }
        public static void ModifyDefaultComparer(string str)
        {

        }
        public int CompareTo(Person other)
        {
            return this.ID - other.ID;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Person Name : {Name}, Age : {Age}, ID : {ID}, Height : {Height}";
        }
    }
}
