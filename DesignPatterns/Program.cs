// Encapsulation

using DesignPatterns.src.OopPrinciple.Encapsulation;

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposite(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withraw(100);
System.Console.WriteLine(bankAccount.GetBalance());