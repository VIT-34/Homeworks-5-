// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int length = 20;

int[] RandArray (int length)
{
 int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
       array[i] = new Random().Next(100, 1000);
   }
   return array;
}

void PrintResult(int[] array)
{
   int a = 0;
  int b = 0;
for (int i = 0; i < array.Length; i++)
   {
      System.Console.Write(array[i] + " ");
      if (array[i] % 2 == 0) a++;
      else b++;
  }
  System.Console.WriteLine();
  System.Console.WriteLine($"Количество четных чисел {a}, количество нечетных чисел {b}");
 System.Console.WriteLine();
}

PrintResult(RandArray(length));
