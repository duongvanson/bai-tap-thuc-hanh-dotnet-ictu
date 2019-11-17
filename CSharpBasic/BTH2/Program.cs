using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string inp = "";
            while (true)
            {
                inp = Console.ReadLine();
                if (inp.Equals("exit")) break;
                Console.WriteLine("INPUT:" + inp);
                inp = standardizeString(inp);
                inp = removeNumberInString(inp);
                Console.WriteLine("OUTPUT:" + inp);
                Console.WriteLine("---");
            }
            //while (true)
            //{
            //    inp = Console.ReadLine();
            //    if (isNumberInString(inp))
            //    {
            //        Console.WriteLine("Không được nhập rỗng hoặc nhập chữ số. =))");
            //    }
            //    else break;
            //}
           // Console.WriteLine(isNumberInString("lal5alal"));
           // Console.ReadKey();
        }
        static string removeNumberInString(string str)
        {
            var lst = str.ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                if (char.IsDigit(lst[i]))
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }
            string outp = new string(lst.ToArray());
            // outp = outp.Replace("%", "");
            return outp;
        }
        static string standardizeString(string inp)
        {
            inp = inp.Trim();
            var lst = inp.Split(' ');
            inp = "";
            foreach (string item in lst)
            {
                if (!string.IsNullOrWhiteSpace(item.Trim()))
                {
                    var temp = item.Substring(0, 1);
                    temp = temp.ToUpper();
                    temp = temp + item.Substring(1, item.Length - 1);
                     
                    inp += temp + " ";
                }
            }
            inp = inp.TrimEnd();
            return inp;
        }
        static bool isNumberInString(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return true;
            var lst = str.ToArray();
            foreach (var item in lst)
            {
                if (!string.IsNullOrWhiteSpace(item.ToString()))
                {
                    int temp = 0;
                    //Int32.TryParse(item.ToString(), out temp)
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
