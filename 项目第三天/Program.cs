using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List泛型集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////案例1
            //List<string> list1 = new List<string>() { "a", "b", "c", "d", "e" };
            //List<string> list2 = new List<string>() { "d", "e", "f", "g", "h" };
            //for(int i = 0; i < list2.Count; i++)
            //{
            //    if (!list1.Contains(list2[i]))
            //    {
            //        list1.Contains(list2[i]);
            //    }
            //}
            //foreach (string item in list1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //案例2
            //Random r = new Random();
            //List<int> list = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    int rNumber = r.Next(1, 101);
            //    if(!list.Contains(rNumber) && rNumber % 2 == 0)
            //    {
            //        list.Add(rNumber);
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //案例3；
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> listJi = new List<int>();
            List<int> listOu = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    listOu.Add(nums[i]);
                }
                else
                {
                    listJi.Add(nums[i]);
                }
            }

            listOu.AddRange(listJi);
            foreach (int item in listOu)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
