using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAgeLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var myDict = new Dictionary<string, int>();
            Person[] myPeople = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine().Split(", ").ToArray();
                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);
                myPeople[i] = new Person()
                {
                    Name = name,
                    Age = age
                };
            }

            string condition = Console.ReadLine();
            int agePerson = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> conditionPerson = Condition(condition, agePerson);
            Action<Person> formatPerson = Format(format);

            foreach (var person in myPeople)
            {
                if (conditionPerson(person))
                {
                    formatPerson(person);
                }
            }
        }

        public static Action<Person> Format(string format)
        {
            switch (format)
            {
                case "name":
                    return n =>
                    { 
                        Console.WriteLine($"{n.Name}"); 
                    };
                case "age":
                    return n =>
                    {
                        Console.WriteLine($"{n.Age}");
                    };
                case "name age":
                    return n =>
                    {
                        Console.WriteLine($"{n.Name} - {n.Age}");
                    };
            }

            return null;
        }

        public static Func<Person,bool> Condition(string condition, int age)
        {
            switch (condition)
            {
                case "younger":
                    return person => person.Age <= age;
                case "older":
                    return person => person.Age >= age;
            }
            return null;
        }
    }
}
