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
        public static void prescribeTreatment(int treatmentCode) 
        {
            if (treatmentCode == 1)
            {
                Console.WriteLine($"Назначен {Medic.medicsType} {Medic.medicsName}");
                Medic.ToTreat();
            }
            else if (treatmentCode == 2)
            {
                Console.WriteLine($"Назначен {Medic.medicsType} {Medic.medicsName}");
                Medic.ToTreat();
            }
            else
            {
                Console.WriteLine($"Назначен {Medic.medicsType} {Medic.medicsName}");
                Medic.ToTreat();
            }
        }

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

            
            //Medic surgeon = new Medic("Денис", "хирург");
            //Medic dentist = new Medic("Сергей", "дантист");
            //Medic therapist = new Medic("Павел", "терапевт");

            Patient patient0 = new Patient("Николай", 0);
            prescribeTreatment(patient0.patientDiagnosisCode);
            Patient patient1 = new Patient("Леонид", 1);
            Patient patient2 = new Patient("Александр", 2);
            Patient patient3 = new Patient("Пётр", 3);



            // Task 2.1 (основное задание) ------------------------------------------------------




        }
    }
}