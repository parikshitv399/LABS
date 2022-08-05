using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksBL
{
    internal class StoryBook : Books
    {
        public string Genre { get; set; }
        public string ReadType { get; set; }
        public override void BookGenreSpecificDetails()
        {
            Console.WriteLine($"\nEnter the name of the book you'd like to buy.\n");
            Bname = Console.ReadLine();
            if(Bname == "Harry Potter")
            {
                Genre = "Fiction";
                ReadType = "Engaging story and immersive experience";
                Bprice = new Random().Next(100, 1000);
                Bpageno = new Random().Next(100, 1000);
            }
            Console.WriteLine($"\nThis book is {Bname}. Its genre is {Genre} and people prefer to read it for its {ReadType}.\n");
        }
        public override void BookDetails()
        {
            Console.WriteLine($"\nBook Details are as follows:\n1) Name : {Bname}\n2) Price : {Bprice}\n3) Genre : {Genre}\n4) Number of pages : {Bpageno}\n5) Review : {ReadType}\n");
        }
    }
}
