// Encapsulation

using DesignPatterns.src.OopPrinciple.Encapsulation;
using DesignPatterns.src.OopPrinciple.Abstraction;
// using DesignPatterns.src.OopPrinciple.Inheritance;
using DesignPatterns.src.OopPrinciple.Polymorphism;
using System.ComponentModel;

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


// // Inheritance
// var car = new Car();

// /* Shared properties */
// car.Brand = "Ford";
// car.Start();
// car.Stop();

// /* Unique properties */
// car.NumberOfDoors = 4;


System.Console.WriteLine("===================================");

// Polymorphism-- ability of an object to take many forms.

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new Motorcycle { Brand = "Harley", Model = "Sportster", Year = 2021 });

// Vehicle inspection

foreach (var vehicle in vehicles)
{
    vehicle.Start();
}





