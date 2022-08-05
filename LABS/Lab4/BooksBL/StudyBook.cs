using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksBL
{
    internal class StudyBook : Books
    {
        public string Subject { get; set; }
        public string Rating { get; set; }
        public override void BookGenreSpecificDetails()
        {
            Console.WriteLine($"\nEnter the name of the book you'd like to buy.\n");
            Bname = Console.ReadLine();
            if (Bname == "Class 10th NCERT Mathematics")
            {
                Subject = "Mathematics";
                Rating = "5";
                Bprice = new Random().Next(100, 1000);
                Bpageno = new Random().Next(100, 1000);
            }

            Console.WriteLine($"\nThis book is of {Subject} and people have rated it {Rating} out of 5!\n");
        }
        public override void BookDetails()
        {
            Console.WriteLine($"\nBook Details are as follows:\n1) Name : {Bname}\n2) Price : {Bprice}\n3) Subject : {Subject}\n4) Page Number : {Bpageno}\n5) Rating : {Rating}/5\n");
        }
    }
}
