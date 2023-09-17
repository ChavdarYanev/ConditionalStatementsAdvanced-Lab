double time = double.Parse(Console.ReadLine());
string name = Console.ReadLine();

if (name == "Monday" || name == "Tuesday" || name == "Wednesday" || name == "Friday" || name == "Saturday" || name == "Thursday")
{
	if (time >=10 & time <=18)
	{
        Console.WriteLine("open");
    }
	else
	{
        Console.WriteLine("closed");
    }
}
else   
{
    Console.WriteLine("closed");
}
