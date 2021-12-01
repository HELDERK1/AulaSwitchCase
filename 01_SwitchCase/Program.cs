using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor correspondente ao dia: ");
            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesnday";
                    break;
                case 4:
                    day = "Wendesday";
                    break;
                case 5:
                    day = "Thuesday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;

            }



            Console.WriteLine("Day: " + day);

            Console.ReadKey();

        }
    }
}
