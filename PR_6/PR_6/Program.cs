using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, y;
            Console.WriteLine("практическая работа №5");
            Console.WriteLine("введите стороны кирпича");
            Console.Write("введите а= ");// ввод данных
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите с= ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите стороны отверстия ");
            Console.Write("введите x= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите y= ");
            y = Convert.ToInt32(Console.ReadLine());

            {
                switch (a * b * c <= x * y)// проверяем войдет ли кирпич в отверстие
                {
                    case < 1 :
                        Console.WriteLine("вывод: кирпич вошел в отверстие");
                        break;
                    default:
                        Console.WriteLine("вывод: кирпич не вошел в отвертие");
                        break;
                }
            }
                Console.ReadKey();
            }
        }
    }
