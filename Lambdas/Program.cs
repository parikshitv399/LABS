using System;
using System.Collections.Generic;

class Program
{
    delegate int Compute(int x, int y);
    delegate void Print(string msg);
    delegate List<string> GetData(string csvMsg);
    static void Main()
    {
        Func<int,int,int> Add = (x, y) => x + y;
        Action<string> Print = (msg) =>
                                        {
                                            string result = $"Welcome " + msg;
                                            Console.WriteLine(result);
                                        };
        Predicate<string> isValidEmail = (email) => email.Contains("@kpmg.com");
        //Invocation
        int res = Add(100, 200);
        Print(res.ToString());
        bool isValid = isValidEmail("abc@kpmg.com");
        Print(isValid.ToString());
        //BitComplexLambda();
        //CalcAndPrint();
    }
    private static int Add(int a, int b) => a + b;
    private static int Sub(int a, int b) => a - b;
    public string Id => "KPMG-" + Guid.NewGuid();
    private static void BitComplexLambda()
    {
        GetData list1 = new GetData((str1) => new List<string>() { str1 });
        list1 += ((str2) => new List<string>() { str2 });
        List<string> finalList = list1("Training session");
        foreach (var item in finalList)
        {
            Console.WriteLine(item);
        }
    }

    private static void CalcAndPrint()
    {
        //instantiation
        Compute calc = new Compute((x, y) => x + y);
        calc += (n1, n2) => n1 - n2;
        calc += (n1, n2) => n1 * n2;
        calc += (n1, n2) => n1 / n2;

        //instantiation
        // string msg1;
        //string msg2 = "developer on this project";
        Print message = new Print(msg1 => Console.WriteLine(msg1));
        message += (msg2) => Console.WriteLine($"Nanna munna rahi hu");

        message("Parikshit is the");
    }
}