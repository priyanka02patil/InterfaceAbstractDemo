using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    public abstract class BankAccount
    {
        public abstract void Deposit(int amt);
        public abstract void Withdrow(int amt);
    }

    public class SavingAccount : BankAccount
    {
        private int balance;
        
        public SavingAccount(int balance)
        {
            this.balance = balance;
        }
        public override void Deposit(int amt)
        {
            balance = balance + amt;
        }

        public override void Withdrow(int amt)
        {
            if (balance > 3000)
            {
                balance = balance - amt;
            }
            else
            {
                Console.WriteLine($"insufficient balance");
            }

        }

        public override string ToString()
        {
            return $"Your Deposit in savingAccount is {balance}";
        }
    }

    public class CurrentAccount : BankAccount
    {
        private int balance;

        public CurrentAccount(int balance)
        {
            this.balance = balance;
        }

        public override void Deposit(int amt)
        {
            balance = balance + amt;
        }
        public override void Withdrow(int amt)
        {
            if(balance > 3000)
            {
                balance = balance - amt;
            }
            else
            {
                Console.WriteLine($"insufficient balance");
            }
           
        }

        public override string ToString()
        {
            return $"You have withdrow {balance} amount from your current account";
        }


    }





}
