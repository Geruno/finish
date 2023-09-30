int Vvod (string message)
{
Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}
void VvodText(string[] array, int razm)
{
    for (int i = 0; i < razm; i++)
    {
        array[i] = Console.ReadLine();
    }
}
void Second(string[] array, string[] arraymin3, int razm)
{
    int count = 0;
    for (int i = 0; i < razm; i++)
    {
        if (array[i].Length <= 3)
        {
            arraymin3[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int razm = Vvod("Введите размер массива: ");
Console.WriteLine($"Введите {razm} значение через Enter");
string[] array = new string[razm];
string[] array3min = new string[razm];
VvodText(array, razm);
Second(array, array3min, razm);
PrintArray(array3min);