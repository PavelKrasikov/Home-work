Console.WriteLine("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
    
        Console.WriteLine("Third digit no");

    if (a > 99 && a < 1000)
       {
        Console.WriteLine(a % 10);
       }
       if (a > 999 && a < 10000)
          {
           Console.WriteLine((a / 10) % 10);
          }
          if (a > 9999 && a < 100000)
             {
                Console.WriteLine((a / 100) % 10);
             }
             if (a > 99999 && a < 1000000)
                {
                    Console.WriteLine((a / 1000) % 10);
                }

