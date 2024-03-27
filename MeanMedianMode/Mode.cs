using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class Mode
    {
        Main main = new Main();

        public String Prelim()
        {
            var prelimGrade = (from prelim in main.studentNameGrade
                              select prelim.prelim).ToList();

            return Process(prelimGrade);
        }
        // end Prelim

        public String Midterm()
        {
            var midtermGrade = (from midterm in main.studentNameGrade
                               select midterm.midterm).ToList();

            return Process(midtermGrade);
        }
        // end Midterm

        public String Finals()
        {
            var finalsGrade = (from finals in main.studentNameGrade
                                select finals.finals).ToList();

            return Process(finalsGrade);
        }


        public String Process(List<double> grade)
        {
            List<int> modeNum = new List<int>();

            for (int i = 0; i < grade.Count(); i++)
            {
                int count = 0;
                for (int j = 0; j < grade.Count(); j++)
                {
                    if (grade[i] == grade[j])
                    {
                        count++;
                    }
                }// end inner loop
                modeNum.Add(count);
            }// end outer loop

            int max = 0;
            int index = 0;

            for (int i = 0; i < modeNum.Count(); i++)
            {
                if (i > max)
                {
                    max = modeNum[i];
                    index = i;
                }
            }
            string listAsString;
            if (max == 1)
            {
                listAsString = string.Join(", ", grade);

            }
            else
            {
                listAsString = grade.ElementAt(index).ToString();
            }

            return listAsString;
        }

    }
}
