using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/// <summary>
/// Two Truths & A Lie
/// The lie is the second statement, because if you do write a constructor for a class,
/// it becomes the default constructor.  The term default constructor is not just used
/// for a class's automatically supplied constructor; it is used for any constructor that takes
/// no parameters. If a constructor is not written for a class, each class that is created is
/// automatically supplied with a public construtor with no parameters.
/// </summary>

namespace CreateStudent2
{
    class CreateStudent
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            Student second = new Student();
            Student third = new Student(456, "Marco", 2.4);
            Student fourth = new Student();
            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;

            Display(first);
            Display(second);
            Display(third);
            Display(fourth);
        }
        static void Display(Student stu)
        {
            WriteLine("{0, 5} {1, -10}{2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }
    }
}
