//Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.Размер массива определяется пользователем.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
var randomValue = new Random();
int [] array = new int[size];

Console.WriteLine($"Элементы массива целых чисел с заданным размером {size}:");

for (int i = 0; i < size; i++)
{
    array[i] = randomValue.Next(1, 100);
    Console.Write($"{array[i]} ");
}
