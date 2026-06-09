//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HospitalManagementSystem
//{
//        abstract class SchoolMember
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }

//            public SchoolMember(int id, string name)
//            {
//                Id = id;
//                Name = name;
//            }

//            public abstract void DisplayDetails();
//        }

       
//        interface ITeacher
//        {
//            void Teach();
//        }

        
//        class Student : SchoolMember
//        {
            
//            private double marks;

//            public double Marks
//            {
//                get { return marks; }
//                set { marks = value; }
//            }

//            public string Grade { get; set; }

//            public Student(int id, string name, double marks, string grade)
//                : base(id, name)
//            {
//                Marks = marks;
//                Grade = grade;
//            }

           
//            public override void DisplayDetails()
//            {
//                Console.WriteLine("Student Details");
//                Console.WriteLine("---------------");
//                Console.WriteLine("Student Id : " + Id);
//                Console.WriteLine("Student Name : " + Name);
//                Console.WriteLine("Marks : " + Marks);
//                Console.WriteLine("Grade : " + Grade);
//            }
//        }

//        class Teacher : SchoolMember, ITeacher
//        {
//            public string Subject { get; set; }

//            public Teacher(int id, string name, string subject)
//                : base(id, name)
//            {
//                Subject = subject;
//            }

//            public void Teach()
//            {
//                Console.WriteLine(Name + " is teaching " + Subject);
//            }

           
//            public override void DisplayDetails()
//            {
//                Console.WriteLine("Teacher Details");
//                Console.WriteLine("---------------");
//                Console.WriteLine("Teacher Id : " + Id);
//                Console.WriteLine("Teacher Name : " + Name);
//                Console.WriteLine("Subject : " + Subject);
//            }
//        }

//        class Fee
//        {
//            public int FeeId { get; set; }
//            public double Amount { get; set; }

//            public Fee(int feeId, double amount)
//            {
//                FeeId = feeId;
//                Amount = amount;
//            }

//            public void PayFee()
//            {
//                Console.WriteLine("Fee Payment Details");
//                Console.WriteLine("---------------");
//                Console.WriteLine("Fee Id : " + FeeId);
//                Console.WriteLine("Amount Paid : " + Amount);
//            }
//        }

//        internal class SchoolManagement
//        {
//            static void Main(string[] args)
//            {
//                Student s = new Student(101, "Ravi", 85, "A");

//                Teacher t = new Teacher(201, "Kumar", "Mathematics");

//                Fee f = new Fee(1, 5000);

//                s.DisplayDetails();

//                t.DisplayDetails();

//                t.Teach();

//                f.PayFee();

//                Console.ReadLine();
//            }
//        }
    
  
//}
