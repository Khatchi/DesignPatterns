// Encapsulation

using DesignPatterns.src.OopPrinciple.Encapsulation;
using DesignPatterns.src.OopPrinciple.Abstraction;

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposite(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withraw(100);
System.Console.WriteLine(bankAccount.GetBalance());


// Abstraction reduce complexity by hiding unneccessary details

EmailService emailService = new EmailService();
emailService.SendEmail();


