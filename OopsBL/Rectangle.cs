using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public Rectangle(float Length, float Breadth) //Constructor Overloading
        {
            length = Length;
            breadth = Breadth;
        }
        public float length { get; set; }
        public float breadth { get; set; }
        public virtual float calcArea ()
        {
            return length * breadth;
        }
        public override void Draw(params string[]? str)
        {
            Console.WriteLine($"{Name} is drawn with Length of {length} and Breadth of {breadth}");
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Details of the shape: \nLength - {length} cms\nBreadth - {breadth}");
        }
    }
}
