// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1
// y = k2 * x + b2
// b1, k1, b2 и k2 задаются пользователем
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты уравнений: ");
double b1 = double.Parse(Console.ReadLine()),
k1 = double.Parse(Console.ReadLine()),
b2 = double.Parse(Console.ReadLine()),
k2 = double.Parse(Console.ReadLine()),

x = (b1 - b2)/(k2 - k1),
y = k1 * x + b1;
Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");