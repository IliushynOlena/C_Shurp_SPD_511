using System.Reflection.Metadata;

namespace _12_Interfaces
{
    interface IWorker
    {
        bool IsWorking {  get; } //properties empty
        void Work();//empty methods
        event EventHandler<EventArgs> WorkCompleted;    

    }

    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public override string ToString()
        {
            return $"Fullname : {FirstName}  {LastName}. Birthdate : {
                Birthdate.ToShortDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public int Salary { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return base.ToString() + 
                $"\nSalary : {Salary}. Position : {Position}";
        }

    }
    interface IWorkable
    {
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorkable> ListWorkers { get; set; }//null
        void Organize();
        void Control ();
        void MakeBudget();
    }
    class Director : Employee, IManager//implement /realize
    {
        public List<IWorkable> ListWorkers { get ; set ; }

        public void Control()
        {
            Console.WriteLine("I control work");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I count money");
        }

        public void Organize()
        {
            Console.WriteLine("I organize");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "I selling product";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => false;

        public string Work()
        {
            return "Getting pay for product ";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        public bool IsWorking =>true;

        public List<IWorkable> ListWorkers { get ; set ; }

        public void Control()
        {
            Console.WriteLine("I am a Boss......");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I am milioner.......xaxaxaxaxa");
        }

        public void Organize()
        {
            Console.WriteLine("I am boss, I organize work");
        }

        public string Work()
        {
            return "I manage work all firm";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Director director = new Director() 
            IManager director = new Director() 
            { 
             FirstName = "Ivan",
             LastName = "Ilchuk",
             Birthdate = new DateTime(1995,5,7),
             Position = "director",
             Salary = 100000
            };
       
           // director.Salary = 5000000;
            Console.WriteLine(director);

            IWorkable seller = new Seller()
            {
                FirstName = "Olga",
                LastName = "Ilchuk",
                Birthdate = new DateTime(2005, 5, 7),
                Position = "seller",
                Salary = 7000

            };
     
            //seller.Salary = 5000000;
            Console.WriteLine(seller);

            if (seller is Seller)
            {
              (seller as Seller)!.Salary = 15000;
            }
            Console.WriteLine(seller);

            Administrator admin = new Administrator();

            IManager manager = admin;
            manager.Organize();

            IWorkable worker = admin;
            worker.Work();

        }
    }
}
