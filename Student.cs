using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    internal class Student
    {
        public int Ma { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }

        public Student(int ma, string ht, int tuoi)
        {
            Ma = ma;
            HoTen = ht;
            Tuoi = tuoi;
        }
    }
}
