using System;

namespace Delegates
{
    class Program
    {
        //Declaration
        delegate void Compute(int n1, int n2);
        delegate void Manager(string[] tasks);
        static void Main()
        {
            //instantiated
            Manager mgrHarsh = new Manager(devParth);
            mgrHarsh += testerJanani;
            mgrHarsh += deployParikshit;
            //Invocation
            Console.WriteLine("Requesting client to add tasks (,) separated");
            var clientInput = Console.ReadLine();
            //Delegate the tasks to Developer, tester and deployer
            mgrHarsh(clientInput.Split(','));
        }

        private static void deployParikshit(string[] tasks)
        {
            string isCompleted = "Completed";
            foreach (var item in tasks)
            {
                Console.WriteLine($"Deployemnt of Task {item} is {isCompleted}");
                if(isCompleted == "Completed")
                {
                    isCompleted = "In Progress";
                }
                else
                {
                    isCompleted = "Completed";
                }
            }
        }

        private static void testerJanani(string[] tasks)
        {
            string isCompleted = "Completed";
            foreach (var item in tasks)
            {
                Console.WriteLine($"Testing of Task {item} is {isCompleted}");
                if (isCompleted == "Completed")
                {
                    isCompleted = "In Progress";
                }
                else
                {
                    isCompleted = "Completed";
                }
            }
        }

        private static void devParth(string[] tasks)
        {
            string isCompleted = "Completed";
            foreach (var item in tasks)
            {
                Console.WriteLine($"Development of Task {item} is {isCompleted}");
                if (isCompleted == "Completed")
                {
                    isCompleted = "In Progress";
                }
                else
                {
                    isCompleted = "Completed";
                }
            }
        }

        private static void SimpleDelegate()
        {
            //Instantiate Delegate
            Compute calculator = new Compute(Add);
            calculator += Sub;
            calculator += Mul;
            calculator += Div;

            //Invocation
            calculator(200, 100);
        }

        private static void Add(int n1, int n2)
        {
            Console.WriteLine($"Addition of {n1} and {n2} is {n1 + n2}");
        }
        private static void Sub(int n1, int n2)
        {
            Console.WriteLine($"Subtract of {n1} and {n2} is {n1 - n2}");
        }
        private static void Mul(int n1, int n2)
        {
            Console.WriteLine($"Multiplication of {n1} and {n2} is {n1 * n2}");
        }
        private static void Div(int n1, int n2)
        {
            Console.WriteLine($"Division of {n1} and {n2} is {n1 / n2}");
        }
    }
}