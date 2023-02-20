
using System.Security.Principal;

namespace Lesson7HomeWork
{
    internal class CreditCard
    {
        public int bankAccountNumber { get; set; }
        public decimal amountOnAccountr { get; set; }
        public CreditCard(int bankAccountNumber, decimal amountOnAccountr) 
        {
            this.bankAccountNumber = bankAccountNumber;
            this.amountOnAccountr = amountOnAccountr;
        }

        public decimal creditToAccount(decimal creditSumm) 
        {
            Console.WriteLine($"На счет №{bankAccountNumber} зачислено {creditSumm}");
            return amountOnAccountr += creditSumm;
        }

        public decimal debitTheAccount(decimal debitSumm) 
        {
            Console.WriteLine($"Со счета №{bankAccountNumber} списано {debitSumm}");
            return amountOnAccountr -= debitSumm;
        }

        public void showAccountSumm() 
        {
            Console.WriteLine($"Сумма на счете №{bankAccountNumber} = {amountOnAccountr}");
        }
    }
}
