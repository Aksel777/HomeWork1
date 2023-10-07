Console.WriteLine("enter 1st number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter 2nd number");
int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("max"+number1);
}
else
{
    Console.WriteLine("max"+number2);
}