// See https://aka.ms/new-console-template for more information
using bank_acc;

Console.WriteLine("Hello, World!");
static void Main(string[] args)
  {
    IBankAccount savingAccount = new SavingAccount();
   IBankAccount currentAccount = new CurrentAccount();
    
savingAccount.Deposit(200);
    savingAccount.Withdraw(100);
   savingAccount.ToString();
    
currentAccount.Deposit(500);
    currentAccount.Withdraw(600);
    currentAccount.Withdraw(200);
    currentAccount.ToString();
    Console.ReadLine();
}

Console.WriteLine(Main);