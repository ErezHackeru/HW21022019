using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21022019_2
{
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }
}
