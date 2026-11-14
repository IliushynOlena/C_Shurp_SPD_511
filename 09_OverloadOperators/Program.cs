
namespace _09_OverloadOperators
{

    class Point_3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point_3D() : this(0, 0,0) { }
        public Point_3D(int x, int y,int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public void Print()
        {
            Console.WriteLine($"X : {X}. Y : {Y}. Z : {Z}");
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}. Z : {Z}";
        }

    }
        class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0) { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Print()
        {
            Console.WriteLine($"X : {X}. Y : {Y}");
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /*
* public static return_type operator[symbol](parameter)
* {
* code
* }          
*/
        #region Унарні оператори -5  a++  a--   !
        public static Point operator -(Point p)
        {
            Point res = new Point()
            {
                X = p.X * -1,
                Y = p.Y * -1
            };
            return res;
        }
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion

        #region Бінарні оператори  +  -   *   / 
        public static Point operator +(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return res;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion

        #region Логічні оператори порівняння  < > <= >=
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X + p1.Y > p2.X + p2.Y;
        }
        //in pair
        public static bool operator <(Point p1, Point p2)
        {
            return p1.X + p1.Y < p2.X + p2.Y;
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        //in pair
        public static bool operator <=(Point p1, Point p2)
        {
            return p1.X + p1.Y <= p2.X + p2.Y;
        }

        #endregion
        #region Логічні оператори рівності   ==  !=
        public static bool operator ==(Point p1, Point p2)
        {
            //return p1.X == p2.X && p1.Y == p2.Y;
            return p1.Equals(p2);
        }
        //in pair
        public static bool operator !=(Point p1, Point p2)
        {
            //return p1.X != p2.X || p1.Y != p2.Y;
            return !(p1 == p2);
        }

        #endregion
        #region True/False оператори
        public static bool operator true(Point p)
        {
            return p.X >0 && p.Y >0;    
        }
        //in pair
        public static bool operator false(Point p)
        {
            return p.X <0 || p.Y<0;
        }

        #endregion
        #region Overload TYPE
        public static explicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator double(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator Point_3D(Point p)
        {
            return new Point_3D(p.X,p.Y,p.X+p.Y);
        }
        #endregion

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;//int ---> int
            double b = 6.7;//double --> double

            b = a;//int ..... double 5.000000000000  implicit
            a = (int) b;//double .... int   5  explicit

            Point p = new Point() { X = 5, Y = 7 };
            a = (int)p;
            Console.WriteLine(a);
            //b = p;
            Point_3D p3 = p;
            Console.WriteLine(p3);



          




          //  string name = "Olga";
          //  string name2 = name;

          //if (name.Equals(name2))
          //      Console.WriteLine("Equals");
          //else
          //      Console.WriteLine("Not equals");


            Point p1 = new Point() { X = -5, Y = 8 };
            Point p2 = new Point() { X = 25, Y = 25 };

            if(p1)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (p1 > p2)
                Console.WriteLine("Point p1 > p2");
            else
                Console.WriteLine("Point p2 > p1");


            if (p1.Equals(p2))
                Console.WriteLine("Equals");
            else
                Console.WriteLine("Not equals");
            if (p1 == p2)
                Console.WriteLine("Point is equals");
            else
                Console.WriteLine("Point is not equals");

            if (p1 != p2)
                Console.WriteLine("Point is not equals");
            else
                Console.WriteLine("Point is  equals");


            Console.WriteLine(5 + 8);
            Console.WriteLine(2.3 + 3.5);

            p1.Print();
            p2.Print();
            Console.WriteLine(p1);
            Console.WriteLine(p2.ToString());
            Point newPoint = -p1;
            Console.WriteLine(newPoint);

            Console.WriteLine($"Increment {p1++}");
            Console.WriteLine($"Increment {++p1}");
            Console.WriteLine($"Decrement {p1--}");
            Console.WriteLine($"Decrement {--p1}");

            Console.WriteLine($"\n\nPoint p1: {p1}");
            Console.WriteLine($"Point p2: {p2}");

            Console.WriteLine(p1 + p2);
            Console.WriteLine(p1 - p2);
            Console.WriteLine(p1 * p2);
            Console.WriteLine(p1 / p2);

            Console.WriteLine($"\n\nPoint p1: {p1}");
            Console.WriteLine($"Point p2: {p2}");

            

        }
    }
}
