using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrudOp
{
   public class StudentCrud
    {
        List<Student> students;
        public StudentCrud() 
        {
            students = new List<Student>();
        }

        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }

        public void updateStudent(Student stud)
        {
            
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].Id == stud.Id)
                {
                    students[i].Name= stud.Name;
                    students[i].Address= stud.Address;
                    break;
                }
            }
        }

        public void deleteStudent(int id)
        {

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.Remove(students[i]);
                    break;
                }
            }
        }

        public List<Student> StudentList()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            Student s = new Student();
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    s.Id = item.Id;
                    s.Name = item.Name;
                    s.Address = item.Address;
                    break;

                }
            }
            return s;
        }


    }
}
