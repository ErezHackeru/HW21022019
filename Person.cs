using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21022019_2
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

        /// <summary>
        /// compare by Id
        /// </summary>
        public int CompareTo(Person other)
        {
            if (defaultComparerName is PersonCompareById)
                return this.Id - other.Id;
            else if (defaultComparerName is PersonCompareByName)
                return String.Compare(this.Name, other.Name);
            else if (defaultComparerName is PersonCompareByHeight)
                return Convert.ToInt32(this.Height - other.Height);
            else if (defaultComparerName is PersonCompareByAge)
                return this.Age - other.Age;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Id is: {Id}, Age is: {Age}, Height is: {Height}, Name is: {Name}";
        }

        //Static Part:        
        static IComparer<Person> defaultComparerName = new PersonCompareByName();
        
        private static readonly IComparer<Person> _idComparer;
        private static readonly IComparer<Person> _ageComparer;
        private static readonly IComparer<Person> _heightComparer;
        private static readonly IComparer<Person> _nameComparer;

        public static IComparer<Person> idComparer
        {
            get
            {
                return _idComparer;
            }
        }
        public static IComparer<Person> ageComparer
        {
            get
            {
                return _ageComparer;
            }
        }
        public static IComparer<Person> heightComparer
        {
            get
            {
                return _heightComparer;
            }
        }
        public static IComparer<Person> nameComparer
        {
            get
            {
                return _nameComparer;
            }
        }

        static Person()
        {
            _idComparer = new PersonCompareById();
            _ageComparer = new PersonCompareByAge();
            _heightComparer = new PersonCompareByHeight();
            _nameComparer = new PersonCompareByName();
        }

        private static IComparer<Person> DefaultComparer()
        {
            return defaultComparerName;
        }

        public static void ModifyDefaultComparer(string Comparer)
        {
            switch (Comparer)
            {
                case ("Name"):
                    defaultComparerName = new PersonCompareByName();
                    break;
                case ("Height"):
                    defaultComparerName = new PersonCompareByHeight();
                    break;
                case ("Age"):
                    defaultComparerName = new PersonCompareByAge();
                    break;
                case ("Id"):
                    defaultComparerName = new PersonCompareById();
                    break;
            }
        }
        
    }
}
