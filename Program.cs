Console.WriteLine("Write the number");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i < number; i++)  //i act as a divisor
{
    int remainder = number % i;
   
    if (remainder == 0)
    {
        sum = sum + i;
        Console.WriteLine( "sum :" +sum );

    }
}
    if (sum == number)
    {
        Console.WriteLine("number is perfect");
    }
    else
    {
        Console.WriteLine("number is not perfect");
    }
