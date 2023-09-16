using System;

class Calculator
{
    static void Main()
    {
        int number= 0;
        double num1, num2;

        while (number != 9)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть второе из первого");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                        Console.WriteLine("Результат: " + (num1 / num2));
                    else
                        Console.WriteLine("Ошибка: деление на ноль");
                    break;
                case 5:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + Math.Pow(num1, num2));
                    break;
                case 6:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + Math.Sqrt(num1));
                    break;
                case 7:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 * 0.01));
                    break;
                case 8:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    double factorial = 1;

                    for (int i = 1; i <= num1; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Результат: " + factorial);
                    break;
                case 9:
                    Console.WriteLine("Программа завершена");
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный выбор операции");
                    break;
            }

            Console.WriteLine();
        }
    }
}
