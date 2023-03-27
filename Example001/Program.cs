Main();

void Main() 
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = System.Console.ReadLine();
        switch (a) 
        {
            case "y": task1(); break;
            case "n": Work = false; break;
        }

    }
}


// новая задача
int i = GetRandom();
System.Console.WriteLine(i);
System.Console.WriteLine(RemoveSecondDigit(i));

int GetRandom()
{
    return new Random().Next(100, 1000);
}

int RemoveSecondDigit(int number)
{
    int lastNumber = number % 10;
    int firstNumber = number / 100;
    int result = firstNumber*10+lastNumber;
    return result;
}