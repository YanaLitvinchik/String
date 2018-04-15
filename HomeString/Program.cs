using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeString
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        const int countsubj = 3;
        string[] subj;
        int[][] marks;
        int progM, designM, adminM;
        public Student()
        {
            subj = new string[countsubj];
            marks = new int[countsubj][];
            subj[0] = "programming";
            subj[1] = "administration";
            subj[2] = "design";
            marks[0] = new int[0];
            marks[1] = new int[0];
            marks[2] = new int[0];
            progM= 0;
            designM = 0;
            adminM = 0;
        }
        public Student(string name, string surname, string secondname, string group , int age): this()
        {
            Name = name;
            Surname = surname;
            SecondName = secondname;
            Group = group;
            this.Age = age;
        }
        public void SetMark(int mark, int index)
        {
            if (mark < 1 || mark > 12)
                return;
            if (index == 1)
            {
                Array.Resize(ref marks[0], progM + 1);
                marks[0][progM] = mark;
                progM++;
            }
            else if (index == 2)
            {
                Array.Resize(ref marks[1], adminM + 1);
                marks[1][adminM] = mark;
                adminM++;
            }
            else if (index == 3)
            {
                Array.Resize(ref marks[2], designM + 1);
                marks[2][designM] = mark;
                designM++;
            }
        }
        public int[] GetMark(int index)
        {
            if (index == 1)
                return marks[0];
            else if (index == 2)
                return marks[1];
            return marks[2];
        }
        public double MarkMiddle(int index)
        {
            int sum = 0;
            if (index == 1)
            {
                foreach (var item in marks[0])
                    sum += item;
                return (double)sum / marks[0].Length;
            }

            else if (index == 2)
            {
                foreach (var item in marks[1])
                    sum += item;
                return (double)sum / marks[1].Length;
            }

            foreach (var item in marks[2])
                sum += item;

            return (double)sum / marks[2].Length;
        }
        public void ShowMarks()
        {
            Console.WriteLine($"Programming: {String.Join(", ", marks[0])}");
            Console.WriteLine($"Administration: {String.Join(", ", marks[1])}");
            Console.WriteLine($"Design: {String.Join(", ", marks[2])}");
        }
        

        public string ToStringMarksProgramming()
        {
            return String.Join(", ", marks[0]);
        }
        public string ToStringMarksDesign()
        {
            return String.Join(", ", marks[2]);
        }
        public string ToStringMarksAdministration()
        {
            return String.Join(", ", marks[1]);
        }
        public override string ToString()
        {
            return $"Name: {Name } \nSurname: {Surname}\nSecond name: {SecondName}\n"+
                   $"Group:{Group}\nAge : {Age}\n" +
                   $"Programming: {ToStringMarksProgramming()}\n" +
                   $"Administration: {ToStringMarksAdministration()}\n" +
                   $"Design: {ToStringMarksDesign()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Yana", "Li", "Vol", "212",19);
            st.SetMark(10, 1);
            st.SetMark(12, 1);
            st.SetMark(11, 1);
            st.SetMark(9, 2);
            st.SetMark(8, 2);
            st.SetMark(8, 3);
            Console.WriteLine(st);            
            Console.WriteLine("\nMiddle: ");
            Console.WriteLine($"Middle mark (Programming) : {st.MarkMiddle(1)}");
            Console.WriteLine($"Middle mark (Administration) : {st.MarkMiddle(2)}");
            Console.WriteLine($"Middle mark (Design) : {st.MarkMiddle(3)}");
        }
    }
}
