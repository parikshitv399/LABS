using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public class Rhombus : Rectangle
    {
        public float Angle { get; set; }
        //Shadowing == Hiding
        public override float calcArea()
        {
            return (float)(length * breadth * Math.Sin(Angle));
        }
        public override void Draw(params string[]? str)
        {
            Console.WriteLine($"Successfully drawn a {Name}");
        }
    }
}
