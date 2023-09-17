using System;
using System.Globalization;

string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0.00;


if (fruit != "banana" && fruit != "apple" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes" && fruit!="orange")
{
    Console.WriteLine("error");
    return;
   
}
else if (day != "Monday" && day != "Tuesday" && day != "Thrusday" && day != "Wednesday" && day != "Friday" && day !="Saturday" && day !="Sunday") 
{
    Console.WriteLine("error");
    return;
    
}

if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
{
    if (fruit == "banana")
    {
        price = 2.50;
    }
    else if (fruit == "apple")
    {
        price = 1.20;
    }
    else if (fruit == "orange")
    {
        price = 0.85;
    }
    else if (fruit == "grapefruit")
    {
        price = 1.45;
    }
    else if (fruit == "kiwi")
    {
        price = 2.70;
    }
    else if (fruit == "pineapple")
    {
        price = 5.50;
    }
    else if (fruit == "grapes")
    {
        price = 3.85;
    }
   

    Console.WriteLine($"{price * quantity:F2}");

}
else if (day == "Saturday" || day == "Sunday")
	{
    if (fruit == "banana")
    {
        price = 2.70;
    }
    else if (fruit == "apple")
    {
        price = 1.25;
    }
    else if (fruit == "orange")
    {
        price = 0.90;
    }
    else if (fruit == "grapefruit")
    {
        price = 1.60;
    }
    else if (fruit == "kiwi")
    {
        price = 3.00;
    }
    else if (fruit == "pineapple")
    {
        price = 5.60;
    }
    else if (fruit == "grapes")
    {
        price = 4.20;
    }
    Console.WriteLine($"{price * quantity:F2}");
}


