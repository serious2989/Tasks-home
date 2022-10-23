void FillArray(double[,] array)                                          
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round (new Random().NextDouble()*10,2);
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int m = 3;
int n = 4;
double[,] array = new double [m, n];
Console.Clear();
FillArray(array);
PrintArray(array);