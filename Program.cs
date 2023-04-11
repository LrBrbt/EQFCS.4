using EQFCS._4;
using System.Collections.Generic;
using System.Linq;


Console.WriteLine("Задание 1");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(Tasks.Task1(number));

Console.WriteLine();

Console.WriteLine("Задание 2");

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число от 1 до {arraySize}: ");
int elementNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];

Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 10);
}

while (array.Length > 1)
{
    Console.WriteLine();

    array = Tasks.Task2(array, elementNumber);

    Console.WriteLine();
    //Console.WriteLine("Удаление элементов.");
    //Thread.Sleep(1000);
    //Console.WriteLine("Удаление элементов..");
    //Thread.Sleep(1000);
    Console.WriteLine();
    Thread.Sleep(1000);
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//Console.WriteLine("Задание 3");
