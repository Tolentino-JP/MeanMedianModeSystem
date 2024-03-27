using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class RangeGrade
    {
        Main main = new Main();
        public double Prelim()
        {

            var prelimGrade = (from grades in main.studentNameGrade
                              select grades.prelim).ToList();

            List<double> range = new List<double>();
            
            foreach(var grade in prelimGrade)
            {
                range.Add(Convert.ToDouble(grade));
            }

            range.Sort();

            double rangeGrade = range.ElementAt(range.Count() - 1) - range.ElementAt(0);


            return rangeGrade;
        }
        // end Prelim

        public double Midterm()
        {

            var midtermGrade = (from grades in main.studentNameGrade
                               select grades.midterm).ToList();

            List<double> range = new List<double>();

            foreach (var grade in midtermGrade)
            {
                range.Add(Convert.ToDouble(grade));
            }

            range.Sort();

            double rangeGrade = range.ElementAt(range.Count() - 1) - range.ElementAt(0);


            return rangeGrade;
        }
        // end Midterm

        public double Finals()
        {

            var finalsGrade = (from grades in main.studentNameGrade
                                select grades.finals).ToList();

            List<double> range = new List<double>();

            foreach (double grade in finalsGrade)
            {
                range.Add(grade);
            }

            range.Sort();

            double rangeGrade = range.ElementAt(range.Count()-1) - range.ElementAt(0);


            return rangeGrade;
        }
        // end Finals

    }
}
