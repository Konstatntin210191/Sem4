// Напишите программу, которая выводит массив из 8-ми элементов, заполненных 1/0 в случайном порядке.

void GetFillArray(int[] collection)
{
    Random randomaiser = new Random();
    for( int i = 0; i < collection.Length; i++)
    {
        collection[i] = randomaiser.Next(0, 2);
    }
}

int[] array = new int[8];
GetFillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

