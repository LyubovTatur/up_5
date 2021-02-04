using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_5_lib
{/// <summary>
/// мой контейнер
/// </summary>
    public class Cowotainer
    {
        public List<int> list;
        /// <summary>
        /// контейнер
        /// </summary>
        /// <param name="list"></param>
        public Cowotainer(List<int> list)
        {
            this.list = list;
        }
        /// <summary>
        /// контейнер
        /// </summary>
        public Cowotainer()
        {
            this.list = new List<int>();
        }
        /// <summary>
        /// Добавить элемент в конец списка
        /// </summary>
        /// <param name="elem"></param>
        public void Add(int elem)
        {
            list.Add(elem);
        }
        /// <summary>
        /// доступ по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            set
            {
                try
                {
                    list[index] = value;

                }
                catch (Exception)
                {

                    throw new Exception_1($"Не удалось обратиться к элементу по индексу {index}");
                }
            }
            get
            {
                try
                {
                      return list[index];

                }
                catch (Exception)
                {

                    throw new Exception_1($"Не удалось обратиться к элементу по индексу {index}");
                }
            }
        }
        /// <summary>
        /// возвращает длину списка
        /// </summary>
        public int Length { get { return list.Count(); } }
        /// <summary>
        /// перегрузка оператора
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Cowotainer operator *(Cowotainer a, Cowotainer b)
        {
            Cowotainer cowotainer = new Cowotainer();
            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                cowotainer.Add(a[i] * b[i]);
            }
            return cowotainer;
        }
        /// <summary>
        /// один круть вправо по кругу
        /// </summary>
        private void Krut()
        {
            try
            {
                int temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
            catch (Exception_1)
            {

                throw new Exception_1("Список пуст");
            }
            
        }
        /// <summary>
        /// круть энное клово раз
        /// </summary>
        /// <param name="n"></param>
        public void RightCircleMove( int n)
        {
            for (int i = 0; i < n; i++)
            {
                Krut();
            }
        }
        public void Show()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write(list[i].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
//  Класс - контейнер СПИСОК с ключевыми значениями типа int.
//  Реализовать операции:[] – доступа по индексу; – определение размера
//  списка; *вектор –умножение элементов списков a[i]*b[i]; -n - круговое
//  движение вправо элементов на n позиций. Исключение: при
//  необходимости крутить список по кругу два или более раз за один
//  сдвиг(n&gt; 2х длин).