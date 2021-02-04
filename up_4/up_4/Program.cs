using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using up_5_lib;

namespace up_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 3, 5 }; 
            //Cowotainer cowo1 = new Cowotainer(list);
            //list = new List<int>() { 3, 3, 2 };
            //Cowotainer cowo2 = new Cowotainer(list);
            //cowo1.Show();
            //cowo2.Show();
            //Cowotainer cowo3 = cowo1 * cowo2;
            //cowo3.Show();


            int[] a = new int[] { 1,2,6,4,8};

            Massive.Sorty(a);
            Massive.Show(a);
            Console.ReadLine();
        }
    }
}
