using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Student
    {
        public Student(int studentId, string studentName, int age)
        {
            StudentId = studentId;
            StudentName = studentName;
            Age = age;
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
   
    interface IStudentRepository
    {
        bool AddStudent(Student student);
        Student GetStudent(int id);
        Student[] GetStudents();
    }
    class StudentRepository:IStudentRepository
    {
        public Student[] students = new Student[5];
        public int count = 0;
        public bool AddStudent(Student student)
        {
            try
            {
                if (count < students.Length)
                {
                    students[count] = student;
                    count++;
                    return true;
                }
                else
                {
                    throw new CountExceedException("Class is Full");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Student GetStudent(int id)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.StudentId.Equals(id))
                    {
                        return item;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Student[] GetStudents()
        {
            return students;
        }
    }
    class Test_Student
    {
        static void Main()
        {
            try
            {
                StudentRepository repository = new StudentRepository();
                repository.AddStudent(new Student(1, "Rohan", 10));
                repository.AddStudent(new Student(2, "Monica", 12));
                repository.AddStudent(new Student(3, "Anusha", 11));
                repository.AddStudent(new Student(4, "Robert", 10));
                Student student = repository.GetStudent(1);
                if (student != null)
                {
                    Console.WriteLine($"ID: {student.StudentId} Name{student.StudentName} Age{student.Age}");
                }
                else
                    Console.WriteLine("Invalid Id");
                foreach (var item in repository.GetStudents())
                {
                    if (item != null)
                        Console.WriteLine($"ID: {item.StudentId} Name{item.StudentName} Age{item.Age}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

}
