Console.WriteLine("Write a number ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 0;
while (number > 0)
{
        int remainder = number % 10;
       num = num*10 + remainder;
        number = number / 10; 
}
Console.WriteLine(num);