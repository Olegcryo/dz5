//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


System.Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.Write($"Наш массив состоит из чисел: ");
PrintArray(numbers);
int sum = 0;

for(int i = 0; i<numbers.Length;i+=2)
{
    sum = sum + numbers[i];
}
System.Console.WriteLine($"Из всех {numbers.Length} чисел , сумма элементов на нечетных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for ( int j = 0; j<numbers.Length; j++)
    {
        numbers[j]= new Random().Next(1,10);
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