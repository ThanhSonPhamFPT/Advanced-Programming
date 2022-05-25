using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class StudentManager
    {
        List<Student> students;
        public StudentManager()
        {
            students = new List<Student>();
        }

        public void Run()
        {
            do
            {
                string command = Console.ReadLine();
                var cmdArgs = command.Split();
                switch (cmdArgs[0])
                {
                    case "Create":
                        Create(cmdArgs);
                        break;
                    case "Show":
                        Show(cmdArgs);
                        break;
                   
                }
                if (cmdArgs[0] == "Exit")
                {
                    break;
                }
            } while (true);
        }

        private void Show(string[] cmdArgs)
        {
            foreach(Student student in students)
            {
                if (student.Name.Equals(cmdArgs[1]))
                {
                    student.Show();
                    return;
                }
            }
            Console.WriteLine("Student does not exist");
        }

        private void Create(string[] cmdArgs)
        {
            Student newStudent = new Student(cmdArgs[1],int.Parse(cmdArgs[2]),double.Parse(cmdArgs[3]));
            students.Add(newStudent);
        }
    }
}
