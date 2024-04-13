using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    internal class Sort
    {
        public delegate void SortDelegate(int n);
        public event SortDelegate SortEvent;

        public void Read()
        {

            Console.WriteLine("Выберите режим сортировки 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1) Sort1Created(number);
            else if (number == 2) Sort2Created(number);
            else throw new FormatException("Выберите правильный вариант сортировки");
        }
        protected virtual void Sort1Created(int n)
        {
            Console.WriteLine("Вы выбрали первый вариант сортировки");
            SortEvent?.Invoke(n);
        }
        protected virtual void Sort2Created(int n)
        {
            Console.WriteLine("Вы выбрали второй вариант сортировки");
            SortEvent?.Invoke(n);
        }
    }
}
