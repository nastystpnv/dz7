using System;


namespace tumakov8
{
    internal class Class2
    {
        enum BankAccountType
        {
            Current,
            Saving
        }
        class BankAccount
        {
            private int account_number;
            private double balance;
            private BankAccountType type;
            public int Number
            {
                get => account_number;
                set => account_number = value;
            }
            public double Balance
            {
                get => balance;
                set => balance = value;
            }
            public BankAccountType Type
            {
                get => type;
                set => type = value;
            }
            static Random r = new Random();
            private static int generic_number = r.Next(999, 10000);
            public int Generic
            {
                get => generic_number;
                set => generic_number++;
            }
            public double PutOnAccount(double balance)
            {
                Console.Write("Введите сумму для пополнения ");
                double temp = Convert.ToDouble(Console.ReadLine());
                return balance + temp;
            }
            public double WithdrawFromAccount(double balance)
            {
                Console.Write("Введите сумму для снятия ");
                double temp = Convert.ToDouble(Console.ReadLine());
                if (balance >= temp)
                { return balance - temp; }
                else
                { Console.WriteLine("На вашем счёте недостаточно средств!"); return balance; }
            }
            //task8.1
            public void Transfer(BankAccount destinationAccount, double amount)
            {
                Console.Write("Введите сумму для перевода: ");
                double transferAmount = Convert.ToDouble(Console.ReadLine());

                if (this.Balance >= transferAmount)
                {
                    this.Balance -= transferAmount;
                    destinationAccount.Balance += transferAmount;
                    Console.WriteLine($"Перевод успешен! Сумма {transferAmount}$ переведена со счёта {this.Number} на счёт {destinationAccount.Number}");
                }
                else
                {
                    Console.WriteLine("На вашем счёте недостаточно средств для перевода.");
                }
            }

        }
    }
}
