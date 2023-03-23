// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

void NumberSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от m до n = {sum}");
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}

int m = ReadInt("Введите начальное число m: ");
int n = ReadInt("Введите начальное число n: ");
NumberSum(m, n, 0);