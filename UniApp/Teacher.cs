using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Teacher
    {
        public string Fullname { get; set; }
        public int Id { get; private set; }
        public List<Teacher> TeacherList { get; set; }
        private static int teachId = 1;

        public Teacher(string Fullname)
        {
            this.Fullname = Fullname;
            this.Id = teachId;
            teachId++;
        }
    }
}