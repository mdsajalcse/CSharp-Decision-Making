// Simple project on Switch Case

Console.WriteLine("Welcome to Our Simple Electronic Shop!");
Console.WriteLine("Please Choose You Want To Buy..");

Console.WriteLine("1. Laptop 2. Desktop 3. Mobile 4. Printer 5. Scanner 6. AC");

int choosenProduct=int.Parse(Console.ReadLine());


switch (choosenProduct)
{
    case 1:
        Console.WriteLine("you select Laptop..");
        Console.WriteLine("Which Laptop You Want to Buy..");
        Console.WriteLine("1.HP 2.DELL 3.APPLE 4.SAMSUNG 5.BENQ 6.LENEVO:");
        int laptopModel=int.Parse(Console.ReadLine());

        switch (laptopModel)
        {
            case 1:
                Console.WriteLine("HP");
                break;
            case 2:
                Console.WriteLine("DELL");
                break;
            case 3:
                Console.WriteLine("APPLE");
                break;
            case 4:
                Console.WriteLine("SAMSUNG");
                break;
            case 5:
                Console.WriteLine("BENQ");
                break;
            case 6:
                Console.WriteLine("LENEVO");
                break;
            default:
                Console.WriteLine("You Choice Invalid");
                break;
        }

        break;
    case 2:
        Console.WriteLine("You Select Desktop..");
        Console.WriteLine("Which Desktop You Want to Buy..");
        Console.WriteLine("1.HP 2.DELL 3.APPLE 4.SAMSUNG 5.BENQ 6.LENEVO:");
        int desktopModel = int.Parse(Console.ReadLine());

        switch (desktopModel)
        {
            case 1:
                Console.WriteLine("You Selected HP");
                Console.WriteLine("How Much Processor You Choose");
                Console.WriteLine("1.Corei7 2.Corei5 3.Corei3");
                int processorModel = int.Parse(Console.ReadLine());

                switch (processorModel)
                {
                    case 1:
                        Console.WriteLine("Great! You Choose Corei7");
                        Console.WriteLine("Are You Ready To Buy?");
                        Console.WriteLine("1.BUY 2.Cancel");
                        int purchaseCancel=int.Parse(Console.ReadLine());
                        switch (purchaseCancel)
                        {
                            case 1:
                                Console.WriteLine("Thanks For Buying Our Product");
                                break;
                                case 2:
                                Console.WriteLine("You Cancel Your Buying! please try again");
                                break;
                            default: Console.WriteLine("Your Choice is Invalid");
                                break;
                        }
                        break;
                }

                break;
            case 2:
                Console.WriteLine("DELL");
                break;
            case 3:
                Console.WriteLine("APPLE");
                break;
            case 4:
                Console.WriteLine("SAMSUNG");
                break;
            case 5:
                Console.WriteLine("BENQ");
                break;
            case 6:
                Console.WriteLine("LENEVO");
                break;
            default:
                Console.WriteLine("You Choice Invalid");
                break;
        }
        break;
    case 3:
        Console.WriteLine("You Select Mobile..");
        break;
    case 4:
        Console.WriteLine("You Select Printer..");
        break;
    case 5:
        Console.WriteLine("You Select Scanner..");
        break;
    case 6:
        Console.WriteLine("You Select AC..");
        break;

}
