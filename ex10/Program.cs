Console.WriteLine("Enter a three-digit number");
int N = Convert.ToInt32(Console.ReadLine());
int M = ( N%100 - N%10 ) /10;
Console.WriteLine (M);

