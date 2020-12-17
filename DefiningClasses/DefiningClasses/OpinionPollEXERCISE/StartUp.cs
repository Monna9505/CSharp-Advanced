using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] human = Console.ReadLine().Split().ToArray();
                Person person = new Person(human[0], int.Parse(human[1]));

                people.Add(person);
            }

            var olderThan30 = people.Where(n => n.Age > 30).OrderBy(n => n.Name).ToList();

            foreach (var person in olderThan30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
