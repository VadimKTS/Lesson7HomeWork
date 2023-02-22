
using System.Numerics;

namespace Lesson7HomeWork
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            //// Task 1.1----------------------------------------------------------------

            //Phone nokia = new Phone("079876987", "Нокиа", 383);
            //Console.WriteLine($"Номер: {nokia.Number}, модель: {nokia.Model}, вес: {nokia.Weight}");
            //nokia.RecieveCall("Alex");
            //Console.WriteLine(nokia.GetNumber());

            //Phone sony = new Phone("235645635", "Сони");
            //Console.WriteLine($"Номер: {sony.Number}, модель: {sony.Model}, вес: {sony.Weight}");
            //sony.RecieveCall("Inga");
            //Console.WriteLine(sony.GetNumber());

            //Phone apple = new Phone();
            //Console.WriteLine($"Номер: {apple.Number}, модель: {apple.Model}, вес: {apple.Weight}");
            //apple.RecieveCall("Maxim");
            //Console.WriteLine(apple.GetNumber());

            //Console.WriteLine("--------------перегрузка метода RecieveCall() ----------------------");

            //nokia.RecieveCall("Alex", nokia.GetNumber());
            //sony.RecieveCall("Inga", sony.Number);
            //apple.RecieveCall("Maxim", "98768765876");

            //string[] numbers = new[] { nokia.Number, sony.Number, apple.Number };
            //Phone.SendMessage(numbers);


            //// Task 1.2 ----------------------------------------------------------------------

            Patient patient0 = new Patient(0, "Пётр");
            patient0.PrescribeTreatment(patient0.PatientName);

            Patient patient1 = new Patient(1, "Алекс");
            patient1.PrescribeTreatment(patient1.PatientName);

            Patient patient2 = new Patient(2, "Лена");
            patient2.PrescribeTreatment(patient2.PatientName);

            //// Task 2.1 (основное задание) ------------------------------------------------------

            //CreditCard card1 = new(987568754, 0);
            //card1.ShowAccountSumm();
            //CreditCard card2 = new(265874458, 500);
            //card2.ShowAccountSumm();
            //CreditCard card3 = new(126749766, 999999);
            //card3.ShowAccountSumm();

            //card1.CreditToAccount(300);
            //card2.CreditToAccount(15);
            //card3.DebitTheAccount(500);

            //card1.ShowAccountSumm();
            //card2.ShowAccountSumm();
            //card3.ShowAccountSumm();




        }
    }
}