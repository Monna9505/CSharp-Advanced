using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGradesLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentRecords = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < students; i++)
            {
                string[] studentGrade = Console.ReadLine().Split().ToArray();
                string studentName = studentGrade[0];
                decimal grade = decimal.Parse(studentGrade[1]);

                if (!studentRecords.ContainsKey(studentName))
                {
                    studentRecords.Add(studentName, new List<decimal>());
                    studentRecords[studentName].Add(grade);
                }
                else
                {
                    studentRecords[studentName].Add(grade);
                }
            }

            foreach (var student in studentRecords)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: { student.Value.Average():f2})");
            }
        }
    }
}
