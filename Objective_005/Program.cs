/*Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.*/

void FillArray(int[] arr) 
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(0, 2); 
        index++; 
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0; 
    while (position < count)
    {
        Console.Write(arr[position] + " | "); 
        position++;         
    }
}

void Compare_0_1(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    int zero = 0;
    int one = 0;
    
    while (index < count)
    {
        if (arr[index] == 0)
        {
            zero++;
        }
        else
        {
            one++;
        }
        index++;
    }

    if (zero == one)
    {
        Console.WriteLine ("(Similar.)");
    }
    else
    {
        if(zero < one)
        {
            Console.WriteLine("(True.)");
        }
        else
        {
            Console.WriteLine("(False.)");
        }
    }
}

int[] array = new int[8];

FillArray(array);

PrintArray(array);

Compare_0_1(array);