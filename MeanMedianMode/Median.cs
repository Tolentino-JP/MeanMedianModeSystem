using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MeanMedianModeBusLogic
{
    public class Median
    {
        Main main = new Main();
        int count = 0;
        double total = 0;
        public double Prelim()
        {
            var prelimGrade = from prelim in main.studentNameGrade
                              orderby prelim.prelim
                              select prelim;


            count = prelimGrade.Count();

            
            if(count % 2 == 0)
            {
                double mid = Convert.ToDouble(prelimGrade.ElementAt( (count / 2) - 1).prelim.ToString() );
                double midPlus = Convert.ToDouble(prelimGrade.ElementAt( (count/2) ).prelim.ToString() );

                total = (mid + midPlus) / 2;
            }
            else
            {
                double mid = Convert.ToDouble(prelimGrade.ElementAt((count / 2) - 1).prelim.ToString());

                total = mid / 2;
            }



            return total;
        }
        // end Prelim

        public double Midterm()
        {
            var midtermGrade = from midterm in main.studentNameGrade
                              orderby midterm.midterm
                              select midterm;


            count = midtermGrade.Count();


            if (count % 2 == 0)
            {
                double mid = Convert.ToDouble(midtermGrade.ElementAt((count / 2) - 1).midterm.ToString());
                double midPlus = Convert.ToDouble(midtermGrade.ElementAt((count / 2)).midterm.ToString());

                total = (mid + midPlus) / 2;
            }
            else
            {
                double mid = Convert.ToDouble(midtermGrade.ElementAt((count / 2) - 1).midterm.ToString());

                total = mid / 2;
            }



            return total;
        }
        // end Midterm

        public double Finals()
        {
            var finalsGrade = from finals in main.studentNameGrade
                              orderby finals.finals
                              select finals;


            count = finalsGrade.Count();


            if (count % 2 == 0)
            {
                double mid = Convert.ToDouble(finalsGrade.ElementAt((count / 2) - 1).finals.ToString());
                double midPlus = Convert.ToDouble(finalsGrade.ElementAt((count / 2)).finals.ToString());

                total = (mid + midPlus) / 2;
            }
            else
            {
                double mid = Convert.ToDouble(finalsGrade.ElementAt((count / 2) - 1).finals.ToString());

                total = mid / 2;
            }



            return total;
        }







    }
}
