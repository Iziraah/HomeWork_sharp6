// Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем.

Console.WriteLine("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2, отличное от 1: ");
int k2 = int.Parse(Console.ReadLine());



int xCross = (b1 * b2) / (k2 - (b1 * k2));
int yCross = ((-b1 * k2) - b2) / (1 - k2);




Console.WriteLine($"Точка М({xCross},{yCross}) является пересечением двух прямых");



