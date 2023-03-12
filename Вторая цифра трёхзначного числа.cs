// Ввести 3ёх значное число, вывести вторую цифру этого числа.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
Console.WriteLine(b % 10);
