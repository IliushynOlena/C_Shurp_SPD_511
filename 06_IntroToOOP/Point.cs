namespace _06_IntroToOOP
{
    partial class Point
    {
        private int yCoord;
        public int YCoord
        {
            get { return yCoord; }
            set
            {
                if (value > 0)
                {
                    yCoord = value;
                }
                else
                    yCoord = 0;
            }
        }

        private int xCoord;
        //Properties
        public int XCoord // value
        {
            get { return xCoord; }
            set
            {
                if (value > 0)
                    this.xCoord = value;
                else
                    this.xCoord = 0;
            }

        }
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto property
        public string Name { get; set; }

        //Full property --> propfull + TAB
        private double salary;
        public double Salary//value
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    salary = 0;
            }
        }
        //Auto property --> prop + TAB
        public string Color { get; set; }

        public string Type { get; }//read only
        public string ColorNew { get; private set; } = "White";

    }
}


namespace _06_IntroToOOP
{
    partial class Point
    {
        public void NewPrint()
        {
            Console.WriteLine("I print my new Point");
        }
    }
}