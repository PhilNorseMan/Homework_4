/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetDegreeFromNumbers (int n1, int n2)
{

    int count = 0;
    int result = 1;

    if (n2 < 0) 
    {
        result = -1;
    }
    else
    {   
        while(count < n2)
        {
            count++;
            result = result * n1;
        }
    }

   return result;
}

Console.WriteLine("Programm will raise your Number to degree.");
Console.WriteLine("Please, enter your number: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter degree value: ");
int number_2 = int.Parse(Console.ReadLine()!);

int result = GetDegreeFromNumbers (number_1, number_2);

if (result == -1)
{
    Console.WriteLine ("!!!Incorrect degree value!!!");
}
else
{
    Console.Write("Result is: ");
    Console.WriteLine(result);
}

