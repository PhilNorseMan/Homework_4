/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
452 -> 11
82 -> 10
9012 -> 12 */

int SumOfNumbersInArray (int[] arr)
{
    int count = arr.Length;
    int position = 0;
    int sum = 0;
    while (position < count)
    {
        sum = sum + arr[position];
        position++;
    }

    return sum;
}

Console.WriteLine ("Programm will show you sum of digits in your number.");
Console.WriteLine ("Please enter your number:");
int i = int.Parse (Console.ReadLine()!);

if (i < 0) i = i * -1;

int[] array = i.ToString().ToCharArray().Select(x => x - '0').ToArray();

int result = SumOfNumbersInArray(array);
Console.WriteLine ("Sum of digits is:");
Console.WriteLine (result);