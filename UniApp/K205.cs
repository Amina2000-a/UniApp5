using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class K205
    {
        public List<Student> StudentList;
        public List<Prog> ProgList;
        public List<Teacher> TeacherList;

        public K205()
        {
            StudentList = new List<Student>();
            ProgList = new List<Prog>();
            TeacherList = new List<Teacher>();
            Prog design = new Prog("Design", new DateTime(2020, 09, 09));
            Prog programming = new Prog("Programming", new DateTime(2020, 09, 12));
            Prog gamecreate = new Prog("GameCreate", new DateTime(2020, 09, 30));
            ProgList.Add(design);
            ProgList.Add(programming);
            ProgList.Add(gamecreate);
        }
        public void AddStudent()
        {
            Console.WriteLine("\n********************");
            Console.Write("Please write student's name:");
            string name = Console.ReadLine();
            if (name.Length > 2)
            {
                Student stu = new Student(name);
                StudentList.Add(stu);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nStudent added successfully");
            }

        }
        public void AddTeacher()
        {
            Console.WriteLine("\n***************************");
            Console.Write("Please write teacher name:");
            string name = Console.ReadLine();
            Teacher teach = new Teacher(name);
            TeacherList.Add(teach);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTeacher added successfully");
        }
        public void ShowStudent()
        {
            if (StudentList.Count>0)
            {
                Student selectedStudent = null;
                foreach (Student stu in StudentList)
                {
                    Console.WriteLine("Id: {0},Name: {1}", stu.Id, stu.Fullname);
                }
            Start:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Please,Select student by Id:");
                string stuId = Console.ReadLine();
                int id;
                if (int.TryParse(stuId, out id))
                {
                    bool correctId = false;
                    foreach (Student stu in StudentList)
                    {
                        if (stu.Id == id)
                        {
                            correctId = true;
                            selectedStudent = stu;
                            break;
                        }
                    }
                    if (correctId)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Your selected student's name:{0}", selectedStudent.Fullname);
                        ShowProgList(selectedStudent);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nWarning:Please,select a valid id...");
                        goto Start;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWarning:Please,don't input a word");
                    goto Start;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWarning:Student not found");
            }
            
        }
        public void ShowProgList(Student selectedStu)
        {
            Prog SelectedProg = null;
            foreach (Prog pro in ProgList)
            {
                Console.WriteLine("Prog's Name: {0}", pro.ProgName, pro.Date);
            }
        Start:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please,Select Prog by Id:");
            string progName = Console.ReadLine();
            bool correctName = false;
                foreach (Prog pro in ProgList)
                {
                    if (pro.ProgName == progName)
                    {
                    correctName = true;
                    SelectedProg = pro;
                    break;
                    }
                }
                if (correctName)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Prog's name:{0} was added to student's name{1}\n", SelectedProg.ProgName,selectedStu.Fullname);
                selectedStu.ProgList.Add(SelectedProg);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWarning:Please,select a valid id...");
                    goto Start;
                }
            }
        public void AddProg()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("__________***_________");
            Console.Write("Please write Prog name:");

            string proname = Console.ReadLine();
            if (!string.IsNullOrEmpty(proname))
            {
                Prog prg = new Prog(proname, DateTime.Now);
                ProgList.Add(prg);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("__________***_________");
                Console.WriteLine("Prog name was added successfully:");
                foreach(var pro in ProgList)
                {
                    Console.WriteLine("Prog Name:{0}, Prog Date:{1}", pro.ProgName, pro.Date);
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("__________***_________");
                Console.Write("Please fiel Prog name:");
                
            }

        }
        public void ShowProgForStudent()
        {
            Prog SelectedProg = null;
            foreach (Prog pro in ProgList)
            {
                Console.WriteLine("Prog's Name: {0}", pro.ProgName, pro.Date);
            }
        Start:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please,Select Prog by Id:");
            string progName = Console.ReadLine();
            bool correctName = false;
            foreach (Prog pro in ProgList)
            {
                if (pro.ProgName == progName)
                {
                    correctName = true;
                    SelectedProg = pro;
                    break;
                }
            }
            if (correctName)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Student Name for Prog's name:{0}\n", SelectedProg.ProgName);
                foreach (Student stu in StudentList)
                {
                    if (stu.ProgList.Count == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nWarning:Selected Student was not found any Prog...");
                        break;
                    }
                    else if(stu.ProgList.Contains(SelectedProg))
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Student Id:{0}, Student Name:{1}", stu.Id, stu.Fullname);
                    }
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWarning:Please,select a valid id...");
                goto Start;
            }
        }
    }
    }
