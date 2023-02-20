
namespace Lesson7HomeWork
{
    public class TreatmentPlan
    {
        public string treatment { get; set; }
        public int treatmentCode { get; set; }

        public TreatmentPlan(int treatmentCode) 
        { 
            Console.WriteLine(treatment);
        }

        //public TreatmentPlan()
        //{
        //    //Console.WriteLine(treatment);
        //}

    }
}
