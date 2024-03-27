using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class StandardDeviation
    {

        Main main = new Main();
        Variance variance = new Variance();

        public double Prelim()
        {
            return SquareRoot(variance.Prelim());
        }
        public double Midterm() 
        {
            return SquareRoot(variance.Midterm());
        }
        public double Finals()
        {
            return SquareRoot(variance.Finals());
        }
        public double SquareRoot(double question) 
        {
            return Math.Sqrt(question);
        }


    }
}
