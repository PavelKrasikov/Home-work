// Цифра = дню недели, определить является ли этот день выходныи
Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 7 || a == 6)
    Console.WriteLine ("Выходной");
    
else
    Console.Write("Будний день");
