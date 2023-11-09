// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("enter positive number");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (a>0)
{
    int num = a%10;
    a = a/10;
    sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);



