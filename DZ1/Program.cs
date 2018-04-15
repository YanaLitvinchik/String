using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создать метод принимающий, введенную пользователем, 
//    строку и выводящий на экран статистику по этой строке
//    .Статистика должна включать общее количество символов, 
//        количество букв (и сколько в верхнем регистре и нижнем), 
//количество цифр, количество символов пунктуации и количество пробельных символов.
namespace DZ1
{
    class Program
    {
        static void Statistic(string s)
        {
            int len = s.Length;
            int letters = 0;
            int numbers = 0, lower = 0;
            int upper = 0, digit = 0, space = 0, punctuation = 0;

            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetter(arr[i]))
                    letters++;
                if (char.IsNumber(arr[i]))
                    numbers++;
                if (char.IsLower(arr[i]))
                    lower++;
                if (char.IsUpper(arr[i]))
                    upper++;
                if (char.IsDigit(arr[i]))
                    digit++;
                if (arr[i] == ' ')
                    space++;
                if (char.IsPunctuation(arr[i]))
                    punctuation++;
            }
            Console.WriteLine($" len = {len}\n letters = {letters}\n numbers = {numbers}\n lower = {lower}\n upper = {upper}\n digit = {digit}\n punctuation = {punctuation}\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string s = Console.ReadLine();
            Statistic(s);
        }
    }

}
