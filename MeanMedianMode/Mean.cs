using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class Mean
    {
        Main main = new Main();
        public double result = 0;
        public int count = 0;

        public double Prelim()
        {
            var prelimGrade = from students in main.studentNameGrade
                              select students.prelim;

            foreach (var prelim in prelimGrade)
            {

                result += prelim;
                count++;

            }
            double prelimMean = result / count;

            count = 0;
            result = 0;


            return prelimMean;
        }
        // end prelim

        public double Midterm()
        {
            var midtermGrade = from students in main.studentNameGrade
                               select students.midterm;

            foreach (var midterm in midtermGrade)
            {

                result += midterm;
                count++;

            }
            double midtermMean = result / count;

            count = 0;
            result = 0;

            return midtermMean;
        }
        // end Midterm

        public double Finals()
        {
            var finalsGrade = from students in main.studentNameGrade
                              select students.finals;

            foreach (var finals in finalsGrade)
            {

                result += finals;
                count++;

            }
            double finalsMean = result / count;

            count = 0;
            result = 0;

            return finalsMean;
        }
        // end Finals






    }// end mean class
}
