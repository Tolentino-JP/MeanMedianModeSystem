using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class Mode
    {
        Main main = new Main();

        public double Prelim()
        {
            var prelimGrade = from prelim in main.studentNameGrade
                              select prelim;





            return 0;
        }

    }
}
