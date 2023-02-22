
using System.Xml.Linq;

namespace Lesson7HomeWork
{
    class Medic
    {
        public string MedicsName;
        public Medic(string MedicsName)
        {
            this.MedicsName = MedicsName;
        }
        public Medic() { }

        public virtual void ToTreat(string name) {  }
    }
}
