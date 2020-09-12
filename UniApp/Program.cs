using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp
{
    class Program
    {
        static void Main(string[] args)
        {
            K205 k205 = new K205("K205",teacher);
            string userInput;
            int input;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please select on the bellow\n");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Student and Add Prog");
                Console.WriteLine("3. Add and List Prog");
                Console.WriteLine("4. Show Progs for students");
                Console.WriteLine("5. Add and List Value");
                Console.WriteLine("6. Show Values for students");
                Console.WriteLine("7. Add Teacher");
                Console.WriteLine("8. Show Teacher List");
                Console.WriteLine("9. Exit");
                Console.Write(">>>>>>>>>>~<<<<<<<<<<");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out input))
                {
                    switch (input)
                    {
                        case 1:
                            k205.AddStudent();
                            break;
                        case 2:
                            k205.ShowStudent();
                            break;
                        case 3:
                            k205.AddProg();
                            break;
                        case 4:
                            k205.ShowProgForStudent();
                            break;
                        case 5:
                            k205.AddValue();
                            break;
                        case 6:
                            k205.ShowValueForStudent();
                            break;
                        case 7:
                            k205.AddTeacher();
                            break;
                        case 8:
                            foreach (var teach in k205.TeacherList)
                            {
                                Console.WriteLine("Id:{0},Name:{1}", teach.Id, teach.Firstname, teach.Lastname,teach.Phone,teach.Email,teach.WorkExperience);
                            }
                            break;
                        default:
                            Console.WriteLine("Warning: Please write top number\n");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warning: Please write numeric number\n");
                }
            } while (userInput != "9");


        }
    }
}