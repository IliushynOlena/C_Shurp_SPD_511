using System.Collections.Specialized;
using System.Text;

namespace _01_Intro
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            object obj = new object();

            Console.Write("Hello\n");
            Console.Write("\tHello");
            Console.Write("\t\tHello\n");
            Console.Write("\t\t\tHello\n");
            Console.Write("Hello");

            //Console.WriteLine("Enter number : ");
            //string str = Console.ReadLine()!;
            //int number = int.Parse(str);
            //Console.WriteLine(str);
            //Console.WriteLine(str + "!!!");
            //Console.WriteLine(str + 100);
            //Console.WriteLine(number + 100);
            //Console.WriteLine("You have : " + number + 100);

            //Console.WriteLine($"You have : {number + 100}");

            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.ToString("yyyy-MM-dd"));

            int a = 5;
            Console.WriteLine($"a = {a}");

            //Int32 b = 14;
            int b = 14;
            Console.WriteLine($"b = {b}");

            bool myBool = true;
            short myShort = 6;

            int myInt = myShort;// short --> int
            float myFloat = myInt;//float --> int

            int myNewNUmber = (int)3.34;

            float num = 5.8f;


            //Console.WriteLine("Enter number : ");
            //string str = Console.ReadLine()!;
            //int number = int.Parse(str);
            //Console.WriteLine(number);
            //number = Convert.ToInt32(str);
            //Console.WriteLine(number);


            //try
            //{
            //    float float_num = Convert.ToSingle(Console.ReadLine()!);
            //    Console.WriteLine(float_num);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            int A = 6;
            //Nullable<int>B = null;  
            int? B = null;//? - null conditional operator
            B = 100;

            string s = null;//reference nullable 
            string s2 = s;//null

            if( s != null)
                 s.ToUpper();
            // or using null conditional opeator
            s?.ToUpper();

            s2 = s == null ? "Error" : s;

            // or using null conditional opeator
            s2 = s ?? "Error";

            Console.ForegroundColor = ConsoleColor.Green;   
            Random random = new Random();
            Console.WriteLine(random.Next());//0....maxIn
            Console.WriteLine(random.Next(100));//0....99
            Console.WriteLine(random.Next(100,500));//100....499
            Console.WriteLine(random.NextDouble());//0....1
            Console.ResetColor();
            if (3 > 8)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
            //for (int i = 0; i < 10; i++)
            //{

            //}
            //while (true)
            //{

            //}
            //do { } while (true);
            //Literals();
            // ConsoleMethods();
            FormatString();
        }
        static void Literals()
        {
            Console.WriteLine((10).GetType());
            Console.WriteLine((10D).GetType());
            Console.WriteLine((10f).GetType());
            Console.WriteLine((10m).GetType());
            Console.WriteLine((10L).GetType());
            Console.WriteLine((10UL).GetType());
            Console.WriteLine(0xFF);
        }
        static void ConsoleMethods()
        {

            Console.Title = "Приклад використання метолів класу Console";

            Console.BackgroundColor = ConsoleColor.Green;

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Input Encoding: dsnbfdjskjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh");
            int length = ("Input Encoding: dsnbfdjsbsdjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh ").Length + 1;
            Console.SetWindowSize(length, 8);

            Console.WriteLine("Input Encoding: " + Console.InputEncoding.ToString());
            Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            Console.ResetColor();
            Console.WriteLine("Is NUM LOCK turned on: " + Console.NumberLock.ToString());
            Console.WriteLine("Is CAPS LOCK turned on: " + Console.CapsLock.ToString());

            Console.Write("Enter a simpe message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Your message is: " + message);
            Console.Beep(300, 3000);
            Console.Clear();
            Console.WriteLine("Your message is: " + message);
        }
        static void FormatString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            /////////////////////// Escape Sequences
            /*
                \'      – single quote, needed for character literals
                \"      – double quote, needed for string literals
                \\      – backslash
                \0      – Unicode character 0
                \a      – Alert (character 7)
                \b      – Backspace (character 8)
                \f      – Form feed (character 12)
                \n      – New line (character 10)
                \r      – Carriage return (character 13)
                \t      – Horizontal tab (character 9)
                \v      – Vertical quote (character 11)
                \uxxxx  – Unicode escape sequence for character with hex value xxxx                
            */
            Console.WriteLine("Деяке повідомлення \nІ ще " +
                "одне просте повідомлення  " +
                "в новому рядку" +
                "ще якийсь текст");

            Console.WriteLine("Пример табуляции: " +
             "\n1\t2\t3\n4\t5\t6");
            /*
            1. 2 3
            4. 5 6*/
            Console.WriteLine("kghfdkjgh" +
                "sdjfisdgiusgf" +
                "sdhfiusdgfuisd" +
                "dsihfsdigiusd" +
                "shdgoisdgh");
            Console.WriteLine(@"C:\Users\helen\Desktop\Work\C#\1");
            /////////////////////// @ - litteral formatting
            Console.WriteLine(@"Пример буква        льного
         hhjfhf
                C:\Users\helen\Desktop\Work\C#\1
             kdfjgoihiodfhoihb
            строкового литерала:
ehoiweiowegtowei
            1 \t 3
            \n 5 6");



            string name = "Bob";
            int day = 29;
            bool isValid = true;

            Console.WriteLine("Hello " + name + " Day: " + day.ToString());
            Console.WriteLine("Hello " + name + " Day: " + day); // ToString() is called automatically
            // string interpolation: $ - operator
            Console.WriteLine($"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,20}\tDay: {day,20}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,-20}\tDay: {day,20}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,-20}\tDay: {day,-20}\nValid: {isValid}{{}}");

            // $ + @
            Console.WriteLine($@"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");

          
           
        }

    }
}
