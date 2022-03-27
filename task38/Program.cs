// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

Random rnd = new Random();
int count;
double max = 0;
double min = 0;
Console.WriteLine("Введите количество элементов массива");
string entry = Convert.ToString(Console.ReadLine());
bool isNum = int.TryParse(entry, out count);
if (isNum & count > 1) {
    double[] array = new double[count];
    for (int i = 0; i < count; i++) array[i] = rnd.Next() - rnd.NextDouble() * rnd.Next();
    for (int n = 0; n < array.Length - 1; n++) {
        max = Math.Max(array[n], array[n + 1]);
        min = Math.Min(array[n], array[n + 1]);
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min}");
} else Console.WriteLine("Нужно ввести положительное целое число больше единицы");
