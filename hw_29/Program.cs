// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

Console.WriteLine("Введите 8 чисел через пробел");
string abcdefgh = Console.ReadLine()!;
string[] parts = abcdefgh.Split(' ');

int [] CreateArray (int size) // функция создания массива
{    
    int[] array = new int[size];  // объявляем массив
    for (int i = 0; i < size; i++)  // сделать 8 раз  (для i от 0 до 7)
    {
        array[i] = int.Parse(parts[i]);
    }
    return array;
}

void PrintArray (int[] arra) // функция вывода массива на экран
{
    Console.Write($"[{string.Join(", ", arra)}]");
}

PrintArray(CreateArray(8)); // Функции СОЗДАТЬ и ПЕЧАТАТЬ объединяем в одну строку