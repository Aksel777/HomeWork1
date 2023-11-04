Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());


switch(number)
{
    case 1:
    Console.WriteLine("x(>0) y(>0)");
    break;
    case 2:
    Console.WriteLine("x(<0) y(>0)");
    break;

    case 3:
    Console.WriteLine("x(<0) y(<0)");
    break;

    case 4:
    Console.WriteLine("x(>0) y(<0)");
    break;

    default:
    Console.WriteLine("uncorrected value");
    break;
}
