namespace Lesson7HomeWork
{
    internal class Program
    {
        // For Task 1.1--------------------------------------------------------------
        public static void sendMessage(params string[] number)
        {
            foreach (var item in number)
            {
                Console.WriteLine($"Сообщение отправлено на номер {item}");
            }
        }
        // -----------------------------------------------------------------------


        static void Main(string[] args)
        {
            // Task 1.1--------------------------------------------------------------
            
            Phone nokia = new Phone("079876987", "Нокиа", 383);
            Console.WriteLine($"Номер: {nokia.number}, модель: {nokia.model}, вес: {nokia.weight}");
            nokia.recieveCall("Alex");
            Console.WriteLine(nokia.getNumber());

            Phone sony = new Phone("235645635", "Сони");
            Console.WriteLine($"Номер: {sony.number}, модель: {sony.model}, вес: {sony.weight}");
            sony.recieveCall("Inga");
            Console.WriteLine(sony.getNumber());
            
            Phone apple = new Phone();
            Console.WriteLine($"Номер: {apple.number}, модель: {apple.model}, вес: {apple.weight}");
            apple.recieveCall("Maxim");
            Console.WriteLine(apple.getNumber());

            Console.WriteLine("--------------перегрузка метода recieveCall() ----------------------");

            nokia.recieveCall("Alex", nokia.getNumber());
            sony.recieveCall("Inga", sony.number);
            apple.recieveCall("Maxim", "98768765876");

            string[] numbers = new[] {nokia.number, sony.number, apple.number};
            sendMessage(numbers);


            // Task 1.2 ----------------------------------------------------------------------



            // Task 2.1 (основное задание)




        }
    }
}