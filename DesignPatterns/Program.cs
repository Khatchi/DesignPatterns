// Encapsulation

using DesignPatterns.src.OopPrinciple.Encapsulation;
using DesignPatterns.src.OopPrinciple.Abstraction;
using DesignPatterns.src.OopPrinciple.Inheritance;

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposite(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withraw(100);
System.Console.WriteLine(bankAccount.GetBalance());

System.Console.WriteLine("===================================");


// Abstraction reduce complexity by hiding unneccessary details

EmailService emailService = new EmailService();
emailService.SendEmail();

System.Console.WriteLine("===================================");


// Inheritance
var car = new Car();

/* Shared properties */
car.Brand = "Ford";
car.Start();
car.Stop();

/* Unique properties */
car.NumberOfDoors = 4;

System.Console.WriteLine("===================================");





