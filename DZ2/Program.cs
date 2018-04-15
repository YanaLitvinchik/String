using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//пользователь вводит строку и символ.
//В строке найти все вхождения этого символа и 
//    перевести его в верхний регистр, а также удалить
//    часть строки, начиная с последнего вхождения этого символа и до конца.
namespace DZ2
{
    class Program
    {

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Input string:");
            string s = Console.ReadLine();
            Console.WriteLine("Input symbol:");
            string sym = Console.ReadLine();
            char c = Convert.ToChar(sym);
            char[] arr = s.ToCharArray();
            int index = 0;
            for (int i = 0; i < s.Length; i++)
                if (char.IsLower(arr[i]) && arr[i] == c)
                {
                    arr[i] = char.ToUpper(c);
                    index = i;
                }
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}");
            Console.WriteLine();
            //2
            Console.WriteLine($"{s.Remove(index - 1)}");

        }
    }

}
