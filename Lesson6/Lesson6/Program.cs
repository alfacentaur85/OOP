using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccountChecking = new BankAccount(AccountTypeEnum.Checking, 0);
            BankAccount bankAccountDeposit = new BankAccount(AccountTypeEnum.Deposit, 1000);
            BankAccount bankAccountPayment = new BankAccount(AccountTypeEnum.Payment, 5000);

            Console.WriteLine(bankAccountChecking.ToString());
            Console.WriteLine(bankAccountDeposit.ToString());
            Console.WriteLine(bankAccountPayment.ToString());

            Console.WriteLine(bankAccountChecking.Equals(bankAccountChecking));
            Console.WriteLine(bankAccountChecking.Equals(bankAccountDeposit));

            Console.WriteLine(bankAccountChecking == bankAccountChecking);
            Console.WriteLine(bankAccountChecking == bankAccountDeposit);

            Console.WriteLine(bankAccountChecking != bankAccountChecking);
            Console.WriteLine(bankAccountChecking !=bankAccountDeposit);

        }
    }
}
