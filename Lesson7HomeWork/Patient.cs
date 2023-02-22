
namespace Lesson7HomeWork
{
    internal class Patient
    {
        public TreatmentPlan Plan { get; set; }
        public string PatientName { get; set; }

        public Patient(int code, string PatientName) 
        {
            Plan = new TreatmentPlan(code);
            this.PatientName = PatientName;
        }
        public void PrescribeTreatment(string patientName)
        {
            int code = TreatmentPlan.TreatmentCode;
            switch (code)
            {
                case 1:
                    Surgeon surgeon = new Surgeon("Денис");
                    Console.WriteLine($"Назначен {surgeon.MedicsName}");
                    surgeon.ToTreat(patientName);
                    break;
                case 2:
                    Dentist dentist = new Dentist("Сергей");
                    Console.WriteLine($"Назначен {dentist.MedicsName}");
                    dentist.ToTreat(patientName);
                    break;
                default:
                    Therapist therapist = new Therapist("Павел");
                    Console.WriteLine($"Назначен {therapist.MedicsName}");
                    therapist.ToTreat(patientName);
                    break;
            }
        }
    }
}
