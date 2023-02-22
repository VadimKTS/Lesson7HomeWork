
namespace Lesson7HomeWork
{
    internal class Therapist : Medic
    {
        public Therapist(string MedicsName)
        {
            this.MedicsName = MedicsName;
        }
        public override void ToTreat(string name)
        {
            Console.WriteLine($"Доп. исследование для {name}");
        }
    }
}
