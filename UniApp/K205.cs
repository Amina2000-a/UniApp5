using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp
{
    class K205
    {
        public int Id { get; private set; }
        public string K205Name{get; set;}
        public List<Student> StudentList { get; set; }
        public Teacher Teacher;
        private static int K205Id = 1;
        public List<Prog> ProgList;
        public List<Teacher> TeacherList;
        public List<Value> ValueList;

        public K205(string K205Name, Teacher teacher)
        {
            this.K205Name = K205Name;
            StudentList = new List<Student>();
            K205Id++;
            Id = K205Id;
            ProgList = new List<Prog>();
            TeacherList = new List<Teacher>();
            ValueList = new List<Value>();
            Prog design = new Prog("Design", new DateTime(2020, 09, 09));
            Prog programming = new Prog("Programming", new DateTime(2020, 09, 12));
            Prog gamecreate = new Prog("GameCreate", new DateTime(2020, 09, 30));
            ProgList.Add(design);
            ProgList.Add(programming);
            ProgList.Add(gamecreate);

            Value C = new Value("70-80", new DateTime(2020, 09, 09));
            Value B = new Value("80-90", new DateTime(2020, 09, 12));
            Value A = new Value("90-100", new DateTime(2020, 09, 30));
            ValueList.Add(C);
            ValueList.Add(B);
            ValueList.Add(A);
        }
        public void AddStudent()
        {
            Console.WriteLine("\n********************");
            Console.Write("Please write student's name:");
            string name = Console.ReadLine();
            if (name.Length > 2)
            {
                Student stu = new Student(stu.Fullname,stu.Email,stu.Phone,stu.WorkExperience);
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
            Teacher teach = new Teacher(teach.Id, teach.Firstname, teach.Lastname, teach.Phone, teach.Email, teach.WorkExperience);
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
        public void ShowValueList(Student selectedStu)
        {
            Value SelectedValue = null;
            foreach (Value val in ValueList)
            {
                Console.WriteLine("Value's Name: {0}", val.ValueName, val.Date);
            }
        Start:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please,Select Prog by Id:");
            string valueName = Console.ReadLine();
            bool correctName = false;
            foreach (Value val in ValueList)
            {
                if (val.ValueName == valueName)
                {
                    correctName = true;
                    SelectedValue = val;
                    break;
                }
            }
            if (correctName)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Value's name:{0} was added to student's name{1}\n", SelectedValue.ValueName, selectedStu.Fullname);
                selectedStu.ValueList.Add(SelectedValue);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWarning:Please,select a valid id...");
                goto Start;
            }
        }
        public void AddValue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("__________***_________");
            Console.Write("Please write Value name:");

            string valname = Console.ReadLine();
            if (!string.IsNullOrEmpty(valname))
            {
                Value vl = new Value(valname, DateTime.Now);
                ValueList.Add(vl);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("__________***_________");
                Console.WriteLine("Value name was added successfully:");
                foreach (var val in ValueList)
                {
                    Console.WriteLine("Value Name:{0}, Value Date:{1}", val.ValueName, val.Date);
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("__________***_________");
                Console.Write("Please fiel Value name:");

            }

        }
        public void ShowValueForStudent()
        {
            Value SelectedValue = null;
            foreach (Value val in ValueList)
            {
                Console.WriteLine("Value's Name: {0}", val.ValueName, val.Date);
            }
        Start:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please,Select Value by Id:");
            string valueName = Console.ReadLine();
            bool correctName = false;
            foreach (Value val in ValueList)
            {
                if (val.ValueName == valueName)
                {
                    correctName = true;
                    SelectedValue = val;
                    break;
                }
            }
            if (correctName)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Student Name for Value's name:{0}\n", SelectedValue.ValueName);
                foreach (Student stu in StudentList)
                {
                    if (stu.ValueList.Count == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nWarning:Selected Student was not found any Value...");
                        break;
                    }
                    else if (stu.ValueList.Contains(SelectedValue))
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
