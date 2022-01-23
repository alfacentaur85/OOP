using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class BankAccount
    {
        private static int _accountNumberGlobal = 0;

        private int _accountNumber = 0;
        private decimal _accountBalance = 0.00M;
        private AccountTypeEnum _accountType = AccountTypeEnum.Checking;
        
        private static int GenerateAccountNumberGlobal()
        {
            return ++_accountNumberGlobal;
        }

        public int AccountNumber 
        {
            get
            {
                return _accountNumber;
            }

            private set
            {
                _accountNumber = value;
            }
        }

        public decimal AccountBalance
        {
            get
            {
                return _accountBalance;
            }

            set
            {
                _accountBalance = value;
            }
        }

        public AccountTypeEnum AccountType
        {
            get
            {
                return _accountType;
            }

            set
            {
                _accountType = value;
            }
        }
            
        public BankAccount(AccountTypeEnum accountType, int accountBalance)
        {
            _accountNumber = GenerateAccountNumberGlobal();
            _accountType = accountType;
            _accountBalance = accountBalance;

            AccountStatementPrint();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            BankAccount bankAccount = obj as BankAccount;

            if (   
                   (bankAccount.AccountBalance == this.AccountBalance)
                && (bankAccount.AccountNumber == this.AccountNumber)
                && (bankAccount.AccountType == this.AccountType)
               )
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AccountBalance, AccountNumber, AccountType);
        }

        public static bool operator ==(BankAccount bankAccount1, BankAccount bankAccount2)
        {
            if (
                    (bankAccount1.AccountBalance == bankAccount2.AccountBalance)
                && (bankAccount1.AccountNumber == bankAccount2.AccountNumber)
                && (bankAccount1.AccountType == bankAccount2.AccountType)
               )
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(BankAccount bankAccount1, BankAccount bankAccount2)
        {
            if (
                    (bankAccount1.AccountBalance != bankAccount2.AccountBalance)
                || (bankAccount1.AccountNumber != bankAccount2.AccountNumber)
                || (bankAccount1.AccountType != bankAccount2.AccountType)
               )
            {
                return true;
            }
            return false;
        }

        public override string? ToString()
        {

            return string.Concat('\n', "Account Number: ", AccountNumber, '\n', "Account Type: ", AccountType, '\n', "Account Balance: ", AccountBalance);
        }

        private void AccountStatementPrint()
        {
            Console.WriteLine();
            Console.WriteLine("Account Number: {0}", AccountNumber);
            Console.WriteLine("Account Type: {0}", AccountType);
            Console.WriteLine("Account Balance: {0}", AccountBalance);
        }

        private void ErrExceedingAccountBalancePrint()
        {
            Console.WriteLine();
            Console.WriteLine("Operation faild cause exceeded the current balance. The current balance is {0}", AccountBalance);
        }

            private bool IsCanWithdraw(decimal withdramAmount)
        {
            if (withdramAmount > AccountBalance)
            {
                return false;
            }

            return true;
        }

        public void DepositToAccount(decimal depositAmount)
        {
            AccountBalance = AccountBalance + depositAmount;
            AccountStatementPrint();
        }

        public void WithdrawFromAccount(decimal withdrawAmount)
        {
            Console.WriteLine("\nTrying withdraw from account {0} amount: {1}", _accountNumber, withdrawAmount);
            if (!IsCanWithdraw(withdrawAmount))
            {
                ErrExceedingAccountBalancePrint();
            }
            else
            {
                AccountBalance -= withdrawAmount;
                AccountStatementPrint();
            }

        }

    }
}
