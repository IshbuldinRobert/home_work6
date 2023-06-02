// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int count = int.Parse(Console.ReadLine());
int[] arr = new int[count];
Console.WriteLine("Введите числа: ");
for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

int pos = 0;
for (int j = 0; j < count; j++)
{
    if (arr[j] > 0)
    {
        pos++;
    }
}

Console.Write($"Количество чисел больше 0: {pos}");