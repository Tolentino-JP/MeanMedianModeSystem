using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class Variance
    {
        Main main = new Main();
        Mean mean = new Mean();

        public double Prelim()
        {

            var summation = from grades in main.studentNameGrade
                            select grades.prelim;

            List<double> students = new List<double>();

            foreach (double sum in summation)
            {
                students.Add(sum);
            }
            double meanPrelim = mean.Prelim();
            double result = 0;
            for (int i = 0; i <students.Count(); i++)
            {
                students[i] = students[i] - meanPrelim;
                students[i] *= students[i]; // squared
                result += students[i];
            }

            result /= summation.Count();

            return result;
        }
        // end Prelim

        public double Midterm()
        {

            var summation = from grades in main.studentNameGrade
                            select grades.midterm;

            List<double> students = new List<double>();

            foreach (double sum in summation)
            {
                students.Add(sum);
            }
            double meanMidterm = mean.Midterm();
            double result = 0;
            for (int i = 0; i <students.Count(); i++)
            {
                students[i] = students[i] - meanMidterm;
                students[i] *= students[i]; // squared
                result += students[i];
            }
            result /= summation.Count();


            return result;
        }
        // end Midterm

        public double Finals()
        {

            var summation = from grades in main.studentNameGrade
                            select grades.finals;

            List<double> students = new List<double>();

            foreach (double sum in summation)
            {
                students.Add(sum);
            }
            double meanFinals = mean.Finals();
            double result = 0;
            for (int i = 0; i <students.Count(); i++)
            {
                students[i] = students[i] - meanFinals;
                students[i] *= students[i]; // squared
                result += students[i];
            }
            result /= summation.Count();

            return result;
        }
        // end Finals

    }
}
