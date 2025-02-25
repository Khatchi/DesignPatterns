// Encapsulation

using DesignPatterns.src.OopPrinciple.Encapsulation;
using DesignPatterns.src.OopPrinciple.Abstraction;
// using DesignPatterns.src.OopPrinciple.Inheritance;
// using DesignPatterns.src.OopPrinciple.Polymorphism;
using System.ComponentModel;
using DesignPatterns.src.OopPrinciple.Coupling;
using DesignPatterns.src.OopPrinciple.Composition;
// using DesignPatterns.src.SOLID.L;
using System.Drawing;
using DesignPatterns.src.SOLID.L;
using System.Buffers;

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

System.Console.WriteLine("===================================");



// SOLID PRINCIPLE STARTS HERE

/*
S: ==> Single Responsibility Principle (SRP)
- A class should have only one reason to change, meaning that it should have only one
responsibility or purpose.
*/


/*
O: ==> Open/Close Principle (OCP)
- Software entities (classes, modules, functions, etc.) should be open for
extension but closed for modification.
*/


/*
L: ==> Liskov Substitution Principle (LSP)
- Objects of a superclass should be replaceable with objects of its sybclass without
affecting the correctness of the program.
*/

// var rect = new Rectangle();
// rect.Height = 10;
// rect.Width = 5;
// Console.WriteLine("Expected area = 10 * 5 = 50");
// // Console.WriteLine("Calculated area = " + rect.Area);

// Shape rectangle = new Rectangle {Width = 5, Height = 4};
// Console.WriteLine($"Area of rectangle: {Rectangle.Area}");

Shape square = new Square {SideLength = 5};
Console.WriteLine($"Area of square: {square.Area}");