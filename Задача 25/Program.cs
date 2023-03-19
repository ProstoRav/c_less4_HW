/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int mathbase, exponent;
Console.Write($"Введите основание степени: ");
int.TryParse(Console.ReadLine()!, out mathbase);
Console.Write($"Введите натуральную степень: ");
int.TryParse(Console.ReadLine()!, out exponent);

int Exponentiation(int mathbase, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result = result * mathbase;
    }
    return result;
}

bool VerifyExponent(int exponent)
{
    
    if (exponent <= 1)
    {
        Console.Write($"Вы ввели не натуральную степень");
        return false;
    }
    return true;
}

if (VerifyExponent(exponent))
{
    Console.Write($"{mathbase} в степени {exponent} равно {Exponentiation(mathbase, exponent)}");
}