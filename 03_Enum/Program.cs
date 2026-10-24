namespace _03_Enum
{
    enum DayOfWeek
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday,Saturday, Sunday
    }
    internal class Program
    {
        public static DayOfWeek NextDay(DayOfWeek day)
        {
            return (day < DayOfWeek.Sunday) ? day++: DayOfWeek.Monday;
        }

        static void Main(string[] args)
        {
            DayOfWeek day = DayOfWeek.Sunday;

            day = NextDay(day);
            Console.WriteLine($"Next day (name) {day.ToString()}");
            Console.WriteLine($"Next day (number) {(int)day}");

            string []names =  Enum.GetNames( typeof( DayOfWeek ) );
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
