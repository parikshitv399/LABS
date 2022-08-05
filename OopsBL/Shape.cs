using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract void Draw(params string[]? str);
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"The shape is {Name}");
        }

        public static Shape GetShapeObject(string? custInput)
        {
            switch (custInput.ToLower())
            {
                case "rectangle":
                    return new Rectangle() { Name = custInput };
                case "square":
                    return new Square() { Name = custInput };
                case "rhombus":
                    return new Rhombus() { Name = custInput };
                default:
                    throw new Exception("Invalid shape input");
            }
        }
    }
}
