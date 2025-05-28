using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Nurse:Patient
    {
        public string NurseName { get; set; }
        public string Preception { get; set; }
        public double Patientcost { get; set; }
        //constructor
        public Nurse(string doctorname, double timing, string specilization, string patientName, int patientAge, string patientDisease, string nurseName, string preception, double patientcost)
            : base(doctorname, timing, specilization, patientName, patientAge, patientDisease)
        {
            NurseName = nurseName;
            Preception = preception;
            Patientcost = patientcost;
        }
        //display
        public override void Display()
        {
          
            Console.WriteLine($"The nurse name is: {NurseName}, Preception: {Preception}, Patient cost: {Patientcost}");
        }


    }
}
