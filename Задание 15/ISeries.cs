using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    /*
      метод void setStart(int x) - устанавливает начальное значение
   метод int getNext() - возвращает следующее число ряда
    метод void reset() - сброс к начальному значению
     */
    interface Iseries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    class ArithProgression : Iseries
    {

        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue += step;
            return currentValue; throw new NotImplementedException();
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
