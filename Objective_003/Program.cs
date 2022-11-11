/*Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.*/

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0; 
    while (position < count)
    {
        Console.Write (arr[position] + " | "); 
        position++;         
    }
}

void FillArrayByUserByStep(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    int count = 1;
    while (index < length)
    {
        Console.WriteLine ($"Please, enter {count} number: ");
        arr[index] = int.Parse (Console.ReadLine()!);
        index++;
        count++;
    }
}

Console.WriteLine ("Programm will create Array step by step, using inputed numbers.");
int[] array = new int[8];
FillArrayByUserByStep(array);
Console.WriteLine ("Your Array is ready:");
PrintArray(array);
