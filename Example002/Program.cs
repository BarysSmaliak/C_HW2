//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

int num = ReadNumber("a");
int ordher = FindOrdherOfNumber(num);
int ThirdNum = FindThirdNumber(ordher, num);
Console.WriteLine(ThirdNum);

int FindThirdNumber (int b, int number)
{
    int count = 0;
    while (count < b - 3)
    {
        number = number / 10;
        count++;
    }
    number = number % 10;
    return number;
}

int FindOrdherOfNumber (int a)
{
    int i = 0;
    while (a != 0)
    {
        a = a / 10;
        i++;
    }
    return i;
}

int ReadNumber (string argument)
{
    int number;
    Console.WriteLine($"Input number (argument):");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number");
    }
    return number;
}