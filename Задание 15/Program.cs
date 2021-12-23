using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Progrram
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();// Создаем арифметическую прогрессию//
            arith.setStart(10); // Устанавливаем стартовое значение//
            arith.setStep(2); // Устанавливаем  шаг//
            Console.WriteLine(arith.getNext());// вывод на кран значение арифметической прогрессии//
            Console.WriteLine(arith.getNext());// вывод на кран последующее значение арифметической прогрессии//
            Console.WriteLine(arith.getNext());// вывод на кран последующее значение арифметической прогрессии//
            arith. reset();// Срасываем к стартовому значению//
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.ReadKey();
        }
    }
}


