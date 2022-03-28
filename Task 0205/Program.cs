// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 100);
    }
    return answer;
}
void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine();
}

int[] arr = RandArray(10);
PrintArray(arr);

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 != 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine($"Сумма эллементов стоящих на нечетных позициях {sum}");
