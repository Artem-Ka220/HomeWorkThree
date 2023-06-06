//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Enter a five-digit number: ");
int enterNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number {enterNumber}");

findPalindrom(enterNumber);

void findPalindrom(int number)
{
    int lastNumber = number % 10;

    int punaltimateNumber = (number % 100) / 10;

    int secondNumber = (number / 1000) % 10;

    int firstNumber = number / 10000;

    if (firstNumber == lastNumber && secondNumber == punaltimateNumber)
    {
        Console.Write("The entered number is a palindrom.");
    }
    else
    {
        Console.Write("The entered number is not a palindrom.");
    }
}