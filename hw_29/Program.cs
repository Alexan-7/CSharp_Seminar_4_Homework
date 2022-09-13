// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

Console.WriteLine("Введите 8 чисел через пробел");
string abcdefgh = Console.ReadLine()!;
string[] parts = abcdefgh.Split(' ');
int ra = int.Parse(parts[0]);
int rb = int.Parse(parts[1]);
int rc = int.Parse(parts[2]);
int rd = int.Parse(parts[3]);
int re = int.Parse(parts[4]);
int rf = int.Parse(parts[5]);
int rg = int.Parse(parts[6]);
int rh = int.Parse(parts[7]);

int[] array = new int[8] {ra, rb, rc, rd, re, rf, rg, rh};  // объявляем массив

Console.Write($"[{string.Join(", ", array)}]");