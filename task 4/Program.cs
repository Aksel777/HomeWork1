Console.WriteLine("enter 1st number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter 2nd number");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("enter 3rd number");
int number3 = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

if(number1 > number2 && number1 > number3)
{
    Console.WriteLine("max"+number1);
}
if(number2 > number1 && number2 > number3)
{
    Console.WriteLine("max"+number2);
}
if(number3 > number1 && number3 > number2)
{
    Console.WriteLine("max"+number3);
}

