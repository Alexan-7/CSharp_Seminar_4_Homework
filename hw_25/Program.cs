// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B (как сумма цифр E:\CSharp_Seminar4\01)

int Exponent(int basel, int degree) // Процедурная декомпозиция - мегаполезная практика
{
    int total = 1;
    for (int i = 1; i <= degree; i++)
    {
        total = basel * total;
    }
    return total;
}

Console.Write("Введите основание степени: ");
int basel = int.Parse(Console.ReadLine()!);

Console.Write("Введите показатель степени: ");
int degree = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{degree}-я степень числа {basel} - это {Exponent(basel, degree)}");