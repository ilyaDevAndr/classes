using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        class Student
        {

            public string Name;
            public string MidleName;
            public string LastName;
            public double estimation1;
            public double estimation2;
            public double SrEstimation;

        }

        class Programm
        {
            static Student GetStudent()
            {
                Student student = new Student();
                student.Name = " Иван";
                student.MidleName = " Иваночич";
                student.LastName = "Иванов";
                student.estimation1 = 3;
                student.estimation2 = 5;
                student.SrEstimation = (student.estimation1 + student.estimation2) / 2;

                return student;

            }
            static void Print(Student student)
            {
                Console.WriteLine("Информация о студенте");
                Console.WriteLine($"Фамилия:{student.LastName}");
                Console.WriteLine($"Имя:{student.Name}");
                Console.WriteLine($"Отчество:{student.MidleName}");
                Console.WriteLine($"Оценка 1: {student.estimation1}");
                Console.WriteLine($"Оценка 1: {student.estimation2}");
                Console.WriteLine($"Средняя оценка: {student.SrEstimation}");
            }
            static void Main(string[] args)
            {
                var firstStudent = GetStudent();
                Print(firstStudent);
            }
        }
    }
}

