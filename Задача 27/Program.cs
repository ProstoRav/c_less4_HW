/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int SumDigits(int number)
{
    int result = 0;
    while ((number > 0) || (number < 0))
    {
        result = result + (number % 10);
        number = number / 10;
    }
    result = Math.Abs(result);
    return result;
}
int number;
Console.Write($"Введите число: ");
bool success = int.TryParse(Console.ReadLine()!, out number);
if (success)
    {
        Console.Write($"Сумма цифр числа {number} равна {SumDigits(number)}");
    }
else
    {
        Console.WriteLine($"Пожалуйста введите целое число");
    }