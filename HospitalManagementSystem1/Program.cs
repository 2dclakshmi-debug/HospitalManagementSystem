using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HospitalManagementSystem1
{
    abstract class HospitalMember
    {
        protected int id;
        protected string name;
        public HospitalMember(int hid, string hname)
        {
            id = hid;
            name = hname;
        }

        public abstract void Hdisplay();

    }
    class Patient : HospitalMember
    {
        public string Disease;
        public string Add;
        private long contactno;
        public long Contactno
        {
            get { return contactno; }
            set { contactno = value; }
        }
        public Patient(string disease, string add, int id, string name) : base(id, name)
        {
            Disease = disease;
            Add = add;
        }
        public void PDisplay()
        {
            Console.WriteLine("Patient id : " + id);
            Console.WriteLine("Patient name : " + name);
            Console.WriteLine("Patient disease : " + Disease);
            Console.WriteLine("Patient Address : " + Add);
        }
   
        public override void Hdisplay()
        {
            id = 1231;
            name = "RainBow";
            Console.WriteLine("Hospital id : " + id);
            Console.WriteLine("Hospital name : " + name);
        }
    }
    public class Bloodgrp
    {
        public string Blood(string Bloodgroup)
        {
            return Bloodgroup;
        }
    }
    public delegate string Mydelegate(string Bloodgroup);
    interface IDoctor
    {
        void Doctordisplay<T, K,L>(T a, K b, L c);

    }
    class Appointment : Patient, IDoctor
    {

        public string Time;
        public Appointment(string time, string Disease, string Add, int id, string name) : base(Disease, Add, id, name)
        {

            Time = time;
        }
        public void AppDisplay()
        {

            Console.WriteLine("Appointment time : " + Time);
        }
        public override void Hdisplay()
        {
            Console.WriteLine("Hospital id : " + id);
            Console.WriteLine("Hospital name : " + name);
        }
        public void Doctordisplay<T, K,L>(T a, K b,L c)
        {
            Console.WriteLine("Doctor id : " + a);
            Console.WriteLine("doctor name : " + b);
            Console.WriteLine("specialization : " + c);
        }
    }
    sealed class Bill
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
        static void GenerateReport()
        {
            Console.WriteLine("Report Generation Started...");

            Thread.Sleep(3000);

            Console.WriteLine("Report Generated Successfully");
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Register a Patient");
                    Console.WriteLine("------------------");
                    Patient p = new Patient("heartpain", "Hyd", 45, "Ravi");
                    p.PDisplay();
                    Console.WriteLine("Hospital Details");
                    Console.WriteLine("----------------");
                    p.Hdisplay();
                    Bloodgrp bg=new Bloodgrp();
                    Console.WriteLine("blood group : " + bg.Blood("B+"));
                    Appointment app = new Appointment("11 am", "hearrtpain", "Hyd", 121, "Ravi");
                    app.AppDisplay();
                
                    app.Doctordisplay<int, string,string>(111, "Aravind","Cordiologist");
                    Bill bill = new Bill(12, 500, "IN");
                    Console.WriteLine("Total Bill");
                    Console.WriteLine("----------");
                    bill.GenerateBill(3);
                    Thread t1 = new Thread(GenerateReport);

                    t1.Start();

                    Console.WriteLine("Main Thread Executing...");

                    t1.Join();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("error :" + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Program Execution is completed");
                }
            }
        }
    }
}

    
