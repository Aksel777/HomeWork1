// Напишите программу, которая на вход принимает число и выдает его квадрат

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("введите число");
string numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
int result = numberInt * numberInt;
Console.WriteLine(result);

