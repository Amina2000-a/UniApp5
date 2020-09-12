using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp
{
    class Value
    {
        public string ValueName { get; set; }
        public DateTime Date { get; set; }
        List<Student> StudentList;
        public Value(string ValueName, DateTime Date)
        {
            this.ValueName = ValueName;
            this.Date = Date;
            StudentList = new List<Student>();
        }
    }
}
