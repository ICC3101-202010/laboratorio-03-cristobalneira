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
            //Hice una clase Registro donde guardaba toda la informacion, es decir, listas de objetos para así poder manipular
            Registro r = new Registro();
            Cliente unusedclient = new Cliente("","","","","",0,"",0,0);
            DateTime now = DateTime.Now;
            string[] months = {"January", "February", "March", "April", "May",
                    "June", "July", "September", "October", "November", "December"};
            //Interfaz
            Console.WriteLine("¡Welcome to Cristobal`s virtual supermarket 'Publik'!");
            Console.WriteLine("Today`s time : {0} hrs ; {1} mins ; {2} secs", now.Hour, now.Minute, now.Second);
            Console.WriteLine("TIME 08:00 AM.");
            Console.WriteLine("Welcome to the menu.");
            //1//
            Console.WriteLine("0 to exit, 1 to enter manual program, 2 to enter automatic program");
            int you = Convert.ToInt32(Console.ReadLine());
            if (you == 1)
            {
                Console.WriteLine("There is no clients/employees/products created yet on the program.");
                Console.WriteLine("Remember: ¡Your shopping cart can`t weight more than 350 Lbs!");
                int a = 2;
                Console.WriteLine("¡¡Program finishes in NUMBER 4!!");
                do
                {
                    Console.WriteLine("0 for exit, 1 create customer, 2 create employe, 3 create product, 4 buy products/get receipt for every client and exit.");
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
                        Console.WriteLine("It`s stock? [0-10]");
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
                        break;
                    }
                    //Change hr employee
                    else if (quest == 5)
                    {
                        foreach (Empleado p in r.ListEmployee())
                        {
                            p.Askhr(p);
                        }


                    }
                    //Change job employee
                    else if (quest == 6)
                    {
                        foreach (Empleado p in r.ListEmployee())
                        {
                            p.Askjob(p);
                        }

                    }
                    //Change salary employee
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
            }
            //BONUS//
            else if (you == 2)
            {
                //GENERADOR DE OBJETOS
                Random rdn = new Random();
                Registro r1 = new Registro();
                Cliente unusedclient2 = new Cliente("", "", "", "", "", 0, "", 0, 0);
                for (int k = 0; k < 30; k++)
                {
                    string[] nombresH = { "Elvis", "Armando", "Esteban", "Felipe","Roberto","Firmino","Lionel","Cristiano","Sebastian","Alexis" };
                    string[] nombresM = { "Elba", "Debora", "Elsa","Maria","Camila","Roberta","Cristina","Ana","Isabel" };
                    string[] surnamesH = { "Tek", "Casas", "Dido","Molina","Piñera","Toral","Contreras" };
                    string[] surnamesM = { "Laso", "Zurita", "Melo", "Polindo", "Pallo", "Mocha" };
                    string[] nations = { "Haiti", "Chile", "Venezuela", "Peru", "Colombia", "Niger", "Madagascar", "China" };
                    string[] sexs = { "Male", "Female" };
                    string[] nombreprod = { "Chips", "Cookies", "Cocacola", "Pepsi", "Bread", "Milk", "Water", "Cheese", "Jam", "Cereals", "Brownies", "Chocolate" };
                    string[] markprod = { "Publik", "Jumbo", "Lider", "Unimarc", "ABC", "Not company" };
                    string[] typeprod = { "Vegetable", "Non-Vegetable" };
                    string[] jobe = { "box","cleaning","segurity","supervisor","assistant","bos" };
                    string sex = sexs[rdn.Next(0, 2)];
                    string name = "";
                    string surname = "";
                    if (sex == "Male")
                    {
                        string nameb = nombresH[rdn.Next(0, 10)];
                        name = nameb;
                        string surnameb = surnamesH[rdn.Next(0, 7)];
                        surname = surnameb;
                    }
                    else
                    {
                        string nameb = nombresM[rdn.Next(0, 3)];
                        name = nameb;
                        string surnameb = surnamesM[rdn.Next(0, 6)];
                        surname = surnameb;
                    }
                    string nation = nations[rdn.Next(0, 6)];
                    int age = rdn.Next(12, 85);
                    string a1 = Convert.ToString(rdn.Next(0, 10));
                    string a2 = Convert.ToString(rdn.Next(0, 10));
                    string a3 = Convert.ToString(rdn.Next(0, 10));
                    string a4 = Convert.ToString(rdn.Next(0, 10));
                    string a5 = Convert.ToString(rdn.Next(0, 10));
                    string a6 = Convert.ToString(rdn.Next(0, 10));
                    string a7 = Convert.ToString(rdn.Next(0, 10));
                    string a8 = Convert.ToString(rdn.Next(0, 10));
                    string a9 = Convert.ToString(rdn.Next(0, 10));
                    string b = Convert.ToString(rdn.Next(1, 3));
                    string rut = b + a1 + "." + a2 + a3 + a4 + "." + a5 + a6 + a7 + "-" + a8;
                    string bday = Convert.ToString(rdn.Next(0, 3)) + a9 + " of " + months[rdn.Next(0, 11)];
                    int money = rdn.Next(1000, 10000);
                    int frequency = rdn.Next(1, 7);

                    int pricep = money / rdn.Next(100, 1000);
                    string nameprods = nombreprod[rdn.Next(0, 12)];
                    string markprods = markprod[rdn.Next(0, 6)];
                    string typeprods = typeprod[rdn.Next(0, 2)];
                    int stockss = rdn.Next(10, 50);
                    double weightprodd = rdn.Next(0, 100)*0.3;
                    string jobee = jobe[rdn.Next(0, 6)];
                    //OBJETOS
                    Cliente cx = new Cliente(name, surname, bday, nation, sex, age, rut, money, frequency);
                    Producto px = new Producto(nameprods, pricep, markprods, stockss, weightprodd, typeprods);
                    Empleado ex1 = new Empleado(name, surname, bday, nation, sex, age, rut, "Box");
                    Empleado ex2 = new Empleado(name, surname, bday, nation, sex, age, rut, jobee);

                    r1.AddProduct(px);
                    if (k >= 15)
                    {
                        r1.AddClient(cx);
                    }
                    if (k >= 24)
                    {
                        r1.AddEmployee(ex2);
                    }
                    else if (k == 19)
                    {
                        r1.AddEmployee(ex1);
                    }
                } 
                //PROCESO
                unusedclient2.Buy2(r1);
            }
            Console.WriteLine("Thanks you to prefer Virtual Supermarket 'Publik'!");
        }
    }
}
