
namespace Lesson7HomeWork
{
    class Medic
    {
        public string medicsName;
        public string medicsType;
        public Medic(string medicsName, string medicsType) 
        {
            this.medicsName = medicsName;
            this.medicsType = medicsType;
        }
        public virtual void ToTreat()
        {
            
        }
    }
}
