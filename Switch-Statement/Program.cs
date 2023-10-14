Console.WriteLine("Switch Statement");


Console.WriteLine("Enter Your Grade:");
char grade=char.Parse(Console.ReadLine());


switch (grade)
{
    case 'A':
        Console.WriteLine("Your Grade is A, Your GPA {0}",grade);
        Console.WriteLine("Excellent Result..");
        break;
    case 'B':
        Console.WriteLine("Your Grade is B, Your GPA {0}",grade);
        Console.WriteLine("Well Done");
        break;
    case 'C':
        Console.WriteLine("Your Grade is C , Your GPA {0}",grade);
        Console.WriteLine("Good Result");
        break;
    case 'D':
        Console.WriteLine("Your Grade is Pass {0}", grade);
        break;
        default: Console.WriteLine("Sorry You have Failed , Your Grade is {0}", grade);
        break;
}
