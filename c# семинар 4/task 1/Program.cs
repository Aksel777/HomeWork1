int ReadNumber()
{
    Console.WriteLine ("enter number");
    return Convert.ToInt32 (Console.ReadLine());
}

int Count (int A)

{
    int i = 0;
    while (A>0)
    {
        A=A/10;
        i = i + 1;
    }
    return i;
}


int number = ReadNumber();
Console.WriteLine ($"{Count (number)}");