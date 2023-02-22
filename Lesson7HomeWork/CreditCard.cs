namespace Lesson7HomeWork
{
    internal class CreditCard
    {
        public int BankAccountNumber { get; set; }
        public decimal AmountOnAccountr { get; set; }
        public CreditCard(int BankAccountNumber, decimal AmountOnAccountr) 
        {
            this.BankAccountNumber = BankAccountNumber;
            this.AmountOnAccountr = AmountOnAccountr;
        }

        public decimal CreditToAccount(decimal creditSumm) 
        {
            Console.WriteLine($"На счет №{BankAccountNumber} зачислено {creditSumm}");
            return AmountOnAccountr += creditSumm;
        }

        public decimal DebitTheAccount(decimal debitSumm) 
        {
            Console.WriteLine($"Со счета №{BankAccountNumber} списано {debitSumm}");
            return AmountOnAccountr -= debitSumm;
        }

        public void ShowAccountSumm() 
        {
            Console.WriteLine($"Сумма на счете №{BankAccountNumber} = {AmountOnAccountr}");
        }
    }
}
