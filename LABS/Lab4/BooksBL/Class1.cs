namespace BooksBL
{
    public abstract class Books
    {
        public string Bname { get; set; }
        public string Btype { get; set; }
        public int Bprice { get; set; }
        public int Bpageno { get; set; }
        public static Books GetBookChoice(string? custInput)
        {
            switch (custInput.ToLower())
            {
                case "story":
                    return new StoryBook() { Bname = custInput };
                case "study":
                    return new StudyBook() { Bname = custInput };
                default:
                    throw new Exception("Invalid Book Type");
            }
        }
        public virtual void BookDetails()
        {
            Console.WriteLine($"{Bname} is a {Btype} book of Rs.{Bprice}. It has {Bpageno} pages.");
        }
        public abstract void BookGenreSpecificDetails();
    }
}