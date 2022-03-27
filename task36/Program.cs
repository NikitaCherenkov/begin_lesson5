// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Random rnd = new Random();
int count;
int amount = 0;
Console.WriteLine("Введите количество элементов массива");
string entry = Convert.ToString(Console.ReadLine());
bool isNum = int.TryParse(entry, out count);
if (isNum & count > 0) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) array[i] = rnd.Next(100, 1000);
    for (int n = 0; n < array.Length; n = n + 2) {
        amount = amount + array[n];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {amount}");
} else Console.WriteLine("Нужно ввести положительное целое число");
