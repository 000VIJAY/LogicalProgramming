Console.WriteLine("enter date");
int date = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter month");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter year");
int year = Convert.ToInt32(Console.ReadLine());


int y0 = year-(14 - month)/12;
int x = y0 + y0/4 - y0/100 + y0/400;
int a = (14 - month)/12;
int m0 = month + (12*a) -2;
int d0 = date + (x + 31)*(m0/12);
Console.WriteLine(d0 +  "- " +m0 + " - " +y0);
int d1 = d0 % 7;
switch(d1)
{
    case 0:
        Console.WriteLine("Sunday");
            break;
    case 1:
        Console.WriteLine("Monday");
            break;
    case 2:
        Console.WriteLine("Tuesday");
            break ;
    case 3:
        Console.WriteLine("Wednesday");
            break;
    case 4:
        Console.WriteLine("Thursday");
            break;
    case 5:
        Console.WriteLine("Friday");
            break;
    default:
        Console.WriteLine("Saturday");
            break;

}
switch (m0)
{
    case 1:
        Console.WriteLine("January");
            break;
    case 2:
        Console.WriteLine("February");
            break;
    case 3:
        Console.WriteLine("March");
            break;;
    case 4:
        Console.WriteLine("April");
            break;
    case 5:
        Console.WriteLine("May");
            break;
    case 6:
        Console.WriteLine("June");
            break;
    case 7:
        Console.WriteLine("july");
            break;
    case 8:
        Console.WriteLine("August");
            break;
    case 9:
        Console.WriteLine("Setember");
            break;
    case 10:
        Console.WriteLine("October");
            break;
    case 11:
        Console.WriteLine("November");
            break;
    default :
        Console.WriteLine("December");
            break;
}



