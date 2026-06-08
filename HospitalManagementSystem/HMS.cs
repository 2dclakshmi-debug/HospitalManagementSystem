using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    internal class HMS
    {
        abstract class HospitalMember
        {
            protected int id;
            protected string name;
            public HospitalMember(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public void Hospdisplay()
            {
                Console.WriteLine("Hospital id :" + id);
                Console.WriteLine("Hospital name :" + name);
            }
        }
        class Patient : HospitalMember
        {
            public string Pname;
            public string Disease;
            public int Age;
            private long PmobileNum;
            public Patient(string pname, string disease, int age, long pmobileNum, int id, string name) : base(id, name)
            {
                Pname = pname;
                Disease = disease;
                Age = age;
                PmobileNum = pmobileNum;
            }
            public void display()
            {
                Console.WriteLine("patient name : " + Pname);
                Console.WriteLine("patient disease : " + Disease);
                Console.WriteLine("patient Age : " + Age);
                Console.WriteLine("patient MobileNum : " + PmobileNum);
            }
        }
        interface IDoctor
        {
            void Hdisplay(string doctorName, string specialization);

        }
        class Appointment : Patient, IDoctor
        {
            public int appid;
            public string apptime;
            public string specialistname;
            public Appointment(int appid, string apptime, string specialistname, string pname, string disease, int age, long pmobileNum, int id, string name) : base(pname, disease, age, pmobileNum, id, name)
            {
                this.appid = appid;
                this.apptime = apptime;
                this.specialistname = specialistname;
            }
            public void Hdisplay(string doctorName, string specialization)
            {
                Console.WriteLine("Doctorname is :" + doctorName);
                Console.WriteLine("Doctor Specialization :" + specialization);
            }

            public void scheduleappointment(bool patientispresent)
            {
                if (patientispresent == true)
                {
                    Console.WriteLine("Appontment id: " + id);
                    Console.WriteLine("Appointment Time: " + apptime);
                    Console.WriteLine("Specialist name : " + specialistname);
                }
                else
                {
                    Console.WriteLine("Appointment cancelled");
                }
            }
        }
        class Bill
        {
            public int Billid;
            public double ConsultancyFee;
            public string PType;
            public Bill(int billid, double consultancyFee, string ptype)
            {
                Billid = billid;
                ConsultancyFee = consultancyFee;
                PType = ptype;

            }
            public void GenerateBill(int days)
            {
                double Bill;
                if (PType == "IN")
                {
                    double bedchargePerday = 2000;
                    Bill = days * bedchargePerday + ConsultancyFee;
                    Console.WriteLine("Total bill is :" + Bill);

                }
                else
                {
                    Bill = ConsultancyFee;
                    Console.WriteLine("Total bill is :" + Bill);

                }
            }
        }
        internal class Program1
        {
            static void Main(string[] args)
            {

                Console.WriteLine("1 .Coriologist \n 2 . ENT \n 3 .Orthopedic \n 4.Neurologist ");
                Console.WriteLine("Select Option: ");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Register a Patient");
                        Console.WriteLine("------------------");
                        Patient p = new Patient("Ravi", "HeartPain", 45, 1234567899, 11, "RainBow");
                        p.display();
                        Console.WriteLine("Hospital Details");
                        Console.WriteLine("----------------");
                        p.Hospdisplay();
                        Appointment app = new Appointment(123, "12:45PM", "Tanmay", "Ravi", "HeartPain", 45, 1234567899, 11, "RanBow");
                        app.Hdisplay("Tanmay", "Cordiologist");
                        app.scheduleappointment(true);
                        Bill bill = new Bill(12, 500, "IN");
                        Console.WriteLine("Total Bill");
                        Console.WriteLine("----------");
                        bill.GenerateBill(3);
                        break;
                    case 2:
                        Console.WriteLine("Register a Patient");
                        Console.WriteLine("------------------");
                        Patient p1 = new Patient("Ravi", "EyePain", 45, 1234567899, 11, "RainBow");
                        p1.display();
                        Console.WriteLine("Hospital Details");
                        Console.WriteLine("----------------");
                        p1.Hospdisplay();
                        Appointment app1 = new Appointment(123, "12:45PM", "NagaThanvik", "Ravi", "EyePain", 45, 1234567899, 11, "RanBow");
                        app1.Hdisplay("Tanmay", "Cordiologist");
                        app1.scheduleappointment(true);
                        Bill bill1 = new Bill(12, 500, "IN");
                        Console.WriteLine("Total Bill");
                        Console.WriteLine("----------");
                        bill1.GenerateBill(3);
                        break;
                    case 3:
                        Console.WriteLine("Register a Patient");
                        Console.WriteLine("------------------");
                        Patient p2 = new Patient("Ravi", "BonePain", 45, 1234567899, 11, "RainBow");
                        p2.display();
                        Console.WriteLine("Hospital Details");
                        Console.WriteLine("----------------");
                        p2.Hospdisplay();
                        Appointment app2 = new Appointment(123, "12:45PM", "Rupika", "Ravi", "BonePain", 45, 1234567899, 11, "RanBow");
                        app2.Hdisplay("Rupika", "OrthoPedic");
                        app2.scheduleappointment(true);
                        Bill bill2 = new Bill(12, 500, "IN");
                        Console.WriteLine("Total Bill");
                        Console.WriteLine("----------");
                        bill2.GenerateBill(3);
                        break;
                    case 4:
                        Console.WriteLine("Register a Patient");
                        Console.WriteLine("------------------");
                        Patient p3 = new Patient("Ravi", "Nerves Pain", 45, 1234567899, 11, "RainBow");
                        p3.display();
                        Console.WriteLine("Hospital Details");
                        Console.WriteLine("----------------");
                        p3.Hospdisplay();
                        Appointment app3 = new Appointment(123, "12:45PM", "Tanmay", "Ravi", "Nervespain", 45, 1234567899, 11, "RanBow");
                        app3.Hdisplay("Tanmay", "Nurologist");
                        app3.scheduleappointment(true);
                        Bill bill3 = new Bill(12, 500, "IN");
                        Console.WriteLine("Total Bill");
                        Console.WriteLine("----------");
                        bill3.GenerateBill(3);
                        break;
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }
        }
    }
}
            

  

