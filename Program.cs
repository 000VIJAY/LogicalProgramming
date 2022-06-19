Console.WriteLine("Welcome to logical programming problem");
Console.WriteLine("Write the number whose fibonacci series wants to know  ");

int num = Convert.ToInt32(Console.ReadLine());
int numOne = 0;
Console.WriteLine("num : " +numOne);
int numTwo = 1;
Console.WriteLine("num : "+numTwo);
int numThree;
for (int i = 2; i < num; i++)
{
    numThree = numOne + numTwo;
        Console.WriteLine("num : " + numThree);
    numOne = numTwo;
    numTwo = numThree;
}

