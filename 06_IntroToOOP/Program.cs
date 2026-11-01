namespace _06_IntroToOOP
{
    partial class Point
    {
        #region Start


        //private int number;//private
        //private string name;
        //private const float PI = 3.14f;
        //private readonly int id;//onle read value
        //public Point()
        //{
        //    id = 10;
        //}
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}
        //public void Print()
        //{

        //}
        #endregion
     

        static int count;
        static Point()
        {
            count = 0;
        }
        public Point() : this(0, 0) { }
        public Point(int value) : this(value, value) { count++; }
        public Point(int x, int y)
        {
            XCoord = x;
            YCoord = y;
        }
       
        public void Print()
        {
            //Console.SetCursorPosition(this.xCoord, this.yCoord);
            Console.WriteLine($"X : {xCoord}. Y : {yCoord}");
        }
        public override string ToString()
        {
            //Console.SetCursorPosition(this.xCoord, this.yCoord);
            return $"X : {XCoord}. Y : {YCoord}";
        }

    }
    class DerivedClass: Point //public
    {

    }

    struct _3D_Point
    {
        public int x;
        public int y;
        public int z;
        public override string ToString()
        {
            return $"X : {x}. Y : {y}. Z : {z}";
        }
    }

    class Program
    {
      
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            _3D_Point _3D_Point = new _3D_Point();  //struct - new invoke default constructor

            Point p = new Point(-5,47);//class  -- new get dynamic memory


            //Point @class = new Point();
            //p.Print();
            //Console.WriteLine(p.ToString());
            //Console.WriteLine(p);
            Console.ForegroundColor = ConsoleColor.Yellow;
            p.SetXCoord(15);
            p.SetYCoord(22);
            Console.WriteLine(p);
            Console.WriteLine($"Parameter x : {p.GetX()}");
            Console.WriteLine($"Parameter y : {p.GetY()}");

            p.XCoord = 150;//value = 15  set
            Console.WriteLine(p.XCoord);//get

            p.YCoord = 111;
            Console.WriteLine(p.YCoord);
            Console.WriteLine(p);

            p.Salary = 1555;//value = 1555; set
            Console.WriteLine(p.Salary);//get

            p.Color = "green";//set
            Console.WriteLine(p.Color);

            p.NewPrint();

            Point[] points = new Point[3];
            points[0] = new Point(5, 5);
            points[1] = new Point(55, 55);
            points[2] = new Point(15, 15);
            foreach (var item in points)
            {
                Console.WriteLine(item);
            }
        }
    }
}
