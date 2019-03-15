using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {
            string inpt_str = Console.ReadLine();
            int index = inpt_str.IndexOf(' ');
            int quant = int.Parse(inpt_str.Substring(0, index));
            string str_arr = inpt_str.Substring(index);
            string[] arr_str = str_arr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int [] workArr = new int[arr_str.Length];
            for (int i = 0; i < arr_str.Length; i++)
                workArr[i] = int.Parse(arr_str[i]);
            Array.Sort(workArr);
            Console.Write("{0} ", quant);
            foreach (int i in workArr)
                Console.Write("{0} ", i);
            Console.ReadKey();
        }
    }
}
