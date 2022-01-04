using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccountCheckingFrom = new BankAccount(AccountTypeEnum.Checking, 1000);
            BankAccount bankAccountDeposit = new BankAccount(AccountTypeEnum.Deposit, 0);

            bankAccountDeposit.WithdrawFromAccount(bankAccountCheckingFrom, 4000);

            bankAccountDeposit.WithdrawFromAccount(bankAccountCheckingFrom, 500);


        }
    }
}
