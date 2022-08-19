int[] array = new int [10];
for (int i = 0; i < 10; i++)
     array[i] = new Random().Next(1, 10);
int NECH = 0;
Console.WriteLine("[" + string.Join(", ", array) + "]");
for (int i = 0; i < 10; i++)
{
    if ( i % 2 != 0)

        NECH = NECH + array[i];
    
            
}
Console.WriteLine("Сумма нечетных элементов массива равна: " + NECH);
