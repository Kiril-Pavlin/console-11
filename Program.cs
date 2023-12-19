using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1.Используя двузначное случайное число,
            //    вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.

            // Random rnd = new Random();   
            // int а = rnd.Next(10,99);
            // Console.WriteLine(а);
            // string g = а % 2 == 0 ? "четное" : "нечетное";
            // Console.WriteLine(g);
            //  Console.ReadKey();

            //Задача 2. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.

            //   Random rnd = new Random();
            //  int а = rnd.Next(1,7);
            //    Console.WriteLine(а);     
            //  switch (а)
            //   {
            //      case 1:
            //      Console.WriteLine("Понедельник");
            //      break;
            //      case 2:
            //      Console.WriteLine("Вторник");
            //      break;
            //      case 3:
            //      Console.WriteLine("Среда");
            //      break;
            //      case 4:
            //      Console.WriteLine("Четверг");
            //      break;
            //      case 5:
            //      Console.WriteLine("Пятница");
            //      break;
            //      case 6:
            //      Console.WriteLine("Субота");
            //      break;
            //      case 7:
            //     Console.WriteLine("Воскресенья");
            //      break;   }

            //Задача 3. Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза,
            //если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.


            //   int a = 2;
            //   int b = 4;
            //  int c = 6;
            //   if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            //   {
            //       a /= 2;
            //       b /= 2;
            //       c /= 2;
            //   }
            //   else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            //   {
            //       a *= 2;
            //       b *= 2;
            //       c *= 2;
            //   }
            //   else
            //   {
            //       a++;
            //       b++;
            //       c++;
            //   }
            //   Console.WriteLine(a);
            //   Console.WriteLine(b);   
            //   Console.WriteLine(c);

            // Задача 4.Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов:
            //  от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».

            Console.WriteLine("Введите балл");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Отлично");
            }
            else if (score >= 70 && score <= 89)
            {
                Console.WriteLine("Хорошо");
            }
            else if (score >= 50 && score <= 69)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else
            {
                Console.WriteLine("Неудовлетворительно");

            }

            Console.ReadKey();






        }
        }
    }

