using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            Family familyMembers = new Family();

            for (int i = 0; i < numPeople; i++)
            {
                string[] person = Console.ReadLine().Split().ToArray();
                Person human = new Person(person[0], int.Parse(person[1]));

                familyMembers.AddMember(human);
            }

            Person oldest = familyMembers.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
