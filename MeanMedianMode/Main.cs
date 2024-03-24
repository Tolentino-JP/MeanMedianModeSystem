using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeBusLogic
{
    public class Main
    {

        public List<Student> studentNameGrade = new List<Student>
        {
            new Student() {studentName = "Student A", prelim = 78.88, midterm = 85.00, finals = 100.00},
            new Student() {studentName = "Student B", prelim = 56.76, midterm = 98.00, finals = 100.00},
            new Student() {studentName = "Student C", prelim = 98.00, midterm = 87.92, finals = 99.00},
            new Student() {studentName = "Student D", prelim = 87.98, midterm = 85.00, finals = 98.00},
            new Student() {studentName = "Student E", prelim = 89.00, midterm = 90.15, finals = 97.00},
            new Student() {studentName = "Student F", prelim = 90.00, midterm = 90.11, finals = 89.90}
        };


    }// end main class

    public class Student
    {
        public string studentName { get; set; }
        public double prelim { get; set; }
        public double midterm { get; set; }
        public double finals { get; set; }
    }


}
