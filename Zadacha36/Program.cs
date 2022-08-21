// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

int [] array = new int [5];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(10);
    if(i %2 > 0) sum = sum + array[i];
    {
     Console.WriteLine(array[i]);
    }
}
Console.WriteLine($"сумма элементов чисел на нечетных позициях: =  {sum}");

