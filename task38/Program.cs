// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

Random rnd = new Random();
int count;
Console.WriteLine("Введите количество элементов массива");
string entry = Convert.ToString(Console.ReadLine());
bool isNum = int.TryParse(entry, out count);
if (isNum & count > 1) {
    double[] array = new double[count];
    for (int i = 0; i < count; i++) array[i] = rnd.Next() - rnd.NextDouble() * rnd.Next();
    double max = array[0];
    double min = array[0];
    for (int n = 0; n < array.Length; n++) {
        max = Math.Max(max, array[n]);
        min = Math.Min(min, array[n]);
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min}");
} else Console.WriteLine("Нужно ввести положительное целое число больше единицы");
