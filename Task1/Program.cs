// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

bool IsNumberPositive(int number)
{
    return number > 0;
}

int GetSummFromOneToNumber(int number)
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
        summ += i; //sum =sum + i
    return summ;
}



Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if(IsNumberPositive(number))
{
    int sum = GetSummFromOneToNumber(number);
    Console.WriteLine($"Сумма чисел от 1 до n: {sum}");
}
else
{
    Console.WriteLine("Некоррекстное число");
}