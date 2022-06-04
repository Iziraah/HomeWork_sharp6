// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Введите любое количество чисел через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


int count = 0;
for (int i = 0; i < array.Length; i++)
{
        if(array[i] > 0)
    {
      count++;  
    }
}
Console.WriteLine($"Количество положительных элементов массива: {count}");
