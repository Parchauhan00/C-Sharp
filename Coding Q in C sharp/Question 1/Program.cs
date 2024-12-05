using System;
using System.Collections.Generic;

class Program
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<(string SubjectName, string Grade)> Subjects { get; set; } = new List<(string, string)>();
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter number of students to add: ");
        int studentCount = int.Parse(Console.ReadLine());

        for (int s = 0; s < studentCount; s++)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter number of subjects: ");
            int subjectCount = int.Parse(Console.ReadLine());

            var student = new Student {
                Name = name, Gender = gender };
            for (int i = 0; i < subjectCount; i++)
            {
                Console.Write("Enter Subject Name: ");
                string subjectName = Console.ReadLine();

                Console.Write("Enter Grade: ");
                string grade = Console.ReadLine();

                student.Subjects.Add((subjectName, grade));
            }

            students.Add(student);
        }

        // Display all students
        foreach (var student in students)
        {
            Console.WriteLine($"\nName: {student.Name}, Gender: {student.Gender}");
            foreach (var (subjectName, grade) in student.Subjects)
                Console.WriteLine($"  {subjectName}: {grade}");
        }
    }
}
