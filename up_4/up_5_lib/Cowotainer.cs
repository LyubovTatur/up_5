using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_5_lib
{
    class Cowotainer
    {
        List<int> list;

        public Cowotainer(List<int> list)
        {
            this.list = list;
        }
        public Cowotainer()
        {
            this.list = new List<int>();
        }
        public void Add(int elem)
        {
            list.Add(elem);
        }
        public int this[int index]
        {
            set
            {
                list[index] = value;
            }
            get
            {
                return list[index];
            }
        }
        public int Length { get { return list.Count(); } }
        public static Cowotainer operator *(Cowotainer a, Cowotainer b)
        {
            Cowotainer cowotainer = new Cowotainer();

            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                cowotainer.Add(a[i] * b[i]);
            }
            return cowotainer;
        }



    }
}
//  Класс - контейнер СПИСОК с ключевыми значениями типа int.
//  Реализовать операции:[] – доступа по индексу; – определение размера
//  списка; *вектор –умножение элементов списков a[i]*b[i]; -n - круговое
//  движение вправо элементов на n позиций. Исключение: при
//  необходимости крутить список по кругу два или более раз за один
//  сдвиг(n&gt; 2х длин).