namespace _06_IntroToOOP
{
    /*
     private (default for all fields)
     public
     protected
     internal
     protected internal     
     */
    partial class Point
    {
        public void SetXCoord(int newX)
        {
            if (newX > 0)
                this.xCoord = newX;
            else
                this.xCoord = 0;
        }
        public void SetYCoord(int newY)
        {
            if (newY > 0)
                this.yCoord = newY;
            else
                this.yCoord = 0;
        }
        public int GetX()
        {
            return xCoord;
        }
        public int GetY()
        {
            return yCoord;
        }
    }
}
