int[] array = new int [6];
for (int i = 0; i < 6; i++)
     array[i] = new Random().Next(100, 1000);
int sum_honest = 0;
Console.WriteLine("[" + string.Join(", ", array) + "]");
for (int i = 0; i < 6; i++)
{
    if (array[i] % 2 == 0)
        sum_honest = sum_honest+1;
}
Console.Write("Колличество четсных элементов массива равно: ");
Console.Write(sum_honest);
