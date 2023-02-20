
namespace Lesson7HomeWork
{
    internal class Patient
    {
        public string patientName { get; set; }
        public int patientDiagnosisCode { get; set; }

        public Patient(string patientName, int patientDiagnosisCode) 
        { 
            this.patientName = patientName;
            this.patientDiagnosisCode = patientDiagnosisCode;
        }
    }
}
