/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[]Massive()
{
    int length;
    Console.Write($"Введите количество элементов массива: ");
    int.TryParse(Console.ReadLine()!, out length);
    if (length < 0)
        {
            Console.WriteLine($"Вы ввели не натуральное число, пожалуйста перезапустите программу");
            Environment.Exit(0);
        }
    int[]array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ", i + 1);
        bool success = int.TryParse(Console.ReadLine()!, out array[i]);
        if (success)
            {
            
            }
        else
            {
                Console.WriteLine($"Программа принимает только целые числа в качестве элементов массива, пожалуйста перезапустите программу");
                Environment.Exit(0);
            }
    }
    return array;
}

string PrintMassive(int[] Massive)
{
    string print = string.Join(",", Massive);
    return print;
}

Console.WriteLine($"{PrintMassive(Massive())}");