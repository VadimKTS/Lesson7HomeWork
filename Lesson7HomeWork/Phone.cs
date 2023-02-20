

namespace Lesson7HomeWork
{
    // For Task 1.1--------------------------------------------------------------
    internal class Phone
    {
        public string number { get; set; }
        public string model { get; set; }
        public int weight { get; set; }

        
        public Phone( string number, string model, int weight) : this(number, model)
        {
            this.weight = weight;
        }

        public Phone(string number, string model) 
        {
            this.number = number;
            this.model = model;
        }

        public Phone() { }
        
        
        public void recieveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void recieveCall(string name, string number)
        {
            Console.WriteLine($"Звонит {name} \n.......{number}");
        }

        public string getNumber()
        {

            return number;
        }

        // проверить как работает
        public void sendMessage(params string[] number)
        {
            foreach (var item in number)
            {
                Console.WriteLine($"Сообщение отправлено на номер {item}");
            }
        }
    }
}
