
namespace Lesson7HomeWork
{
    class Surgeon : Medic
    {
        public Surgeon(string medicsName, string medicsType)
        {
            this.medicsName = medicsName;
            this.medicsType = medicsType;
        }

        public override void ToTreat(string name)
        {
            Console.WriteLine($"Проводится операция для {name}");
        }

    }
}
