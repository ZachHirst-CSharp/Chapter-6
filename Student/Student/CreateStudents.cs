using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Student
{
    class CreateStudents
    {
        static void Main(string[] args)
        {
            CreateStudents first = new CreateStudents();
            CreateStudents second = new CreateStudents();

            first.idNumber = 123;
            first.lastName = "Burton";
            first.gradePointAverage = 3.5;

            Write(" Enter students last name >>>> ");
            second.lastname = ReadLine();
            Write("Enter students ID Number >>> ");
            second.idNumber = ReadLine();
            Write("Enter students GPA >>>>>>");
            second.gradePointAverage = ReadLine();

            Display(first);
            Display(second);
        }

        static void Display(CreateStudents stu)
        {
            WriteLine("{0}, {1} {2}", stu.IdNumber, stu.LastName, stu.gradePointAverage);
        }
    }
}
