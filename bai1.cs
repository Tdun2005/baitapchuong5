using System;
using System.Collections.Generic;

namespace StudentManagement
{
    // Class Student
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public double Grade { get; set; }

        public Student(string name, string className, double grade)
        {
            Name = name;
            Class = className;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Class: {Class}, Grade: {Grade}";
        }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            int choice;

            do
            {
                Console.WriteLine("1. Thêm sinh viên mới");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(students);
                        break;
                    case 2:
                        DisplayStudents(students);
                        break;
                    case 3:
                        CalculateTotalGrade(students);
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }

            } while (choice != 4);
        }

        static void AddStudent(List<Student> students)
        {
            Console.Write("Nhập tên sinh viên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập lớp: ");
            string className = Console.ReadLine();
            Console.Write("Nhập điểm: ");
            double grade = double.Parse(Console.ReadLine());

            students.Add(new Student(name, className, grade));
            Console.WriteLine("Sinh viên đã được thêm thành công.");
        }

        static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void CalculateTotalGrade(List<Student> students)
        {
            double totalGrade = 0;
            foreach (var student in students)
            {
                totalGrade += student.Grade;
            }
            Console.WriteLine($"Tổng điểm của tất cả sinh viên: {totalGrade}");
        }
    }
}
