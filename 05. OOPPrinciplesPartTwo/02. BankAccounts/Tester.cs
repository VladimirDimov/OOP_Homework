namespace _02.BankAccounts
{
    using System;

    class Tester
    {
        static void Main()
        {
            // Testing with individual customer
            Deposit pPetrov = new Deposit(new IndividualCustomer("Pesho", "Peshev"), 2000, 0.05m);
            pPetrov.DepositMoney(1500);
            pPetrov.WithdrawMoney(500);
            Console.WriteLine(pPetrov.ToString());
            Console.WriteLine("Interesr amount for 14 months = {0} lv.", pPetrov.InterestAmount(14));

            // Testing with company customer
            Console.WriteLine();
            Loan goshoOOD = new Loan(new CompanyCustomer("Gosho OOD"), 26000);
            goshoOOD.InterestRate = 0.03m;
            Console.WriteLine(goshoOOD.ToString());
            Console.WriteLine("Interesr amount for 10 months = {0} lv.", pPetrov.InterestAmount(10));
        }
    }
}
