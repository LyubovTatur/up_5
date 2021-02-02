using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_5_lib
{
    static class Massive
    {
        static void Sorty(int[] mas) => Array.Sort(mas);
        static int[] Sumy(int[] a, int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                a.Append(b[i]);
            }
            Sorty(a);
            return a;
        }
    }
}
//  Реализовать тип, для выполнения операций над упорядоченным
//  одномерным массивом. Предусмотреть возможность упорядочения
//  массива. Реализовать операции сложения двух массивов, в результате
//  которой элементы второго массива добавляются к элементам первого
//  массива, не нарушая упорядочения. Предусмотреть возможность
//  выполнения операций.


