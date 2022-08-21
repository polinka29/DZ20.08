// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76
double[] array = arr(5);
double[] arr(int num)
{
   double[] array = new double[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = Math.Round(new Random().NextDouble() * 100, 2);
   }
   return array;
}
Console.Write($"массив: {string.Join(" ", array)}");

double min = array[0];
double max = array[1];
for(int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine();

Console.Write($"разница между мах и мин элементом: {max - min}");
