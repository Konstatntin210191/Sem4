// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int GetProdofNum(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    prod *= i;

    return prod;
}

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int prod = GetProdofNum(num);
Console.WriteLine(prod);
