/*Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
452 -> 3
82 -> 2
9,012 -> 4
*/

void NumberOfDigitsByArray(double i)
{
    if (i < 0) i = i * -1;

    int[] array = i.ToString().Replace(",", String.Empty).Select(c => (int)Char.GetNumericValue(c)).ToArray();  

    int size = array.Length;

    Console.WriteLine (size); 
         
}

Console.WriteLine ("Programm will count the number of digits in inputed number.");
Console.WriteLine ("Please enter your number:");
double number = double.Parse (Console.ReadLine()!);


Console.WriteLine ("The number of digits in your number is:");
NumberOfDigitsByArray(number);
