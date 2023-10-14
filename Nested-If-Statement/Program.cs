

Console.WriteLine("Enter Your Five Numbers::");

int i=int.Parse(Console.ReadLine());
int j=int.Parse(Console.ReadLine());
int k=int.Parse(Console.ReadLine());
int l=int.Parse(Console.ReadLine());
int m=int.Parse(Console.ReadLine());

if (i == 100)
{
    if (j == 200)
    {
        if (k == 300)
        {
            if (l == 400)
            {
                if (m == 500)
                {
                    Console.WriteLine("Value of i=100");
                    Console.WriteLine("value of j=200");
                    Console.WriteLine("Value of k=300");
                    Console.WriteLine("value of l=400");
                    Console.WriteLine("Value of m=500");    

                }
                Console.WriteLine("Exact Value of i {0}", i);
            }
        }
    }
}

