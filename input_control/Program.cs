using System;

namespace vxodnoikontrol06._09._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача1
            Console.WriteLine("Задача 1:Вычислить логарифм первого числа по основанию второго:");
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число (основание): ");
            double b = Convert.ToDouble(Console.ReadLine());
            logarithm(a, b);

            //задача2
            Console.WriteLine("Задача 2::");
            Console.WriteLine("Введите x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            perimeterAndArea(x1, x2, y1, y2);

            //задача3
            Console.WriteLine("Задача 3: Проверка, дает ли введенное с клавиатуры число одинаковый остаток при делении на 3 и на 4:");
            Console.WriteLine("Введите число:");
            int s = Convert.ToInt32(Console.ReadLine());
            remainder(s);

            //задача4
            Console.WriteLine("Задача 4: Печать в столбик всех цифры введенного n-значного (n от 1 до 10) числа в порядке убывания разрядов:");
            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            desc(n);

            //задача5
            Console.WriteLine("Задача 5: Посчитайте значение следующего выражения при условии, что пользователь вводит с клавиатуры значения х: (ln|cos(x)|)/(ln(1+x^2)):");
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            equation(x);

            //задача6
            Console.WriteLine("Задача 6: Вывод на экран последовательность n первых чисел Фибоначчи, имеющих нечетные индексы:");
            Console.WriteLine("Введите f:");
            int f = Convert.ToInt32(Console.ReadLine());
            fib(f);

            //задача7
            Console.WriteLine("Задача 7: Вычислить сумму первых n членов последовательности: 1/2-2/3-3/4...");
            Console.WriteLine("Введите p:");
            int p = Convert.ToInt32(Console.ReadLine());
            sequence(p);

        }

        public static void perimeterAndArea(double x1, double x2, double y1, double y2)
        {
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);
            double s = a * b;
            double p = 2 * (a + b);
            Console.WriteLine($"Периметр прямоугольника = {p}");
            Console.WriteLine($"Площадь прямоугольника = {s}");
        }
        public static void fib(int f)
        {
            int[] mas = new int[f];
            mas[0] = 0;
            mas[1] = 1;
            for (int i = 2; i < f; i++)
            {
                mas[i] = mas[i - 1] + mas[i - 2];
            }
            for (int i = 0; i < f; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Число: {mas[i]}; Индекс: {i}");
                }
            }
        }

        public static void logarithm(double a, double b)
        {
            Console.WriteLine($"Логарифм числа {a}, по основанию {b} =  {Math.Log(a, b)}");
        }

        public static void equation(double x)
        {
            double z = (Math.Log(Math.Abs(Math.Cos(x)))) / (Math.Log(1 + Math.Pow(x, 2)));
            Console.WriteLine($"Результат: z = (ln|cos(x)|)/(ln(1+x^2)) = {z}");
        }

        public static void remainder(int s)
        {
            int b = s % 2;
            int c = s % 3;
            if (b == c)
            {
                Console.WriteLine($"Число: {s} дает одинаковый остаток от деления на 2 и 3");
            }
            else
            {
                Console.WriteLine($"Число: {s} не дает одинаковый остаток от деления на 2 и 3");
            }
        }

        public static void desc(int n)
        {
            if ((n > 1) && (n < 10))
            {
                string mas = Convert.ToString(n);
                
                for (int i = mas.Length; i > 0; i--)
                {
                    Console.WriteLine(mas[i - 1]);
                }
                
            }
            else
            {
                Console.WriteLine("n не может быть меньше 1 и больше 10");
            }
        }

        public static void sequence(int p)
        {
                double sum = 0;
                for (int i = 0; i < p; i++)
                {
                    sum = sum - (i + 1) / (i + 2);
                }
                Console.WriteLine($"Сумма: {sum}");
        }
    }
}