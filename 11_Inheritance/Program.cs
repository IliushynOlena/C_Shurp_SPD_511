using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _11_Inheritance
{
    abstract class Person //: Object
    {
        protected string name;
        private readonly DateTime birthdate;
        public Person()
        {
            name = "no name";
            birthdate = new DateTime();
        }
        public Person(string n, DateTime b)
        {
            name = n;
            if( b > DateTime.Now)
            {
                birthdate = new DateTime();
            }
            else
            {
                birthdate = b;
            }
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}. " +
                $"Birthdate : {birthdate.ToShortDateString()}");
        }
        public override string ToString()
        {
            return $"Name : {name}. " +
                $"Birthdate : {birthdate.ToShortDateString()}";
        }
        public abstract void DoWork();// = 0 
    }
    //class Child : BaseClass, Inteface1, Interface2
    class Worker: Person
    {
        private decimal salary;

        public decimal Salary//value =s --->set
        {
            get { return salary; }
            set { this.salary = value >0 ? value : 0; }
        }
        public Worker(): base()
        {
            Salary = 0;
        }
        public Worker(string n, DateTime b, decimal s):base(n,b)
        {
            Salary = s;//value =s
        }
        public override void DoWork()
        {
            Console.WriteLine("Doing some work");
        }
        public override void Print() 
        {
            base.Print();
            Console.WriteLine($"Salary : {Salary}");
        }
    }
    sealed  class Programmer : Worker
    {
        public int CodeLines { get; private set; }
        public Programmer():base()
        {
            CodeLines = 0;
        }
        public Programmer(string n, DateTime b, decimal s):base(n,b,s)
        {
            CodeLines = 0;
        }
        public sealed override void DoWork()
        {
            Console.WriteLine("Write C# code");
        }
        public void WriteCode(int lines)
        {
            CodeLines += lines;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Code Lines : {CodeLines}");
        }
    }
    class TeamLead : Worker
    {
        public int CountProjects { get; set; }
        public TeamLead():base()
        {
            CountProjects = 0;
        }
        public TeamLead(string n, DateTime b, decimal s):base(n,b,s)
        {
            CountProjects = 0;
        }
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team projects");
        //    Console.WriteLine($"Count projcts : {CountProjects}");
        //}
    }



    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Vova",new DateTime(2000,5,7),15000);

            worker.DoWork();
            worker.Print();


            Person[] persons = new Person[]
            {
                //new Person(),
                worker,
                new Programmer("Olga",new DateTime(2005,4,12),45000),
                new TeamLead("Taras",new DateTime(2000,3,3),80000)
            };


            foreach (var p in persons)
            {
                Console.WriteLine("\n----------------Info---------------");
                p.Print();
                p.DoWork();
            }

            Programmer pr = null;
            // 1  ---- use cast()
            try
            {
                pr = (Programmer)persons[2];
                Console.WriteLine(pr.CodeLines);
                pr.DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // 2 ---------- use as
            pr = (persons[1] as Programmer)!;
            if( pr == null)
            {
                Console.WriteLine("Incorrect type...");
            }
            else
            {
                Console.WriteLine(pr.CodeLines);
                pr.DoWork();
            }
            // 3- use as is
            if(persons[2] is Programmer)
            {
                pr = (persons[2] as Programmer)!;
                Console.WriteLine(pr.CodeLines);
                pr.DoWork();
            }


        }
    }
}
