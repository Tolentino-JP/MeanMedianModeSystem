using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class FinalAverage
    {
        Main main = new Main();

        public void Average()
        {

            var grades = (from grade in main.studentNameGrade
                          select new
                          {
                              studentName = grade.studentName,
                              prelim = Math.Floor(grade.prelim),
                              midterm = Math.Floor(grade.midterm),
                              finals = Math.Floor(grade.finals)
                              
                          }
                         ).ToList();
            List<double> finalAverage = new List<double>();
            int index = 0;
            foreach(var grade in grades)
            {
                finalAverage.Add( (grade.prelim * 0.3) + (grade.midterm * 0.3) + (grade.finals * 0.4) );
                Console.WriteLine($"{grade.studentName}: {Math.Ceiling(finalAverage[index])}");
                index++;

            }

            
            


        }


    }
}
