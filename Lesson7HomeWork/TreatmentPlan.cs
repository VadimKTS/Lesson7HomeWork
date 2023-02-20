
namespace Lesson7HomeWork
{
    public class TreatmentPlan
    {
        public string treatment { get; set; }
        public int treatmentCode { get; set; }

        public TreatmentPlan(string treatment) 
        { 
            this.treatment = treatment;
            if (treatment.Equals("перелом"))
            {
                this.treatmentCode = 1;
            }
            else if (treatment.Equals("флюс"))
            {
                this.treatmentCode = 2;
            }
            else
            {
                this.treatmentCode = 0;
            }
        }

        //public int getTreatmentCode(string treatment, string patientDiagnosis)
        //{
        //    if (treatment.Equals(patientDiagnosis))
        //    {
        //        return treatmentCode;
        //    }
        //    return 0;
        //}
    }
}
