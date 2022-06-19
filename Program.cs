Console.WriteLine("Write the number");
int number = Convert.ToInt32(Console.ReadLine());
int num = 0;
for (int i = 1; i <= number; i++)
{
    int remainder = number % i;
    if (remainder == 0)
    {
        num++;
    }
}
    if (num == 2)
    {
        Console.WriteLine("Number is : Prime number");
    }
    else
    {
        Console.WriteLine("Number is : not a Prime number");
    }

    


