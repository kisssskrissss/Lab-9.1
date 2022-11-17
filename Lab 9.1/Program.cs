using System;

namespace Lab_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
           
            try
            {
                Console.WriteLine("Введите целое число Х");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число Y");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции \n1-сложение\n2-вычетание\n3-умножение\n4-частное");
                Console.WriteLine("Ваш выбор: ");
                int v = Convert.ToInt32(Console.ReadLine());
                if (v==1)
                {
                    int r = x + y;
                    Console.WriteLine("Результат {0} ", r );
                }
                if (v == 2)
                {
                    int r = x - y;
                    Console.WriteLine("Результат {0} ", r);
                }
                if (v == 3)
                {
                    int r = x * y;
                    Console.WriteLine("Результат {0} ", r);
                }
                if (v == 4)
                {
                    int r = x / y;
                    Console.WriteLine("Результат {0:00} ", r);
                }
                if (v  > 4  || v<1)
                {
                    Console.WriteLine("Нет такого варианта");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();

        }

    }
}
