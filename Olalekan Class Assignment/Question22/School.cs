using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question22
{
    class School
    {
        public const string name = "Government Secondary School";
        public int Year { get; set; }

       public void PrintSchoolDetailts()
        {
         

            Year = 1987;
        }

        public void SchoolDetails(int year)
        {
            Year = year;
        }
    }
}
