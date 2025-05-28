using System;
using Hospital_Management;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Hospital Manangement");
        //parent to call the child class
        Doctor hospital = new Doctor("Manikandan", 10.00, "Children doctor");
       hospital.Display();

        Console.WriteLine("Enter the patient details");

        Patient doctor = new Patient("Manikandan", 10.00, "Children doctor", "Arun", 5, "Fever");
       doctor.Display();
        Console.WriteLine("Enter the nurse details");
        Nurse nurse = new Nurse ("Manikandan", 10.00, "Children doctor", "Arun", 5, "Fever", "Moni", "Medicine", 5000);
        nurse.Display();
    }
}
