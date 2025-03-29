using System.Runtime.InteropServices.ComTypes;

double num1 = 0; double num2 = 0;
Console.WriteLine("Console Calculator in c#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Type a number, and then press Enter");
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type another number, and then press Enter");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose an option from the following list: ");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

switch (Console.ReadLine())
{
    case "a":
        double add = num1 + num2;
        string result_a = add.ToString("0.00");
        Console.WriteLine($"Your result: {num1} + {num2} = " + (result_a));
        break;
    case "s":
        double sub = num1 - num2;
        string result_s = sub.ToString("0.00");
        Console.WriteLine($"Your result: {num1} - {num2} = " + (result_s));
        break;
    case "m":
        double mul = num1*num2;
        string result_m = mul.ToString("0.00");
        Console.WriteLine($"Your result: {num1} * {num2} = " + (result_m));
        break;
    case "d":
        while(num2==0)
        {
            Console.WriteLine("Enter a non-zero number");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        double div = num1/num2;
        string result_d = div.ToString("0.00");
        Console.WriteLine($"Your result: {num1} / {num2} = " + (result_d));
        break;
}
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();


