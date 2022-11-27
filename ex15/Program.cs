Console.WriteLine("Enter a week day from 1 to 7");

int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 6:
        Console.WriteLine("Yes");
        break;
    case 7:
        Console.WriteLine("Yes");
        break;
    default:
        Console.WriteLine("No");
        break;
}