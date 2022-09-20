/*Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*/

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите массив строк через пробел");
string[] Array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int count = (from a in Array where a.Length < 4 select a).Count();
string[] newArray = ThreeElArray(Array, count);
PrintArray(newArray);


string[] ThreeElArray(string[] array, int size)
{
    string[] stringArray = new string[size];
    int k = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length < 4)
        {
            stringArray[k] = Array[i];
            k++;
        }
    }
    return stringArray;
}


void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != (array.Length - 1)) Write($"{array[i]}, ");
        else Write($"{array[i]}");
    }
    Write("]");
    WriteLine();
}