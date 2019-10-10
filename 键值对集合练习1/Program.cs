using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 键值对集合练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //案例1
            //string str = "1一 2二 3三 4四 5五 6六 7七 8八 9九 0零";
            //Dictionary<char, char> dic = new Dictionary<char, char>();
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    dic.Add(strNew[i][0], strNew[i][1]);
            //}
            //Console.WriteLine("请输入小写，我们将转化成大写");
            //string input = Console.ReadLine();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (dic.ContainsKey(input[i]))
            //    {
            //        Console.Write(dic[input[i]]);
            //    }
            //    else
            //    {
            //        Console.Write(input[i]);
            //    }
            //}
            //Console.ReadKey();

            //案例2
            //string str = "welcome , to Chinaworld";
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if(str[i] == ' ' || str[i] == ',')
            //    {
            //        continue;
            //    }
            //    if (!dic.ContainsKey(str[i]))
            //    {
            //        dic.Add(str[i], 1);
            //    }
            //    else
            //    {
            //        dic[str[i]]++;
            //    }
            //}
            //foreach (KeyValuePair<char, int> kv in dic)
            //{
            //    Console.WriteLine("字母{0}出现了{1}次", kv.Key, kv.Value);
            //}
            //Console.ReadKey();

            //案例3：编写一个函数进行日期转换，将输入的中文日期转换为阿拉伯数字日期，比如：
            //二零一二年十二月二十一日要转换为2012 -12-21。
            //(处理“十”的问题：1.*月十日；2.*月十三日；3.*月二十三日；4.*月三十日；)4中情况对“十”的不同翻译。
            //1→10；2→1；3→不翻译；4→0【年部分不可能出现’十’，都出现在了月与日部分。】  
            //测试数据：二零一二年十二月二十一日(2012年12月21日)、二零零九年七月九日、二零一零年十月二十四日、二零一零年十月二十日
            string str = "二零一零年十月二十三日";
            string ziDian = "一1 二2 三3 四4 五5 六6 七7 八8 九9 零0";
            Dictionary<char, char> dic = new Dictionary<char, char>();
            string[] temp = ziDian.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < temp.Length; i++)
            {
                dic.Add(temp[i][0], temp[i][1]);
            }
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (dic.ContainsKey(str[i]))
                {
                    result += dic[str[i]];
                }
                else
                {
                    //不包含 十  年月日
                    //如果是十
                    if(str[i] == '十')
                    {
                        //1.*月十日；2.*月十三日；3.*月二十三日；4.*月三十日
                        if(!dic.ContainsKey(str[i - 1]) && !dic.ContainsKey(str[i + 1]))
                        {
                            result += "10";
                        }
                        else if (dic.ContainsKey(str[i - 1]) && !dic.ContainsKey(str[i + 1]))
                        {
                            result += "1";
                        }
                        else if (dic.ContainsKey(str[i - 1]) && dic.ContainsKey(str[i + 1]))
                        {

                        }
                        else
                        {
                            result += "0";
                        }
                    }
                    else
                    {
                        //年月日
                        result += "-";
                    }
                }
            }
            result = result.TrimEnd('-');
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
