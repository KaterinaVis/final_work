string[] array = new string[5] {"bjhvd","bj", "12", "123", "df12r"};
string[] secondarray = new string[array.Length];

FilterArray(array, secondarray);
Console.WriteLine ($"Строки, длина которых меньше или равна 3м символам:"); 
PrintArray(secondarray);

void FilterArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length < 4)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
