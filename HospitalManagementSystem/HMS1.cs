//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace HospitalManagementSystem
//{
//    public abstract class HospitalMember
//    {
//        public int Id;
//        public string Name;
//    }
//    public class Patient : HospitalMember
//    {
//        public int age;
//        private string Contact;
//        public void setContat(string contact)
//        {
//            Contact = contact;
//        }
//        public string GetContact()
//        {
//            return Contact;
//        }
//        public void Register()
//        {
//            Console.WriteLine("Patient Registered");
//        }
//        public void ViewDetails()
//        {
//            Console.WriteLine($"ID : {Id}, Name : {Name},Age : {age}, contact :{Contact}");
//        }
//    }
//    public class Doctor:HospitalMember
//    {
//        public string Specialization;
//        public void ViewSchedule()
//        {
//            Console.WriteLine($"Doctor's name : {Name} and  Specialization : {Specialization} Schedule");
//        }
//    }
//    public class Appointment
//    {
//        public int appointmentId;
//        public Patient patient;
//        public Doctor doctor;
//        public DateTime AppointmentDate;
//        public void ScheduleAppointment()
//        {
       
//            Console.WriteLine($"Appointment scheduled for patient {patient.Name} with Doctor {doctor.Name}  on  {AppointmentDate}");
//        }
//        public void cancelAppointment()
//        {
//            Console.WriteLine($"Appointment with ID {appointmentId} has been cncelled");
//        }
//    }
//    public interface IBilling
//    {
//        void GenerateBill();
//        void payBill();
//    }
//    public class InPatientBill:IBilling
//    {
//        public int Billid;
//        public Patient Patient;
//        public int DaysAdmitted;
//        public double Amount;
//        public double RoomChargePerDay;
//        public string Status;
//        public void GenerateBill()
//        {
//            Amount = DaysAdmitted * RoomChargePerDay;
//            Console.WriteLine($"Bill generated for patient  {Patient.Name}  with  amount : {Amount}");
//        }
//        public void payBill()
//        {
//            Status = "Paid";
//            Console.WriteLine($"Bill with ID {Billid} has been paid");
//        }
//    }
//    public class OutPatientBill:IBilling
//    {
//        public int Billid;
//        public Patient Patient;
//        public double amount;
//        public double ConsultationFee;
//        public string Status;
//        public void GenerateBill()
//        {
//            amount = ConsultationFee;
//            Console.WriteLine($"Bill generted for patient : {Patient.Name}  with Amount : {amount}");
//        }
//        public void payBill()
//        {
//            Status = "Paid";
//            Console.WriteLine($"Bill with {Billid} has been paid");
//        }
//    }
//    internal class HMS1
//    {
//        static void Main( string[] args )
//        {
//            Patient patient1 = new Patient();
//            patient1.setContat("123-456-789");
//            patient1.Register();
//            patient1.ViewDetails();
//            Doctor doctor1= new Doctor {Id=101,Name="Dr. Smith",Specialization="Cordiology"};
//            doctor1.ViewSchedule();
//            Appointment appointment1 = new Appointment {appointmentId=1001,patient=patient1,doctor=doctor1, AppointmentDate=DateTime.Now.AddDays(2) };
//            appointment1.ScheduleAppointment();
//            appointment1.cancelAppointment();
//            InPatientBill inbill=new InPatientBill {Billid=5001,Patient=patient1,DaysAdmitted=5,RoomChargePerDay=200};
//            inbill.GenerateBill();
//            inbill.payBill();
//            OutPatientBill outbill = new OutPatientBill { Billid = 5002, Patient = patient1, ConsultationFee = 200 };
//            outbill.GenerateBill();
//            outbill.payBill();
//        }  
//    }
//}
