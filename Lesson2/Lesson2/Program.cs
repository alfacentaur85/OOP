using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccountChecking = new BankAccount(AccountTypeEnum.Checking, 0);
            BankAccount bankAccountDeposit = new BankAccount(AccountTypeEnum.Deposit, 1000);
            BankAccount bankAccountPayment = new BankAccount(AccountTypeEnum.Payment, 5000);

            bankAccountDeposit.DepositToAccount(2000);

            bankAccountDeposit.WithdrawFromAccount(4000);

            bankAccountDeposit.WithdrawFromAccount(3000);

        }
    }
}
