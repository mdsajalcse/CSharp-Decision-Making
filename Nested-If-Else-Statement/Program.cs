

//Grading System

Console.WriteLine("Enter Your CGPA");
double cgpa=double.Parse(Console.ReadLine());



if (cgpa == 4.00)
{
    Console.WriteLine("Your CGPA is {0} & Your Grade is A+", cgpa);
}
else if (cgpa >=3.75 && cgpa < 4.00)
{
    Console.WriteLine("Your CGPA is {0} & Your Grade is A", cgpa);

}
else if(cgpa==3.50 && cgpa < 3.75)
{
    Console.WriteLine("Your CGPA is {0} & Your Grad is A-",cgpa);

}
else if(cgpa==3.00 && cgpa < 3.5)
{
    Console.WriteLine("Your CGPA is {0} & Your Grade is B", cgpa);

}
else if (cgpa == 2.75 && cgpa < 3.0)
{
    Console.WriteLine("Your CGPA is {0} & Your Grade is B-", cgpa);

}
else if (cgpa == 2.00 && cgpa < 2.75)
{
    Console.WriteLine("Your CGPA is {0} & Your Grade is C", cgpa);

}
else if (cgpa == 1.00 && cgpa < 2.00)
{
    Console.WriteLine("Your CGPA is {0} & Your Grade is D", cgpa);

}
else
{
    Console.WriteLine("Sorry You have Failed");
}