using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать структуру для решения линейного уравнения 0=kx+b. 
             * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
             * Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
             * Осуществить использование экземпляра в программе.*/

            Console.WriteLine("Программа для решения линейного уравнения 0=kx+b");
            Console.Write("Введите значение коэффициента K: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффициента K: ");
            double b = Convert.ToDouble(Console.ReadLine());
            LinUrav linUrav = new LinUrav(k, b); //Создаем экземпляр структуры
            linUrav.Root(); // Вызываем метод
            Console.ReadKey();

        }
        public struct LinUrav //Структура для уравнения
        {
            public LinUrav(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
            public double k;
            public double b;

            public void Root() // Метод для вычисления Х
            {
                Console.WriteLine("Значение  X = {0}", -b / k);
            }

        }
    }
}
