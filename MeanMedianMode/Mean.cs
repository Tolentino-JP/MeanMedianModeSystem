using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class Mean
    {
        Main main = new Main();
        public void ComputeMean()
        {
            var prelimGrade = from students in main.studentNameGrade
                              select students.prelim;

            var midtermGrade = from students in main.studentNameGrade
                              select students.midterm;

            var finalsGrade = from students in main.studentNameGrade
                              select students.finals;





        }




    }// end mean class
}
