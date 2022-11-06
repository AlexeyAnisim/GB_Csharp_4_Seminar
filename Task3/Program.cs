// Программа, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = {5, 6, 3, 2, 2, 6, 7, 1, 0};

void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
PrintArray(arr);