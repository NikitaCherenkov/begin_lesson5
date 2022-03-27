// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

Random rnd = new Random();
int count;
int amount = 0;
Console.WriteLine("Введите количество элементов массива");
string entry = Convert.ToString(Console.ReadLine());
bool isNum = int.TryParse(entry, out count);
if (isNum & count > 0) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = rnd.Next(100, 1000);
        if (array[i] % 2 == 0) amount++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {amount}");
} else Console.WriteLine("Нужно ввести положительное целое число");
