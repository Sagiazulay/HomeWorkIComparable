using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Icomparable
{
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
