// Console.WriteLine("enter a number");
// int number = int.Parse(Console.ReadLine());

// int negative = -number;

// while (negative <= number)
// {
// Console.WriteLine("hui" + negative);
// negative ++;
// }


Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine());

if (number>=100 && number<1000)
{
    Console.WriteLine("result is"+number%10);
}
else
{
    Console.WriteLine("false number");
}