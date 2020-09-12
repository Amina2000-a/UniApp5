using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp
{
    class Teacher
    {
        public int Id { get; private set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int WorkExperience { get; set; }
        public List<K205> K205List { get; set; }
        private static int teachId = 1;

        public Teacher(string Firstname, string Lastname, string Email, string Phone, int WorkExperience)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Phone = Phone;
            this.WorkExperience = WorkExperience;
            Id = teachId;
            teachId++;
            K205List = new List<K205>();
        }
    }
}