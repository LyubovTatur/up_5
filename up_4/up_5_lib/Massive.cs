using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_5_lib
{/// <summary>
/// статический класс для работой с массивами
/// </summary>
    static public class Massive
    {/// <summary>
    /// сортировка от мин до макс
    /// </summary>
    /// <param name="mas"></param>
        public static void Sorty(int[] mas) => Array.Sort(mas);
        /// <summary>
        /// Добавляет в первый массив второй в конец
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] Sumy(int[] a, int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                a.Append(b[i]);
            }
            Sorty(a);
            return a;
        }
        /// <summary>
        /// вывод
        /// </summary>
        /// <param name="a"></param>
        public static void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString()+" ");
            }
            Console.WriteLine();
        }
    }
}
//  Реализовать тип, для выполнения операций над упорядоченным
//  одномерным массивом. Предусмотреть возможность упорядочения
//  массива. Реализовать операции сложения двух массивов, в результате
//  которой элементы второго массива добавляются к элементам первого
//  массива, не нарушая упорядочения. Предусмотреть возможность
//  выполнения операций.


