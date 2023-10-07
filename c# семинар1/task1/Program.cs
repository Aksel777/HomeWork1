Console.WriteLine("enter 1st number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter 2nd number");
int number2 = int.Parse(Console.ReadLine());

if(number1==number2*number2 || number2==number1*number1)

{
    Console.WriteLine ("its true");
}
else
{
    Console.WriteLine ("its false");
}
