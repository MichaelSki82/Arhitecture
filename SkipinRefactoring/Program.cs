using System;

namespace SkipinRefactoring
{
    class Program
    {
        static int FactorialNumber(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FactorialNumber(n - 1);
            }
            
        }
        static int SummNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            else
            {
                return SummNumber(n / 10) + n % 10;
            }
        }

        static int MaxEvenNumber(int n)
        {
            int maxnumber = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    maxnumber = i; 
                }
            }
            return maxnumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа," +
            "\nкоторая позволяет сделать следующие рассчеты:" +
            "\n - факториал числа; " +
            "\n - порядковую сумму чисел;" +
            "\n - максимальное четное число.");
            Console.WriteLine("Пожалуйста, введите любое целое число: ");

            string TouchUser = Console.ReadLine();
            if (TouchUser == "q") return;
                    
           
            int n = Convert.ToInt32(TouchUser);
           

            Console.Write("Факториал числа равен: ");
            Console.WriteLine(FactorialNumber(n));

            Console.Write("Порядковая сумма числа равна: ");
            Console.WriteLine(SummNumber(n));

            Console.Write("Максимальное четное число равно: ");
            Console.WriteLine(MaxEvenNumber(n));

            Console.WriteLine("Для выхода из программы нажмите 'Enter' ");

            Console.ReadLine();
        }
    }
}
