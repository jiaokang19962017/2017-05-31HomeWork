using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.两个ArrayList集合去重复
            /*  ArrayList al1 = new ArrayList();
              al1.Add("a");
              al1.Add("b");
              al1.Add("c");
              al1.Add("d");
              al1.Add("e");
              ArrayList al2 = new ArrayList();
              al2.Add("d");
              al2.Add("e");
              al2.Add("f");
              al2.Add("g");
              al2.Add("h");
              al1.AddRange(al2);
              var result = al1.Cast<string>().Distinct().ToArray();
              foreach (var item in result)
              {
                  Console.WriteLine(item);
              } */
            #endregion

            #region 2.随机生成数
            /* ArrayList al = new ArrayList();
             Random r = new Random();
             for (int i = 0; i < 10; i++)
             {
                 int num = r.Next(1, 100);
                 if (!al.Contains(num))
                 {
                         al.Add(num);

                 }
                 else
                 {
                     i--;
                 }
             }
             foreach (var item in al)
             {
                 Console.WriteLine(item);
             }*/
            #endregion

            #region 5.将int数组的奇数放到一个新的数组中
            /*      int[] num1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                  int[] num2 = new int[5];
                  int j = 0;
                  for (int i = 0; i <num1.Length; i++)
                  {
                      if (num1[i] % 2 == 1)
                      {
                          num2[j] = num1[i];
                          j++;
                      }
                  }
                  foreach (var item in num2)
                  {
                      Console.WriteLine(item);
                  }*/
            #endregion

            #region 6.从数组中提取最大值
            /*   List<int> ls = new List<int>() { 1, 2, 4, 3, 415, 5, 666, 7 };
               //int result =  ls.Max();
               // Console.WriteLine(result);
               int temp;
               for (int i = 0; i <ls.Count ; i++)
               {
                   for (int j = i+1; j < ls.Count; j++)
                   {
                       if (ls[j] < ls[i])
                       {
                           temp = ls[j];
                           ls[j] = ls[i];
                           ls[i] = temp;
                       }
                   }
               }
               Console.WriteLine(ls[ls.Count - 1].ToString() ); */
            #endregion

            #region 7.转换为汉字
            /*  Dictionary<char, char> dc = new Dictionary<char, char>();
              dc.Add('1', '壹');
              dc.Add('2', '贰');
              dc.Add('3', '叁');
              dc.Add('4', '肆');
              dc.Add('5', '伍');
              dc.Add('6', '陆');
              dc.Add('7', '柒');
              dc.Add('8', '捌');
              dc.Add('9', '玖');

              Console.WriteLine("请输入一个整数");
              string sele = Console.ReadLine();
              try
              {
                  for (int i = 0; i < 100; i++)
                  {
                      Console.Write(dc[sele[i]]);
                  }
              }
              catch (Exception ex)
              {
              }*/

            #endregion

            #region 8.字母出现次数

            #endregion
        }
    }
}
