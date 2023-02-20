
namespace Lesson7HomeWork
{
    internal class Dentist : Medic
    {
        public Dentist(string medicsName, string medicsType)
        {
            this.medicsName = medicsName;
            this.medicsType = medicsType;
        }
        public override void ToTreat(string name)
        {
            Console.WriteLine($"Проводится лечение зубов для {name}");
        }
    }
}
