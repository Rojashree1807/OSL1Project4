using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class Subject
    {
        //string subName, subCode, teacher; 
        public string SubName { get; set; }
        public int SubCode { get; set; }
        public string Teacher { get; set; }
        public Subject(string name, int code, string teacher)
        {
            SubName = name;
            SubCode = code;
            Teacher = teacher;
        }
    }
}
