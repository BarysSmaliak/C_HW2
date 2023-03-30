Main();

void Main ()
{
   bool Work = true;
    while (Work)
    {
        Console.WriteLine("Solving the task? y/n");
        string a = Console.ReadLine();
        switch (a)
        {
            case "y": SecondDigit(); break;
            case "n": Work = false; break;
        }
    }
}

int ThreeDigitNumber (string argument)
{
    int number;
    Console.WriteLine($"Input three-digit number (argument):");
    while (!int.TryParse(Console.ReadLine(), out number) || Math.Abs(number)/1000>=1 || Math.Abs(number)/100 <1)
    {
        Console.WriteLine("It's not a three-digit number! Enter another number:");
    }
    return number;
}

void SecondDigit ()
{
    int number = ThreeDigitNumber("a");
    int FirstAndSecondDigit = number /10;
    int SecondDigit = FirstAndSecondDigit % 10;
    Console.WriteLine(SecondDigit);
}