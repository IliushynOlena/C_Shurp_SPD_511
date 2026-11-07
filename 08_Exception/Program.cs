using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace _08_Exception
{
    class MyClass
    {
        public void BadMethod()
        {
            Exception exception = new Exception("My Exception message");

            exception.HelpLink = "https://google.com";
            exception.Data.Add("Exception reason : ", "Test exception");
            exception.Data.Add("Time invokation : ", DateTime.Now);
            exception.Data.Add("User name : ", "Olena");

            throw exception;

        }
    }
    class MyExceptionClass : Exception
    {
        public DateTime Time { get; set; } = DateTime.Now;
        public MyExceptionClass()
        {
            //Time = DateTime.Now;
        }

        public MyExceptionClass(string? message) : base(message)
        {
           // Time = DateTime.Now;
        }

        public MyExceptionClass(string? message, Exception? innerException) : base(message, innerException)
        {
            //Time = DateTime.Now;
        }

        protected MyExceptionClass(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    class User
    {
        private string login;
        public string Login
        {
            get { return login; }
            set
            {
                if (value == "")
                    throw new MyExceptionClass("Login is invalid...");
                else
                    login = value;
            }
        }
    }
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("My Exception!");
        }
    }


    internal class Program
    {
        static double SafeDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException("Second operand = 0");
            }
            return x / y;
        }

        public static int GetInt32FromConsole()
        {
            try
            {
                return int.Parse(Console.ReadLine()!);
            }
            catch (FormatException ex)
            {

                throw new MyExceptionClass("Argument has incorrect format",ex);
            }
            catch(Exception ex) 
            {
                throw ex;
            }   
        }
        static void Main(string[] args)
        {
            #region Exception Example 1
            /*
            int a = 1, b = 2;

            try
            {
                Console.WriteLine("Enter a : ");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter b : ");
                b = int.Parse(Console.ReadLine()!);

                int res = a / b;
                Console.WriteLine($"Res = {res}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Continue.............");
            Console.WriteLine("Continue.............");
            Console.WriteLine("Continue.............");
            Console.WriteLine("Continue.............");
            Console.WriteLine("Continue.............");
            */
            #endregion
            #region Exception Example 2
            /*
            double a = 98, b = 0;
            double result = 0;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine($"Res = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempt divide by zero");
                Console.WriteLine(ex.Message);
            }
            */
            #endregion
            #region Exception Example 3
            /*
            try
            {
                MyClass myClass = new MyClass();
                myClass.BadMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Member name : {e.TargetSite}");
                Console.WriteLine($"Member class : {e.TargetSite.DeclaringType}");
                Console.WriteLine($"Member type : {e.TargetSite.MemberType}");
                Console.WriteLine($"Method name : {e.TargetSite.Name}");
                Console.WriteLine($"Message : {e.Message}");
                Console.WriteLine($"Source : {e.Source}");
                Console.WriteLine($"HelpLink : {e.HelpLink}");
                Console.WriteLine($"StackTrace : {e.StackTrace}");


                foreach (DictionaryEntry item in e.Data)
                {
                    Console.WriteLine($"{item.Key}  -  {item.Value}");
                }
            }
            */
            #endregion
            #region Exception Example 4
            int number = 0;
            try
            {
                number = GetInt32FromConsole();
                Console.WriteLine("*****************************************");
                Console.WriteLine($"Number = {number}");
            }
            catch (MyExceptionClass ex)
            {

                Console.WriteLine("My exception catch !");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Time);
            }

            #endregion

            #region Exception Example 5

            try
            {
                throw new UserException();
            }
            catch (UserException userException)
            {
                Console.WriteLine("Exception catch!.");
                userException.Method();
                FileStream fs = null;
                try
                {
                    fs = File.Open(@"C:\NonExistentFile.log", FileMode.Open);
                    //write

                    //....exception 

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);

                }
                finally
                {
                    //fs.Close();
                    Console.WriteLine("End inner try");
                }

            }
            finally
            {
                Console.WriteLine("End outer try");
            }


            #endregion
        }
    }
}
