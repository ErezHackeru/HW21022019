using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21022019_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
            {
                new Person(4,20, 180, "Haakov"),
                new Person(2,18, 182, "Reuven"),
                new Person(3,32, 175, "Behuda"),
                new Person(1,25, 177, "Yosef"),
                new Person(5,28, 159, "Zevulun")
            };
            PrintPersonArray(persons);
            Array.Sort(persons);
            Console.WriteLine("Sort by Id 1===========");
            PrintPersonArray(persons);
            Array.Sort(persons, new PersonCompareByName());
            Console.WriteLine("Sort by Name===========");
            PrintPersonArray(persons);
            Array.Sort(persons, new PersonCompareByHeight());
            Console.WriteLine("Sort by Height===========");
            PrintPersonArray(persons);
            Array.Sort(persons, new PersonCompareByAge());
            Console.WriteLine("Sort by Age===========");
            PrintPersonArray(persons);
            Array.Sort(persons, new PersonCompareById());
            Console.WriteLine("Sort by Id 2===========");
            PrintPersonArray(persons);

            Array.Sort(persons, Person.nameComparer);
            Console.WriteLine("Sort by Name===========");
            PrintPersonArray(persons);
            Array.Sort(persons, Person.idComparer);
            Console.WriteLine("Sort by Id===========");
            PrintPersonArray(persons);
            Array.Sort(persons, Person.ageComparer);
            Console.WriteLine("Sort by Age===========");
            PrintPersonArray(persons);
            Array.Sort(persons, Person.heightComparer);
            Console.WriteLine("Sort by Height===========");
            PrintPersonArray(persons);

            Array.Sort(persons);
            Console.WriteLine("Sort by Id===========");
            PrintPersonArray(persons);
            Person.ModifyDefaultComparer("Name");
            Array.Sort(persons);
            Console.WriteLine("Sort by Name===========");
            PrintPersonArray(persons);

            Console.ReadKey();
        }
        static void PrintPersonArray(Person[] perssonArr)
        {
            foreach (Person personItem in perssonArr)
            {
                Console.WriteLine(personItem);
            }
        }
    }
}
