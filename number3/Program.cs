//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
System.Console.Write($"Наш массив состоит из чисел: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for(int i = 0; i<numbers.Length;i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
System.Console.WriteLine($"Из все {numbers.Length} чисел , максимальным элементом является - {max} , а минимальным - {min}");
System.Console.WriteLine($"Разница между этими элементами - {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    numbers[j] =Convert.ToDouble(new Random().Next(100,1000)) / 100 ;
}
void PrintArray(double[] numbers)
{
     System.Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    System.Console.Write("]");
    System.Console.WriteLine();
}