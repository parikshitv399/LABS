// See https://aka.ms/new-console-template for more information
#region Hello World
Console.WriteLine("Hello, World!");
#endregion

#region Variable Declaration
int num1 = 100;
int num2 = 200;
#endregion

#region Addition
//String Interpolation - Concatenate variable value to msg
Console.WriteLine($"The sum of {num1}, {num2} = {num1 + num2}");
Console.WriteLine($"The sum of 100, 200 is {Add(100, 200)}");
static Int32 Add(Int32 num1, Int32 num2)
{
    return num1 + num2;
}
//---------------------------------------------------------------------
#endregion

#region Subtract
Console.WriteLine("Enter the value of num1: ");
string strnum1 = Console.ReadLine();
Console.WriteLine("Enter the value of num2: ");
string strnum2 = Console.ReadLine();
num1 = Convert.ToInt32(strnum1);
num2 = Convert.ToInt32(strnum2);
Sub(num1, num2);
static Int32 Sub(Int32 num1, Int32 num2)
{
    return num1 - num2;
}
//----------------------------------------------------------------------
#endregion

#region Multiplication
Console.WriteLine("Enter the value of num1: ");
string strmul1 = Console.ReadLine();
Console.WriteLine("Enter the value of num2: ");
string strmul2 = Console.ReadLine();
num1 = Convert.ToInt32(strmul1);
num2 = Convert.ToInt32(strmul2);
Mul(num1, num2);
static Int32 Mul(Int32 num1, Int32 num2)
{
    return num1 * num2;
}
//----------------------------------------------------------------------
#endregion

#region Division
Console.WriteLine("Enter the value of num1: ");
string strdiv1 = Console.ReadLine();
Console.WriteLine("Enter the value of num2: ");
string strdiv2 = Console.ReadLine();
num1 = Convert.ToInt32(strdiv1);
num2 = Convert.ToInt32(strdiv2);
Div(num1, num2);
static float Div(Int32 num1, Int32 num2)
{
    return num1 / num2;
}
#endregion
//----------------------------------------------------------------------
Console.WriteLine($"Calling Increment without a parameter : {Increment()}");
Console.WriteLine($"Calling Increment with a parameter: {Increment(100)}");
static Int32 Increment(Int32 num = 0) //Optional Parameter
{
    num += 1;
    num++;
    return num;
}
//----------------------------------------------------------------------
Console.WriteLine($"Is null, null empty? : {IsEmpty(null, null)}");
Console.WriteLine($"Is Parikshit, 100 empty? : {IsEmpty("Parikshit", 100)}");
static Boolean IsEmpty(string? str, int? num)//string Indication (str can accept null)
{
    return String.IsNullOrEmpty(str) || num == null;
}
//-----------------------------------------------------------------------
static string[] GetNames()
{
    //string[] names = new string[3];
    //names[0] = "Parikshit";
    //names[1] = "Rohit";
    //names[2] = "Anupma";
    string[] names = new string[] { "Parikshit", "Rohit", "Anupma" };
    return names;
}
Console.WriteLine($"Printing all names: ");
foreach (var item in GetNames())
{
    Console.WriteLine(item);
}
//-----------------------------------------------------------------------
static int[] GetNumbers()
{
    int[] nums = new int[] { 1, 2, 3 };
    return nums;
}
Console.WriteLine($"Printing all integers: ");
foreach (var item in GetNumbers())
{
    Console.WriteLine(item);
}
//-----------------------------------------------------------------------
static void GetWordCount(string[] strArray) //passing array as parameter
{
    Console.WriteLine($"strArray has {strArray.Length} items in it");
}
string sentenceParam = "Apple,Mango,Orange,Banana";
string[] resultStringArray = sentenceParam.Split(',');
GetWordCount(resultStringArray);
//-----------------------------------------------------------------------
static void CreateSentence(params string[] strs)
{
    string sentence = string.Empty;
    foreach (var item in strs)
    {
        sentence += $" {item}";
    }
    Console.WriteLine(sentence);
}
CreateSentence("Apple", "Orange", "Mango", "Guava");
Console.WriteLine("Enter the name: ");
string nameParam = Console.ReadLine();
CreateSentence("select * from emp", "where name =", nameParam);
//-----------------------------------------------------------------------
