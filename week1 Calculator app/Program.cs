// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;

calculatorapp();
void calculatorapp()
{

    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    int Choice = 0;

    Console.WriteLine("type in the first number followed by the enter key");
    firstnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("type in the first number followed by the enter key");
    secondnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose a number from the following list");
    Console.WriteLine("1-Add");
    Console.WriteLine("2-Subtract");
    Console.WriteLine("3- Divide");
    Console.WriteLine("4- Multiply");

    Choice = Convert.ToInt32(Console.ReadLine());

    result = firstnumber + secondnumber;
    Console.WriteLine("Adding {0} and {1} to give answer {2}", firstnumber, secondnumber, result);
    Console.ReadKey();

    if (Choice == 1)
    {
        result = firstnumber + secondnumber;
        Console.WriteLine($"Adding {firstnumber} and {secondnumber} equals {result} ");
    }
    else if (Choice == 2)
    {
        result = firstnumber - secondnumber;
        Console.WriteLine($"Subtracting  {firstnumber} and {secondnumber} equals {result} ");

    }
    else if (Choice == 3)
    {
        result = firstnumber / secondnumber;
        Console.WriteLine($"Dividing {firstnumber} and {secondnumber} equals {result} ");
    }
    else if (Choice == 4)
    {
        result = firstnumber * secondnumber;
        Console.WriteLine($"Multiplying {firstnumber} and {secondnumber} equals {result} ");
    }
    else
    {
        Console.WriteLine("you di not select a valid number between 1 to 4");
    }
}