using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpt_str = Console.ReadLine();
            int index = inpt_str.IndexOf(' ');
            int k = int.Parse(inpt_str.Substring(0, index));
            int index_2 = inpt_str.LastIndexOf(' ');
            string term_num = inpt_str.Substring(index_2+1);
            string arr_str = inpt_str.Substring(index + 1, index_2 - 2);
            string[] adit_arr = arr_str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[adit_arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(adit_arr[i]);
            }

            string outpt_str = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 || i % k == 0)
                {
                    outpt_str += arr[i] + " ";
                }
            }
            outpt_str += term_num;
            Console.Write(outpt_str);
            Console.ReadKey();
        }
    }
}
