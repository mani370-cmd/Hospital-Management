using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Patient : Doctor
    {
        //properties Methods  
        public string PatientName { get; set; }
        public int Patientage { get; set; }
        public string PatientDisease { get; set; }

        //constructor  
        public Patient(string doctorname, double timing, string specilization, string patientName, int patientAge, string patientDisease)
            : base(doctorname, timing, specilization)
        {
            PatientName = patientName;
            Patientage = patientAge;
            PatientDisease = patientDisease;
        }

        //display  
        public override void Display()
        {
            Console.WriteLine($"The patient name is: {PatientName}, Age: {Patientage}, Disease: {PatientDisease}");
        }
    }
}
