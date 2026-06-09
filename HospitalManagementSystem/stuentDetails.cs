using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class student
    {
        public void DisplayStudent(int sid, string sname, int sage)
        {
            Console.WriteLine($"  stdid : {sid}  stdname : {sname}  stdage : {sage}");
        }
        public void AcceptStdMarks(out double sub1, out double sub2, out double sub3)
        {
            sub1 = 87;
            sub2 = 67;
            sub3 = 77;
            Console.WriteLine($" sub1  : {sub1}  sub2 : {sub2}  sub3 : {sub3}");
        }
        public void DisplaytotalMarks(ref int practicalMarks)
        {
            int sub1 = 87;
            int sub2 = 67;
            int sub3 = 77;

            int totalmarks = practicalMarks + sub1 + sub2 + sub3;
            int average = (sub1 + sub2 + sub3) / 3;

            if (average >= 90)
            {
                Console.WriteLine("O GRADE");
            }
            else if (average < 90 && average >= 75)
            {
                Console.WriteLine("A+ GRADE");
            }
            else if (average < 75 && average >= 60)
            {
                Console.WriteLine("A GRADE");
            }
            else if (average < 60 && average >= 45)
            {
                Console.WriteLine("B GRADE");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
    internal class stuentDetails
    {
        static void Main(string[] args)
        {
            student std = new student();
            int id = 11;
            string name = "Ravi";
            int age = 22;
            std.DisplayStudent(id, name, age);
            double sub1 = 66;
            double sub2 = 77;
            double sub3 = 88;
            std.AcceptStdMarks(out sub1, out sub2, out sub3);
            int pmarks = 29;
            std.DisplaytotalMarks(ref pmarks);
        }
    }
}
