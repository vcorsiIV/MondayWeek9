using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Two Truths & A Lie
//The lie is the second statement because, for set accessors your setting
//the stored values and get accessors for retrieving an object's field.

namespace MonChap9YouDoIt
{
    class CreateStudent
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            Student second = new Student();
            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;

            Display(first);
            Display(second);
        }
        static void Display(Student stu)
        {
            WriteLine("{0, 5} {1, -10}{2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }
    }
}
