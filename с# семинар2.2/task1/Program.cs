// Console.WriteLine("enter number 1");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("enter number 2");
// int number2 = int.Parse(Console.ReadLine());
// if (number1 % number2 == 0)
// {
//     Console.WriteLine ("кратно");
// }
// else
// {
//     Console.WriteLine ($"не кратно, остаток {number1%number2}");
// }

// Console.WriteLine("enter number");
// int number = int.Parse(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine ("кратно");
// }
// else
// {
//     Console.WriteLine ("не кратно");
// }


Console.WriteLine("enter number1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter number2");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2*number2 || number2 == number1*number1)
{
    Console.WriteLine ("true");
}
else
{
    Console.WriteLine ("false");
}