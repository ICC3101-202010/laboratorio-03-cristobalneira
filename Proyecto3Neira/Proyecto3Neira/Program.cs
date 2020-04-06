using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Registro r = new Registro();
            Cliente unusedclient = new Cliente("","","","","",0,"",0,0);
            DateTime now = DateTime.Now;
            string[] months = {"January", "February", "March", "April", "May",
                    "June", "July", "September", "October", "November", "December"};
            Console.WriteLine("¡Welcome to Cristobal`s virtual supermarket 'Publik'!");
            Console.WriteLine("Today is {0} of {1}.", now.Day, months[now.Month - 1]);
            Console.WriteLine("TIME 08:00 AM.");
            Console.WriteLine("Welcome to the menu.");
            //1 do
            Console.WriteLine("There is no clients/employees/products created yet on the program.");
            Console.WriteLine("Remember: ¡Your shopping cart can`t weight more than 350 Lbs!"); int a = 2;
            do
            {
                Console.WriteLine("0 for exit, 1 create customer, 2 create employe, 3 create product, 4 buy products and get receipt for every client.");
                Console.WriteLine("[Extra] 5 change hour of an employee, 6 change job of an employee, 7 change salary of an employee.");
                int quest = Convert.ToInt32(Console.ReadLine());
                //Create customer
                if (quest == 1)
                {
                    Console.WriteLine("You want to create a Customer: ");
                    Console.WriteLine("His/Her name?");
                    string namec = Console.ReadLine();
                    Console.WriteLine("His/Her surname?");
                    string surnamec = Console.ReadLine();
                    Console.WriteLine("His/Her birth date? ['DD of MM'].");
                    string bdayc = Console.ReadLine();
                    Console.WriteLine("His/Her nation?");
                    string nationc = Console.ReadLine();
                    Console.WriteLine("His/Her sex? [Male or Female]");
                    string sexc = Console.ReadLine();
                    Console.WriteLine("His/Her age?");
                    int agec = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("His/Her rut? [NN.NNN.NNN-N]");
                    string rutc = Console.ReadLine();
                    Console.WriteLine("His/Her money? [1000-10000]");
                    int moneyc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("His/Her frequency weekly? [0-7].");
                    int freqc = Convert.ToInt32(Console.ReadLine());
                    Cliente cx = new Cliente(namec, surnamec, bdayc, nationc, sexc, agec, rutc, moneyc, freqc);
                    r.AddClient(cx);
                    Console.WriteLine("Want to see every customer on the supermarket? ['yes' or 'no']");
                    string b = Console.ReadLine();
                    if (b == "yes")
                    {
                        r.SeeClients();
                    }
                    }
                //Create Employee
                else if (quest == 2)
                {
                    Console.WriteLine("You want to create a Employee: ");
                    Console.WriteLine("His/Her name?");
                    string namec = Console.ReadLine();
                    Console.WriteLine("His/Her surname?");
                    string surnamec = Console.ReadLine();
                    Console.WriteLine("His/Her birth date? ['DD of MM']");
                    string bdayc = Console.ReadLine();
                    Console.WriteLine("His/Her nation?");
                    string nationc = Console.ReadLine();
                    Console.WriteLine("His/Her sex? [Male or Female]");
                    string sexc = Console.ReadLine();
                    Console.WriteLine("His/Her age?");
                    int agec = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("His/Her rut? [NN.NNN.NNN-N]");
                    string rutc = Console.ReadLine();
                    Console.WriteLine("His/Her job? [cleaning, segurity, box, staff, supervisor, assistant, bos]");
                    string jobc = Console.ReadLine();
                    Empleado ex = new Empleado(namec, surnamec, bdayc, nationc, sexc, agec, rutc, jobc);
                    r.AddEmployee(ex);
                    Console.WriteLine("Want to see every employee on the supermarket? ['yes' or 'no']");
                    string b = Console.ReadLine();
                    if (b == "yes")
                    {
                        r.SeeEmployees();
                    }
                }
                //Create Product
                else if (quest == 3)
                {
                    Console.WriteLine("You want to create a Product: ");
                    Console.WriteLine("It`s name?");
                    string namep = Console.ReadLine();
                    Console.WriteLine("It`s price? [1-1000]");
                    int pricep = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("It`s mark?");
                    string markp = Console.ReadLine();
                    Console.WriteLine("It`s stock? [0-100]");
                    int stockp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("It's weight? [0-55] (Lbs)");
                    double weightp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("It`s type? ['Non-vegetable , Vegetable]'");
                    string typep = Console.ReadLine();
                    Producto px = new Producto(namep, pricep, markp, stockp, weightp, typep);
                    r.AddProduct(px);
                    Console.WriteLine("Want to see every product on the supermarket? ['yes' or 'no']");
                    string b = Console.ReadLine();
                    if (b == "yes")
                    {
                        r.SeeProducts();
                    }
                }
                //Buy & receipt
                else if (quest == 4)
                {
                    unusedclient.Buy(r);
                }

                else if (quest == 5)
                {
                    foreach (Empleado p in r.ListEmployee())
                    {
                        p.Askhr(p);
                    }


                }
                else if (quest == 6)
                {
                    foreach (Empleado p in r.ListEmployee())
                    {
                        p.Askjob(p);
                    }

                }
                else if (quest == 7)
                {
                    foreach (Empleado p in r.ListEmployee())
                    {
                        p.Asksalary(p);
                    }

                }
                else
                {
                    a = 0;
                }

            } while (a != 0);
            Console.WriteLine("Thanks you to prefer Virtual Supermarket Publik!");
        }
    }
}
