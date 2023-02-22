
namespace Lesson7HomeWork
{
    internal class Dentist : Medic
    {
        public Dentist(string MedicsName)
        {
            this.MedicsName = MedicsName;
        }
        public override void ToTreat(string name)
        {
            Console.WriteLine($"Проводится лечение зубов для {name}");
        }
    }
}
