using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "56789";
            string md5Str = GetMd5(str);
            Console.WriteLine(md5Str);
            Console.ReadKey();
        }
        static string GetMd5(string str)
        {
            MD5 md5 = MD5.Create();
            //将字符串转换成字节形式
            byte[] buffer = Encoding.Default.GetBytes(str);
            //开始加密，返回加密后的字节数组
            byte[] bufferMD5 = md5.ComputeHash(buffer);

            //将加密后的字节数组转化为字符串
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bufferMD5.Length; i++)
            {
                sb.Append(bufferMD5[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
