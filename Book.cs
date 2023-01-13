using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    internal class Book
    {
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        List<double> grades;
    }
}
