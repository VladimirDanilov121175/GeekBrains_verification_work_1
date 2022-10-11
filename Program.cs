/* Итоговый проект № 1 (GeekBrains, вводный курс, 1 четверть)

Задача: из имеющегося строкового массива создать новый массив, в который войдут 
строковые элементы с количеством символов, равным 3 или меньше.
Ввести первоначальный массив допускается с клавиатуры, либо задать на старте алгоритма.
Примеры:
["hello", "2", "world", ":-)"]              ->  ["2", ":-)"]
["1234", "-2", "computer science", "****"]  ->  ["-2"]
["Kazan", "Moscow", "Cheboksary"]           ->  []
 */
Console.Clear();

int FindNewLength(string[] array)
{
    int newLength = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newLength++;
    }
    return newLength;
}


void CreateAndPrintNewArray(string[] oldArray, int newLength)
{
    string[] newArray = new string[newLength];
    int i = 0;

    foreach (string j in oldArray)
    {
        if (j.Length <= 3)
        {
            newArray[i] = j;
            i++;
        }
    }
    PrintArray(newArray);
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}


string[] array = { "hello", "-2", "world", ":-)))", "Git" };
PrintArray(array);

int newLength = FindNewLength(array);

if (newLength == 0) Console.WriteLine("[]");
else CreateAndPrintNewArray(array, newLength);
