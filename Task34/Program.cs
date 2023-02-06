// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine($"Количество чётных чисел в массиве - {Program.EvenCount(4)}");
    }

    static int EvenCount(int number1)
    {
        Random rand = new Random();
        int[] array = new int[number1];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100, 999);
            // Console.Write($"{array[i]} ");
        }

        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] % 2 == 0)
            {
                count++;
            }
        }

        return (int)count;
    }

}
