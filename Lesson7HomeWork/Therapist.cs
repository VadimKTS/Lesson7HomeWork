
namespace Lesson7HomeWork
{
    internal class Therapist : Medic
    {
        public Therapist(string medicsName, string medicsType)
        {
            this.medicsName = medicsName;
            this.medicsType = medicsType;
        }
        public override void ToTreat(string name)
        {
            Console.WriteLine($"Доп. исследование для {name}");
        }
    }
}
