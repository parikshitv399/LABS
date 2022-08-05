using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpBL
{
    public class A
    {
        public virtual void Call()
        {
            Console.WriteLine("In 'A'");
        }
    }
    public class B : A
    {
        public new void Call()
        {
            Console.WriteLine("I'm in B");
            base.Call();
        }
    }
    public class C : B
    {
        public void Call()
        {
            Console.WriteLine("I'm in C");
            base.Call();
        }
    }
}
