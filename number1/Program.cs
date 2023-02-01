// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

System.Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.Write($"Наш массив состоит из чисел:");
PrintArray(numbers);
int count = 0;

for (int i =0;i< numbers.Length;i++)
if (numbers[i] % 2 == 0)
count++;
System.Console.WriteLine($"Из всех {numbers.Length} чисел , четными являются {count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for ( int j = 0; j<numbers.Length; j++)
    {
        numbers[j]= new Random().Next(100,1000);
    }
}

void PrintArray(int[]numbers)
{
System.Console.Write("[");
for(int j = 0;j<numbers.Length;j++)
{
    System.Console.Write(numbers[j] + " ");
}
System.Console.Write("]");
System.Console.WriteLine();
}