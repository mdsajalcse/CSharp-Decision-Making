// See https://aka.ms/new-console-template for more information
//Nested Switch Statement

int number;
Console.WriteLine("Enter Your Number Between(1-5)");
number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1: Console.WriteLine("you Enter {0}", number);

        char color;
        Console.WriteLine("Enter Color R/G/B..");
        color = Console.ReadLine()[0];
        switch (color)
        {
            case 'R':
            case 'r':
                Console.WriteLine("You Have Chossen Red Color");
                break;
            case 'G':
            case 'g':
                Console.WriteLine("You Have Chosen Green Color");
                break;
            case 'B':
            case 'b':
                Console.WriteLine("You Have Chossen Black Color");
                break;
        }
        break;
    case 2:
        char CSE_meaning;
        Console.WriteLine("Enter Your CSE Letter:");
        CSE_meaning = Console.ReadLine()[0];
        switch (CSE_meaning)
        {
            case 'C':
                Console.WriteLine("C Meaning Computer");
                break;
            case 'S':
                Console.WriteLine("C Meaning Computer Science");
                break;
            case 'E':
                Console.WriteLine("C Meaning Computer Sciene & Engineering");
                break;
        }
        break;
    case 3: Console.WriteLine("You Select 3");
        break;
        case 4: Console.WriteLine("You Select 4");
        break;
        case 5: Console.WriteLine("you select 5");
        break;

    default:
        Console.WriteLine("invalid Choice");
        break;
}

   