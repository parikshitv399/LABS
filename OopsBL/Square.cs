using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public class Square : Rectangle
    {
        public Square()
        {

        }
        public Square(float side) : base(side, side) //Constructor Overloading
        {
            
        }
        public override float calcArea()
        {
            Console.WriteLine($"This area is calculated in collaboration with Rectangle Class\n");
            return base.calcArea();
        }
        public override void Draw(params string[]? str)
        {
            Console.WriteLine($"Using modern equipments, {Name} is drawn");
        }
    }
}
