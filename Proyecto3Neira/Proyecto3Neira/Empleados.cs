using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proyecto3Neira
{
    public class Empleado : Persona
    {
        private string job;
        private int salary;
        private int hrI;
        private int hrF;
        public Empleado(string name, string surname, string bday, string nation, string sex, int age, string rut, string job) : base(name, surname, bday, nation, sex, age, rut)
        {
            this.job = job;
            if (job == "cleaning")
            {
                salary = 10;
                hrI = 8;
                hrF = 21;
            }
            else if (job == "segurity")
            {
                salary = 20;
                hrI = 8;
                hrF = 21;
            }
            else if (job == "box")
            {
                salary = 35;
                hrI = 8;
                hrF = 21;

            }
            else if (job == "staff")
            {
                salary = 20;
                hrI = 12;
                hrF = 20;
            }
            else if (job == "supervisor")
            {
                salary = 40;
                hrI = 12;
                hrF = 20;
            }
            else if (job == "assistant")
            {
                salary = 60;
                hrI = 15;
                hrF = 21;
            }
            else
            {
                salary = 100;
                hrI = 17;
                hrF = 21;
            }

        }
        public void Asksalary(Persona p)
        {
            string name = p.GetName();
            Console.WriteLine("Salary: "+salary+"USD Do you want to increase "+name+" salary?   ['yes' or 'no']");
            string a =Console.ReadLine();
            if (a == "yes")
            {
                Console.WriteLine("How much? [10-100]");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b >=10 && b <= 100)
                {
                    Console.WriteLine("Salary increased by: "+b+"USD");
                    salary +=  b;
                }
                else
                {
                    Console.WriteLine("Wrong data im sorry! No changes made.");
                }
            }
            else
            {
                Console.WriteLine(name+"Does not got more salary");
            }
        }
        public void Askjob(Persona p)
        {
            string name = p.GetName();
            Console.WriteLine("Do you want to  " + name + "change job?  ['yes' or 'no']");
            string a = Console.ReadLine();
            if (a == "yes")
            {
                Console.WriteLine("Which one? [cleaning, segurity, box, staff, supervisor, assistant, bos]");
                string b = Console.ReadLine();

                if (job == b)
                {
                    Console.WriteLine("Already has that job!");
                }
                else if (b=="cleaning" || b == "segurity" || b == "box" || b == "staff" || b == "supervisor" || b == "assistant" || b == "bos" )
                {
                    Console.WriteLine(name + "changed job to : "+b);
                    job = b;
                }
                else
                {
                    Console.WriteLine("Wrong data im sorry! No changes made.");
                }
            }
            else
            {
                Console.WriteLine(name + "Does not changed job");
            }
        }
        public void Askhr(Persona p)
        {
            string name = p.GetName();
            Console.WriteLine("Do you want to change {0} time spent at work? ['yes' or 'no']", name);
            string a = Console.ReadLine();
            if (a == "yes")
            {
                Console.WriteLine("Hour work arrival:");
                Console.WriteLine(hrI);
                Console.WriteLine("Hour work gone:");
                Console.WriteLine(hrF);
                Console.WriteLine("Which you wanna change hour arrival [a] or gone [g]?");
                string h = Console.ReadLine();
                if (h == "a")
                {
                    Console.WriteLine("For what hour u wanna change it?");
                    int change = Convert.ToInt32(Console.ReadLine());
                    if (change <= hrF)
                    {
                        hrI = change;
                        Console.WriteLine("Hour changed.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong data sorry! No changes made.");
                    }
                }
                else if (h == "g")
                {
                    Console.WriteLine("For what hour u wanna change it?");
                    int change = Convert.ToInt32(Console.ReadLine());
                    if (change >= hrI)
                    {
                        hrF = change;
                        Console.WriteLine("Hour changed.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong data sorry! No changes made.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong data sorry! No changes made.");
                }
            }
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Job: {0}, Salary {1}USD, Hour work arrival: {2}, Hour work gone: {3}",job,salary,hrI,hrF);
        }
        
    }
}
