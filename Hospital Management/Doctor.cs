using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Doctor
    {
        //methods
        public string Doctorname { get; set; }
        public double Timing { get; set; }
        public string Specilization { get; set; }
        //constructor
        public Doctor(string doctorname,double timing,string specilization)
        {
            Doctorname = doctorname;
            Timing = timing;
            Specilization = specilization;
        }
       //display
       public virtual void Display()
        {
            Console.WriteLine($"The doctor name is:{Doctorname},The Doctor Timing:{Timing}The doctor Specilization:{Specilization}");
        }
    }
}
