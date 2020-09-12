using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp
{
    class Student
    {
        public string Fullname { get; set; }
        public int Id { get; private set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int WorkExperience { get; set; }
        public List<int> Valuation { get; set; }
        public List<Prog> ProgList { get; set; }
        public List<Value> ValueList { get; set; }
        public K205 K205;
        private static int stuId = 0;

        public Student(string Fullname,string Email,string Phone,int WorkExperience,List<int>Valuation)
        {
            this.Fullname = Fullname;
            this.Id = stuId;
            this.Email = Email;
            this.Phone = Phone;
            this.WorkExperience = WorkExperience;
            this.Valuation = Valuation;
            stuId++;
            Id = stuId;
            ProgList = new List<Prog>();
        }
    }
}
