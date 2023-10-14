// Ternay Operator



int a = 20, b = 11;

var result = a > b ? "a is greater than b" : "b is greater than a";

Console.Write(result);
Console.WriteLine();

Console.WriteLine("Example-2");
int x = 90, y = 50;
var result2 = x > y ? "x is greater than y" : "y is greater than x";
Console.WriteLine(result2);
Console.WriteLine();

Console.WriteLine("Example-3");

Console.WriteLine("Enter Your FirstNumber::");
int firstNumber=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Your SecondNumber");
int secondNumber = int.Parse(Console.ReadLine());

var result3 = firstNumber > secondNumber ? "First Number is greater than second Number" : "Second is greater than first";

Console.WriteLine(result3);