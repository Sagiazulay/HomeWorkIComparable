using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Icomparable
{
    class PersonCompareById : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.ID - y.ID;
        }
    }
}
