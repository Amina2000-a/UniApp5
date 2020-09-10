using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Prog
    {
        public string ProgName { get; set; }
        public DateTime Date { get; set; }
        List<Student> StudentList;
        public Prog(string ProgName,DateTime Date)
        {
            this.ProgName = ProgName;
            this.Date = Date;
            StudentList = new List<Student>();
        }
    }
}
