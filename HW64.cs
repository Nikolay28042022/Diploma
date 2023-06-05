//  Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью 
// рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(num, count);

// Метод вывода натуральных чисел от N до 1
void NaturalToLow(int n, int count)
{
    if (num < 0) Console.Write($"{num} не натуральное число");
    if (num == 0) return;
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}
