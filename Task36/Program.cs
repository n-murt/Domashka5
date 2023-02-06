// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Сумма чисел с нечетным индексом в массиве - {Program.OddSum(4)}");
    }

    static int OddSum(int number1)
    {
        Random rand = new Random();
        int[] array = new int[number1];
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 100);
            Console.Write($"{array[i]} ");
        }

        for (int k = 0; k < array.Length; k++)
        {
            if (k % 2 == 0)
            {
                sum = sum + array[k];
            }
        }

        return (int)sum;
    }

}
