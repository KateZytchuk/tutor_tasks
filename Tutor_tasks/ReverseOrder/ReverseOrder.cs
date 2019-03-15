using System;

namespace ReverseOrder
{
    class ReverseOrder
    {
        static void Main(string[] args)
        {
            string inpt_str = string.Empty, term_num = string.Empty, arr_str = string.Empty;
            int index;
            string[] addtnl_arr;

            inpt_str = Console.ReadLine();

            index = inpt_str.LastIndexOf(' ');

            term_num = inpt_str.Substring(index + 1);

            arr_str = inpt_str.Substring(0, index);
            addtnl_arr = arr_str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] ArrToRev = new int[addtnl_arr.Length];

            for (int i = 0; i < addtnl_arr.Length; i++)
            {
                ArrToRev[i] = int.Parse(addtnl_arr[i]);
            }

            Array.Reverse(ArrToRev);

            foreach (int i in ArrToRev)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("{0}", term_num);
            Console.ReadLine();
        }
    }
}
