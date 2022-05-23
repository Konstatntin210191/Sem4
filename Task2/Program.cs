// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

string GetNumber()
{
    return Console.ReadLine();
} 

int GetCountNumber(string str)
{
    int number = int.Parse(str);
    int count = 0;
    
    while(number != 0)
    {
        number = number / 10;
        count++;
    }
    
    return count;
}



/*
int GetCountNumber()
{
    return str.Length;
}
*/

Console.WriteLine("Введите число: ");
int count = GetCountNumber(GetNumber());
Console.WriteLine(count);