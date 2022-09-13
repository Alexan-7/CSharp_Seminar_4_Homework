// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе 452 -> 11, 9012 -> 12

Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

int Summa_tsifr (int number) 
{
    int DigitSum = 0;
    int digit = 0;    

    // Алгоритм "Вытянуть по одной цифре все цифры из числа" - было на семинаре
    while (number != 0)
    {                                      // 12345 1234 123 12 1 0
        digit = Math.Abs(number % 10);     // достать последнюю цифру
        Console.WriteLine(digit);          // можно закомментировать эту строку, чтобы не выводил цифры столбиком
        number = number / 10;              // оставить всё, кроме последней цифры
        DigitSum = DigitSum + digit;
    }
    return DigitSum;
}

Console.WriteLine($"Сумма цифр в числе {number} равна {Summa_tsifr (number)}");