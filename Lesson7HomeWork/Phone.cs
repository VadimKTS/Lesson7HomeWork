

namespace Lesson7HomeWork
{
    // For Task 1.1--------------------------------------------------------------


    internal class Phone
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        
        public Phone( string Number, string Model, int Weight) : this(Number, Model)
        {
            this.Weight = Weight;
        }

        public Phone(string Number, string Model) 
        {
            this.Number = Number;
            this.Model = Model;
        }

        public Phone() { }
        
        
        public void RecieveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void RecieveCall(string name, string Number)
        {
            Console.WriteLine($"Звонит {name} \n.......{Number}");
        }

        public string GetNumber()
        {

            return Number;
        }

        public static void SendMessage(params string[] number)
        {
            foreach (var item in number)
            {
                Console.WriteLine($"Сообщение отправлено на номер {item}");
            }
        }
    }
}
