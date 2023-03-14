// Ввести 3ёх значное число, вывести вторую цифру этого числа.

Console.WriteLine("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((a / 10) % 10);
