using System.Globalization;
using System.Text;

namespace _04_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string fname, lname;
            fname = "Roman";
            lname = "Romanchuk";

            string fullname = fname + " " + lname;
            Console.WriteLine($"Full name : {fullname}");


            char[] letters = { 'H', 'e', 'l', 'l', 'o', '!' };
            Console.WriteLine(letters.Length);

            string greeting = new string(letters,2,4);
            Console.WriteLine("Greeting : {0}",greeting);

            string[] sarray = { "Hello", "From", "Green", "Tree", "Summer", "Sun" };
            string message = string.Join(" - ",sarray);
            Console.WriteLine($"Message : {message}");

           string[] splitArr= message.Split(new string[] {" - "}, 
               StringSplitOptions.None);

            foreach (string s in splitArr)
            {
                Console.WriteLine(s);
            }

            // ConsoleKeyInfo key= Console.ReadKey();
            //if( key.Key == ConsoleKey.F12)
            //{
            //    Console.WriteLine("F12 is clicked....");
            //}

            string sentense = "Lorem Ipsum is simply dummy text of the " +
                "printing and typesetting industry. Lorem Ipsum has " +
                "been the industry's standard dummy! text ever since " +
                "1966, when designers at Letraset and James Mosley, " +
                "the librarian at St Bride Printing? Library in London, " +
                "took a";

            string[] words = sentense.Split(new char[] 
            { '.', ',', '!', '?', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in words)
            {
                Console.WriteLine($"|{w}|");
            }

            Console.OutputEncoding = Encoding.UTF8;
            DateTime dateNow = DateTime.Now;
            Console.WriteLine(dateNow);
            Console.WriteLine(dateNow.ToString());
            Console.WriteLine(dateNow.ToLongDateString());
            Console.WriteLine(dateNow.ToLongTimeString());
            Console.WriteLine(dateNow.ToShortDateString());
            Console.WriteLine(dateNow.ToShortTimeString());
            Console.WriteLine(dateNow.ToString("yyyy-MM-dd"));
            Console.WriteLine(dateNow.ToString("hh:mm:ss"));

            DateTime vacation = dateNow;
            vacation= vacation.AddMonths(1);
            vacation = vacation.AddDays(25);
            vacation = vacation.AddHours(12);

            TimeSpan timeSpan = vacation - dateNow;
            Console.WriteLine(timeSpan);

            Console.WriteLine($"Microseconds : {timeSpan.Microseconds}");
            Console.WriteLine($"Seconds : {timeSpan.Seconds}");
            Console.WriteLine($"Minutes : {timeSpan.Minutes}");
            Console.WriteLine($"Hours : {timeSpan.Hours}");
            Console.WriteLine($"Days  :{timeSpan.Days}");


            Console.WriteLine($"Total Microseconds : {timeSpan.TotalMilliseconds}");
            Console.WriteLine($"Total Seconds : {timeSpan.TotalSeconds}");
            Console.WriteLine($"Total Minutes : {timeSpan.TotalMinutes}");
            Console.WriteLine($"Total Hours : {timeSpan.TotalHours}");
            Console.WriteLine($"Total Days  :{timeSpan.TotalDays}");
            */
            decimal money = 35.6m;

            //CultureInfo us = new CultureInfo("uk-UA");
           //CultureInfo us = new CultureInfo("en-US");
            //CultureInfo us = new CultureInfo("fr-FR");
            CultureInfo us = new CultureInfo("pl-PL");
            Console.WriteLine($"You need to pay for product :{money.ToString("C2",us)}" );


            string nullStr = null;

            if (nullStr != null) 
            { 
                nullStr.ToLower();
            }
            // null-conditional operator
            nullStr?.ToLower();

            string emptyStr = "";
            if(string.IsNullOrEmpty(emptyStr) && string.IsNullOrEmpty(nullStr))
            {
                Console.WriteLine("Is null or empty");
            }

            string str = "                  ";
            if (string.IsNullOrWhiteSpace(str)) {
                Console.WriteLine("Is null or white spaces");
            }

            string str1 = "This is test";
            string str2 = "This is test";

            if(string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("Str is equals");
            }
            else
            {
                Console.WriteLine("Str is not equals");
            }

            string str3 = "Some very interesting message";
            string subString = str3.Substring(3, 10);
            Console.WriteLine(subString);

            //C / c
            //Задаємо грошові одиниці , вказуючи кількість цифр після коми
            //
            //D / d
            //Цілочисельний формат, де ми вказуємо максимальну кількість цифр (5)
            //
            //  00015
            //  00155
            //  01478
            //  00587
            //
            //E / e
            //Кількість цифр після коми
            //
            //F / f
            //Кількість цифр після коми
            //
            //G / g
            //Вибирає більш короткий варіант : F або E
            //
            //
            //P / p
            //Задает відображення знаку відсотків поряд з числом
            //
            //X / x
            //Шестнадцятковий формат числа
            int number = 23;
            Console.WriteLine(number);

            Console.WriteLine("Number : " + number.ToString());

            Console.WriteLine($"Number : {number}");

            Console.WriteLine("Number : {0:d5}, {1}, {2}", 100, 200, "Hello");

            Console.WriteLine("Number : {0:d4}. {1}", number, "Hello");

            Console.WriteLine("Number {0:d2}", number);

            string result = String.Format("Number: {0:d5}", number);
            //Console.ReadKey();
            Console.WriteLine(result); // 23
            //string result2 = String.Format("{0:d4}", number);
            //interpolation
            string result2 = $"Number : {number:d4}";
            // string result2 = $"Number : {number, 15}";
            Console.WriteLine(result2); // 0023
            //Console.ReadKey(); // pause


            int number1 = 23;
            string result1 = String.Format("{0:f4}", number1);
            Console.WriteLine(result1); // 23,00
            //Console.ReadKey(); // pause

            double number2 = 45.086546546545;
            //string result3 = String.Format("{0:f4}", number2);
            string result3 = $"Number: {number2:F4}";
            Console.WriteLine(result3); // 45,0800
            //Console.ReadKey(); // pause

            long number4 = 19876543210;
            string result5 = String.Format("{0:+# (###) ###-##-##}", number4);
            string result6 = $"{number4:+# (###) ###-##-##}";
            Console.WriteLine(result5); // +1 (987) 654-32-10
            Console.WriteLine(result6); // +1 (987) 654-32-10
                                        //Console.ReadKey(); // pause


            var someDir = "a";
            Console.WriteLine(@$"c:\{someDir}\b         
mvbjcvl;bncv;
xcvxckbvx
            kjhrgksjerhglearhglierhg
erjkghaer               kherlkf
            ejhjer

\c");
            Console.WriteLine($"Name: {"Ivan",-10} Age: {23,10}"); // spaces before
            Console.WriteLine($"Name: {"Veronika",-10} Age: {34,10}"); // spaces after


            //Concatanation
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // = string "hello world"
            string s4 = System.String.Concat(s3, "!!!"); // = string "hello world!!!"
            Console.WriteLine(s4);

            //Finding in string 
            string s11 = "hello world";
            char ch = 'o';
            int indexOfChar = s11.IndexOf(ch); // = 4
            Console.WriteLine(indexOfChar);

            string subString2 = "wor";
            int indexOfSubstring = s11.IndexOf(subString2); // = 6
            Console.WriteLine(indexOfSubstring);
            Console.ReadKey();

            string s12 = " ? Me tengo?!, To be honest!!!   ";
            //s12 = s12.Trim();

           

            s12 = s12.Trim(new char[] { '?', ' ', '!' });

            Console.WriteLine($"After trimming: /{s12}/");

        }
    }
}
