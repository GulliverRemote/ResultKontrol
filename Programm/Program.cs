void FillArray(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"Введите {i} элемент начального массива: ");
        mas[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"'{mas[i]}' ");
    }
    Console.WriteLine("]");
}

int ColumnSecondMas(string[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length < 4)
            count++;
    }
    return count;
}

void FillSecondArray(string[] masOne, string[] masTwo)
{
    int j = 0;
    for (int i = 0; i < masOne.Length; i++)
    {
        if (masOne[i].Length < 4)
        {
            masTwo[j] = masOne[i];
            j++;
        }
    }
}

Console.WriteLine("Введите размер начального массива: ");
int columnFirst = int.Parse(Console.ReadLine()!);
string[] FirstArray = new string[columnFirst];
FillArray(FirstArray);
Console.WriteLine("\n Начальный массив");
PrintArray(FirstArray);
int columnSecond = ColumnSecondMas(FirstArray);
string[] SecondArray = new string[columnSecond];
FillSecondArray(FirstArray, SecondArray);
Console.WriteLine($"\n Полученный массив с [{columnSecond}] эл.");
if (columnSecond == 0)
    return;
PrintArray(SecondArray);
