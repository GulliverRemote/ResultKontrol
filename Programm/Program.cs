void FillArray(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"Введите {i} элемент начального массива: ");
        mas[i] = Console.ReadLine();
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

void FillSecondArray(string[] masOne, string[] masTwo)
{
    int elementOneMas;
    for (int i = 0; i < masTwo.Length; i++)
    {
        elementOneMas = new Random().Next(0, masOne.Length);
        masTwo[i] = masOne[elementOneMas];
    }
}

Console.WriteLine("Введите размер начального массива: ");
int columnFirst = int.Parse(Console.ReadLine()!);
string[] FirstArray = new string[columnFirst];
int columnSecond = new Random().Next(0, 4);
string[] SecondArray = new string[columnSecond];
FillArray(FirstArray);
Console.WriteLine("\n Начальный массив");
PrintArray(FirstArray);
FillSecondArray(FirstArray, SecondArray);
Console.WriteLine($"\n Полученный массив с [{columnSecond}] эл.");
PrintArray(SecondArray);
