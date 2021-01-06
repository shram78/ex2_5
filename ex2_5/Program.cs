using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Нужно написать программу (используя циклы, обязательно пояснить выбор вашего цикла), чтобы она выводила следующую последовательность
 7 14 21 28 35 42 49 56 63 70 77 84 91 98*/
namespace ex2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //реализация через цикл for, тк это цикл с параметром, имеющим начальное и конечное значение переменной и задается правило ее изменения
            //тк я изначально явно знаю границы цикла 7-98, и правило изменения (+7 каждую итерацию) я решаю задачу с помощью цикла for

            for (int i = 7; i <= 98; i+=7)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
