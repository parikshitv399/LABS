using System;

namespace DelegatesLab
{
    class Program
    {
        delegate void supportEngg(string SupportRequest);
        static void Main()
        {
            supportEngg ABC = new supportEngg(TeamA);
            ABC += TeamB;
            Console.WriteLine("Please describe the issue.");
            string supportReq = Console.ReadLine();
            ABC(supportReq);
        }
        private static void TeamA(string str)
        {
            Console.WriteLine("Research and diagnose is complete.");
        }
        private static void TeamB(string str)
        {
            Console.WriteLine("Troubleshoot is complete.");
        }
    }
}