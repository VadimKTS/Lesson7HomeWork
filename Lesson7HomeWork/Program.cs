namespace Lesson7HomeWork
{
    internal class Program
    {
        // For Task 1.1----------------------------------------------------------------
        public static void sendMessage(params string[] number)
        {
            foreach (var item in number)
            {
                Console.WriteLine($"Сообщение отправлено на номер {item}");
            }
        }

        // For Task 1.2 ---------------------------------------------------------------

            public static void prescribeTreatment(string name, int treatmentCode) 
        {
            
            if (treatmentCode == 1)
            {
                Surgeon surgeon = new Surgeon("Денис", "хирург");
                Console.WriteLine($"Назначен {surgeon.medicsType} {surgeon.medicsName}");
                surgeon.ToTreat(name);
            }
            else if (treatmentCode == 2)
            {
                Dentist dentist = new Dentist("Сергей", "дантист");
                Console.WriteLine($"Назначен {dentist.medicsType} {dentist.medicsName}");
                dentist.ToTreat(name);
            }
            else
            {
                Therapist therapist = new Therapist("Павел", "терапевт");
                Console.WriteLine($"Назначен {therapist.medicsType} {therapist.medicsName}");
                therapist.ToTreat(name);
            }
        }


        // For Task 1.2 ---------------------------------------------------------------




        // ----------------------------------------------------------------------------
        static void Main(string[] args)
        {
            // Task 1.1----------------------------------------------------------------

            //Phone nokia = new Phone("079876987", "Нокиа", 383);
            //Console.WriteLine($"Номер: {nokia.number}, модель: {nokia.model}, вес: {nokia.weight}");
            //nokia.recieveCall("Alex");
            //Console.WriteLine(nokia.getNumber());

            //Phone sony = new Phone("235645635", "Сони");
            //Console.WriteLine($"Номер: {sony.number}, модель: {sony.model}, вес: {sony.weight}");
            //sony.recieveCall("Inga");
            //Console.WriteLine(sony.getNumber());

            //Phone apple = new Phone();
            //Console.WriteLine($"Номер: {apple.number}, модель: {apple.model}, вес: {apple.weight}");
            //apple.recieveCall("Maxim");
            //Console.WriteLine(apple.getNumber());

            //Console.WriteLine("--------------перегрузка метода recieveCall() ----------------------");

            //nokia.recieveCall("Alex", nokia.getNumber());
            //sony.recieveCall("Inga", sony.number);
            //apple.recieveCall("Maxim", "98768765876");

            //string[] numbers = new[] {nokia.number, sony.number, apple.number};
            //sendMessage(numbers);


            // Task 1.2 ----------------------------------------------------------------------

            //TreatmentPlan codeForSurgeon = new("перелом");
            //TreatmentPlan codeForDentist = new("флюс");
            //TreatmentPlan codeForTherapist = new("температура");
            //TreatmentPlan codeForTherapist2 = new("кашель");

            //Patient patient0 = new Patient("Николай");
            //prescribeTreatment(patient0.patientName, codeForSurgeon.treatmentCode);

            //Patient patient1 = new Patient("Леонид");
            //prescribeTreatment(patient1.patientName, codeForDentist.treatmentCode);

            //Patient patient2 = new Patient("Александр");
            //prescribeTreatment(patient2.patientName, codeForTherapist.treatmentCode);

            //Patient patient3 = new Patient("Пётр");
            //prescribeTreatment(patient3.patientName, codeForTherapist2.treatmentCode);


            // Task 2.1 (основное задание) ------------------------------------------------------

            CreditCard card1 = new(987568754, 0);
            card1.showAccountSumm();
            CreditCard card2 = new(265874458, 500);
            card2.showAccountSumm();
            CreditCard card3 = new(126749766, 999999);
            card3.showAccountSumm();

            card1.creditToAccount(300);
            card2.creditToAccount(15);
            card3.debitTheAccount(500);

            card1.showAccountSumm();
            card2.showAccountSumm();
            card3.showAccountSumm();




        }
    }
}