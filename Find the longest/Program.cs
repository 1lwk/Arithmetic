using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_longest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====" + maxStr("banana")); // nna
            Console.WriteLine("====" + maxStr("jianghanlu")); // u
            Console.WriteLine("====" + maxStr("hummingbird")); // urd
            while (true) { }
        }

        /// <summary>
        /// 返回最长字符串的方法
        /// </summary>
        /// <param name="s">传入的参数</param>
        /// <returns></returns>
        static string maxStr(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            Stack<char> stack = new Stack<char>();

            // 从左到右遍历字符串
            foreach (char c in s)
            {
                // 当栈不为空且栈顶元素小于当前字符时，弹出栈顶元素
                while (stack.Count > 0 && stack.Peek() < c)
                {
                    stack.Pop();
                }

                // 将当前字符压入栈
                stack.Push(c);
            }

            // 将栈中的字符拼接成结果字符串
            char[] result = stack.ToArray();
            Array.Reverse(result);

            return new string(result);
        }
    }
}
