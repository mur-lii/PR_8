//*************************************************************************
//* Практичсекая работа № 8                                               *
//* Выполнила: Трухина Е.Д., группа 2ИСП                                  *
//* Задание: составить программу циклической структуры: итерационный цикл *
//*************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PR_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Title = "Практичсекая работа 8";
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Здравствуй!");

                bool continueProgram = true;

                while (continueProgram)
                {
                    Console.Write("Введите n = ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите эпсилон(ε) = ");
                    string input = Console.ReadLine();
                    double epsilon = double.Parse(input, CultureInfo.InvariantCulture);
                    //double epsilon = Convert.ToDouble(Console.ReadLine());

                    double sum = 0;
                    double a = 1;
                    int i = 1;

                    while (i <= n)
                    {
                        if (i == 1) a = 1.5;
                        else a = a * 3.0 / (2.0 * (2.0 * i - 1.0));


                        if (Math.Abs(a) >= epsilon)
                            sum += a;

                        i++;
                    }
                    Console.WriteLine($"\nСумма членов ряда, удовлетворяющих условию: {sum}");

                    Console.Write("\nПродолжить? (y/n): ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer != "y")
                    {
                        continueProgram = false;
                        Console.WriteLine("Выход из программы");
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Вы ввели не число! Пожалуйста, введите цифры.");//Если пользователь вводит символы вместо цифр
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком большое или слишком маленькое.");//Если введенное число слишком большое или слишком маленькое для типа double
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);//любая другая ошибка
            }
            Console.ReadKey();
        }
    }
}
