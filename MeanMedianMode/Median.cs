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
            var prelimGrade = (from prelim in main.studentNameGrade
                              select prelim);

            count = prelimGrade.Count();
            

            if(count % 2 == 0)
            {
                double mid = Convert.ToDouble(prelimGrade.ElementAt(count / 2).ToString() );
                double midPlus = Convert.ToDouble(prelimGrade.ElementAt( (count/2) +1).ToString() );
                total = (mid + midPlus) / 2;
            }



            return total;
        }







    }
}
