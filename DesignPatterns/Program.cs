// Encapsulation

using DesignPatterns.src.OopPrinciple.Encapsulation;
using DesignPatterns.src.OopPrinciple.Abstraction;
// using DesignPatterns.src.OopPrinciple.Inheritance;
// using DesignPatterns.src.OopPrinciple.Polymorphism;
using System.ComponentModel;
using DesignPatterns.src.OopPrinciple.Coupling;
using DesignPatterns.src.OopPrinciple.Composition;

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

// // Polymorphism-- ability of an object to take many forms.

// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
// vehicles.Add(new Motorcycle { Brand = "Harley", Model = "Sportster", Year = 2021 });

// // Vehicle inspection

// foreach (var vehicle in vehicles)
// {
//     vehicle.Start();
// }

// System.Console.WriteLine("===================================");

// Coupling ==> degree of dependency btw diff classes

// var order = new Order(new EmailSender());
var order = new Order(new SmsSender());
order.PlaceOrder();

System.Console.WriteLine("===================================");


// Composition

// involves creating a complex objects by combining simpler objects or components.

var car = new Car();
car.Startcar();




