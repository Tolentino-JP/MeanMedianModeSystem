using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class Median
    {
        Main main = new Main();
        int count = 0;
        public double Prelim()
        {

            var prelimGrade = (from prelim in main.studentNameGrade
                              select prelim).ToArray();

            count = prelimGrade.Count();
            double arrprelim = new double[]

            if(count % 2 == 0)
            {
                count = prelimGrade;
            }



            return 0;
        }







    }
}
