using BooksBL;

Console.WriteLine($"\nWelcome to Book Store!\n");
Console.WriteLine($"\nEnter the type of book you wish to purchase\n");
string custInput = Console.ReadLine();

Books bk = Books.GetBookChoice(custInput);
bk.BookGenreSpecificDetails();
Console.WriteLine($"\nNow we will print the book general details!\n");
bk.BookDetails();
