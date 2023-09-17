using System;
using System.Security.Cryptography;

string town = Console.ReadLine();
double sells = double.Parse(Console.ReadLine());
double result = 0.00;

if (town != "Sofia" && town != "Varna" && town != "Plovdiv" || sells <= 0)
{
    Console.WriteLine("error");
    return;
}


switch (town)
{
	case "Sofia":
		if (sells >= 0 && sells <= 500)
		{
			result = sells * 0.05;
		}
		else if (sells > 500 && sells <= 1000)
		{
			result = sells * 0.07;
		}
		else if (sells > 1000 && sells <= 10000)
		{
			result = sells * 0.08;
		}
		else if (sells > 10000)
		{
			result = sells * 0.12;
		}
		else
		{
            Console.WriteLine("error");
            return;
        }
        Console.WriteLine($"{result:F2}");

        break;
	case "Varna":
        if (sells >= 0 && sells <= 500)
        {
            result = sells * 0.045;
        }
        else if (sells > 500 && sells <= 1000)
        {
            result = sells * 0.075;
        }
        else if (sells > 1000 && sells <= 10000)
        {
            result = sells * 0.1;
        }
        else if (sells > 10000)
        {
            result = sells * 0.13;
        }
        else
        {
            Console.WriteLine("error");
            return;
        }
        Console.WriteLine($"{result:F2}");

        break;

    case "Plovdiv":
        if (sells >= 0 && sells <= 500)
        {
            result = sells * 0.055;
        }
        else if (sells > 500 && sells <= 1000)
        {
            result = sells * 0.08;
        }
        else if (sells > 1000 && sells <= 10000)
        {
            result = sells * 0.12;
        }
        else if (sells > 10000)
        {
            result = sells * 0.145;
        }
        else
        {
            Console.WriteLine("error");
            return;
        }
        Console.WriteLine($"{result:F2}");
        break;

}

