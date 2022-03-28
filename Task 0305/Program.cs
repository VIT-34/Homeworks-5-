// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double min = double.MaxValue; 
double max = double.MinValue; 
double k;

double[] array = new double[10];
Random rand = new Random();
Console.WriteLine("Заполненый массив");
for (int i = 0; i < array.Length; i++)
{
    array[i] = min;
    Console.WriteLine();

        k = rand.NextDouble() * 100/7;
        Console.WriteLine(max);
        Console.WriteLine(min);
    
    if (k > max)
        max = k;

    if (k < min)
        min = k;
}

Console.WriteLine("Разница между макс и мин: {0:0.000}", max - min);
    

