// Nested switch Statement

using System;

int a = 100;
int b = 200;

switch (a)
{
    case 100:
        Console.WriteLine("Your Value is {0}", a);
     

        switch (b)
        {
            case 200:
                Console.WriteLine("Your Value is {0}",b);
        break;  
        }
        break;


    default: Console.WriteLine("invalid");
        break;
    
}


