using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrudOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCrud crud = new StudentCrud();
            try
            {
                int choice = 1;
                do
                {
                    Console.WriteLine("1.Student list");
                    Console.WriteLine("2.add student");
                    Console.WriteLine("3.update Student");
                    Console.WriteLine("4.Delete student");
                    Console.WriteLine("5.GetStudentById");
                    Console.WriteLine("select any one option at a time");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            List<Student> student = crud.StudentList();
                            Console.WriteLine("ID    NAME     ADDRESS");
                            foreach(var items in  student)
                            {
                                Console.WriteLine(items);
                            }
                            break;

                        case 2:
                             Student s=new Student();
                            Console.WriteLine("enter id:");
                            s.Id=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            s.Name=Console.ReadLine();
                            Console.WriteLine("Enter address:");
                            s.Address=Console.ReadLine();
                            crud.AddStudent(s);
                            Console.WriteLine("Student Added");
                            break;

                        case 3:
                            Student s1 = new Student();
                            Console.WriteLine("enter id:");
                            s1.Id=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            s1.Name=Console.ReadLine();
                            Console.WriteLine("Enter Address:");
                            s1.Address=Console.ReadLine();
                            crud.updateStudent(s1);
                            Console.WriteLine(" Student Update successfully");
                            break;

                        case 4:
                            Console.WriteLine("Enter id:");
                            int id=Convert.ToInt32(Console.ReadLine());
                            crud.deleteStudent(id);
                            Console.WriteLine("Student Deleted");

                            break;

                        case 5:
                            Console.WriteLine("Enter Id:");
                            int id1=Convert.ToInt32(Console.ReadLine());
                            Student st= crud.GetStudentById(id1);
                            Console.WriteLine(st);

                            break;

                    }
                    Console.WriteLine("Press 1 for continue and 0 for exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice == 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
