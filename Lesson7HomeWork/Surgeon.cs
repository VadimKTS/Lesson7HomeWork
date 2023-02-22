
namespace Lesson7HomeWork
{
    class Surgeon : Medic
    {
        public Surgeon(string MedicsName)
        {
            this.MedicsName = MedicsName;
        }

        public override void ToTreat(string name)
        {
            Console.WriteLine($"Проводится операция для {name}");
        }

    }
}
