//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter the number of the day of the week: ");
string DayOfTheWeek = Console.ReadLine();
switch (DayOfTheWeek)
{
case "1" : Console.WriteLine("Yes"); break;
case "2" : Console.WriteLine("Yes"); break;
case "3" : Console.WriteLine("Yes"); break;
case "4" : Console.WriteLine("Yes"); break;
case "5" : Console.WriteLine("Yes"); break;
case "6" : Console.WriteLine("No"); break;
case "7" : Console.WriteLine("No"); break;
default: Console.WriteLine("you're entering the wrong thing!"); break;
}
