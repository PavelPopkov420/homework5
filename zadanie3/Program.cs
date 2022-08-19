double[] array = new double [6];
for (int i = 0; i < 6; i++)
    array[i] = new Random().Next(1, 100);
double max = array[0];
double min = array[0];
double raz = 0;
Console.WriteLine("[" + string.Join(", ", array) + "]" ) ;
for (int i = 0; i < 6; i++)
{
    if ( array[i] > max)
        
        max = array[i];

    if (array[i] < min)
        min = array[i];

        raz = max - min;

}   
Console.WriteLine("Разница между максимальным и минимальным равна: " + raz);
