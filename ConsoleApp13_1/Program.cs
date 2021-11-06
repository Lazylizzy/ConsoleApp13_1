using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_1
{
    class MyMathOperation
    {
        public double gradus {get; set;}
        public double min { get; set; }
        public double sec { get; set; }


    // Возвращает Радиан
    public double toRadians()
        {

            return (Math.PI *((sec/3600)+(min/60)+gradus))/180;
        }

        

        public void writeResult()
        {
           
            {
                Console.WriteLine("Радиан {0}", toRadians());
                return;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите gradus: ");
            double gradus= Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите min: ");
            double min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите sec: ");
            double sec = Convert.ToInt32(Console.ReadLine());
            MyMathOperation newOperation = new MyMathOperation();
            newOperation.gradus = gradus;
            newOperation.min = min;
            newOperation.sec = sec;
            newOperation.writeResult();

            Console.ReadLine();
        }
    }
}
