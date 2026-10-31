using System.Collections.Specialized;
using System.Text;

namespace _05_String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "blabla";
            foreach (var let in word)
            {

                char.IsUpper(let);
            }
         
            word += "blabla";
            Console.WriteLine(word);

            StringBuilder builder = new StringBuilder();
            Console.WriteLine($"Size : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
            builder.Append("blabla");
            builder.Append("blabla");
            builder.Append("blabla");
            builder.Append("blabla");
            builder.Append("blabla");
            Console.WriteLine($"Size : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
            builder.Append("blabla");
            builder.Append("blabla");
            builder.Append("blabla");
            builder.Append("blabla");
            builder.Append("blabla");
            Console.WriteLine($"Size : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
        }
    }
}
