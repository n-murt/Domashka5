// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;
using System.Linq;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine($"Сумма минимальных и максимальных чисел в вещественном в массиве - {Program.DiffMinMax(4)}");
    }

    static float DiffMinMax(int number1)
    {
        Random rand = new Random();
        float[] array = new float[number1];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next();
            //Console.Write($"{array[i]} ");
        }

        return (float)array.Max() - array.Min();
    }

}