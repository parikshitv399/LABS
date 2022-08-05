//Customer inputs on console the name of the project
using OopsBL;

Console.WriteLine("Welcome to the Shape Shop!");
Console.WriteLine("\nEnter the shape you wish to purchase");
string custInput = Console.ReadLine();
Console.WriteLine($"\nPlease add additional specifications for the shape you wish to purchase with ',' separator\n");

//A function will call the vendor viz. OopsBL to give the shape object
Shape sh = Shape.GetShapeObject(custInput);

//Vendor calls .Draw()
sh.Draw(Console.ReadLine());