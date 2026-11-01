using System.Drawing;

namespace _07_ParamsRefOut
{
    partial class Point
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public Point() : this(0, 0) { }
        public Point(int value) : this(value, value) { }
        public Point(int x, int y)
        {
            XCoord = x;
            YCoord = y;
        }

        public void Print()
        {
            Console.WriteLine($"X : {XCoord}. Y : {YCoord}");
        }
        public override string ToString()
        {
            return $"X : {XCoord}. Y : {YCoord}";
        }

    }
    internal class Program
    {
        static void MethodWithParams(string name,params int[] marks)
        {
            Console.WriteLine($"Name : {name}");    
            Console.Write($"Marks : ");
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Modify(ref int num, ref string str,ref Point p)
        {
            //num += 10;
            str += "!!!";
            p.XCoord++;
            p.YCoord++;
        }
        static void GetCurrectTime(out int hour,out int minute,out int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }

        static void Main(string[] args)
        {

            int num = 5;
            string str = "Hello academy";
            Point point = new Point(5,5);
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Point : {point}");
            //ref == & 
            Modify(ref num, ref str, ref point);
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Point : {point}");

            int h, m , s ;
            //Console.WriteLine($"{h}:{m}:{s}");
            GetCurrectTime(out h,out m,out s);
            Console.WriteLine($"{h}:{m}:{s}");



            //int[] marks = [11, 5, 8, 9, 6, 3, 11, 12];
            //MethodWithParams("Olga", marks);
            //MethodWithParams("Mukola", new int[] {4,5,6,4,5,6,4,5,6});
            //MethodWithParams("Oleg", 11,11,11,11,111,111,1111,1111,111,111,111);
            //MethodWithParams("Oleg", 11,11,11,11,111,111,1111);
            //MethodWithParams("Oleg", 11);
        }
    }
}
