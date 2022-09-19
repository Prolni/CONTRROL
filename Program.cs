/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using static System.Console;
Clear();

string[] array1 = new string[] {"Hello","2","world",":-)"};
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan"};

result.printResult(array1);
result.printResult(array2);
result.printResult(array3);
WriteLine();

public class result
{
public static void printStringArr(string[]array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
            Write($"\"{array[i]}\"");
       if(i!=array.Length-1) Write(", ");
    }
    Write("]");
}
public static string[] menee3symbol(string[]array)
{
    int resultLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4)resultLength++;
    }

    string[] result=new string[resultLength];
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i].Length < 4)
            {
                result[counter++] = array[i]; 
            }
    }
    return result;
}
public static void printResult(string[] array)
{ 
printStringArr(array);
Write("   →   ");
printStringArr(menee3symbol(array));
    Write("\n");
}
}
