// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int Inputint(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int M = Inputint("Введите число M");
int N = Inputint("Введите число N");
Console.WriteLine($"N={N}, M={M}");


    if (M > N)
        for (int i = N; i <= M; i++)
        {
            if(i%2==0)
            Console.Write($" {i}");
        }
    else
        for (int i = M; i <= N; i++)
        {
            if(i%2==0)
            Console.Write($" {i}");
        }




