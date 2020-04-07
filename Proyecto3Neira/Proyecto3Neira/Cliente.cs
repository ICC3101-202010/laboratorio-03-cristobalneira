using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3Neira
{
    public class Cliente : Persona
    {
        Random rdn = new Random();
        private int money;
        private int frequency;
        private List<Producto> productoscliente;
        public Cliente(string name, string surname, string bday, string nation, string sex, int age, string rut, int money, int frequency) : base(name, surname, bday, nation, sex, age, rut)
        {
            this.money = money;
            this.frequency = frequency;
            productoscliente = new List<Producto>();
        }
        public int GetMoney()
        {
            return money;
        }
        public void PrintList()
        {
            foreach (Producto p in productoscliente)
            {
                Console.WriteLine(p.InfoProd());
            }
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Money: " + money + ", Frequency of shopping weekly: " + frequency + ".");
        }
        public void LessMoney(int cost)
        {
            money -= cost;
        }
        public void Buy(Registro r)
        {
            List<Cliente> c1 = r.ListClient();
            List<Empleado> e1 = r.ListEmployee();
            List<Producto> p1 = r.ListProduct();
            int u = 1;
            foreach (Producto producto in p1)
            {
                Console.WriteLine("Product nº {0} created:", u);
                Console.WriteLine(producto.InfoProd());
                u += 1;
            }
            int numclient = 1;
            foreach (Cliente cliente in c1)
            {
                Console.WriteLine("Client {1}: " + cliente.GetName() + " has {0} USD on the wallet", cliente.GetMoney(), numclient);

                foreach (Producto producto in p1)
                {
                    Console.WriteLine("Name: " + producto.GetNameProd() + " Cost: " + producto.GetPriceProd() + " Stock available: " + producto.GetStockProd());
                    Console.WriteLine("Want this product? ['yes' or 'no']");
                    string comprar = Console.ReadLine();
                    if (comprar == "yes")
                    {
                        int stk = producto.GetStockProd();
                        Console.WriteLine("Hoy much?");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        int costT = producto.GetPriceProd() * cantidad;
                        int monney = cliente.GetMoney();
                        if (cantidad <= stk && monney >= costT)
                        {
                            cliente.productoscliente.Add(producto);
                            cliente.LessMoney(costT);
                            producto.LessStock(cantidad);
                            
                        }
                        else if (cantidad >= stk)
                        {
                            Console.WriteLine("Not enough stock.");
                        }
                        else if (monney <= costT)
                        {
                            Console.WriteLine("Not enough money.");
                        }
                        else
                        {
                            Console.WriteLine("Wrong data.");
                        }
                    }
                }

            }
            int c = 0;
            Console.WriteLine("Now it will show every payment of the clients");
            string nombreempleado = "";
            DateTime now = DateTime.Now;
            string[] months = {"January", "February", "March", "April", "May",
                    "June", "July", "September", "October", "November", "December"};
            Console.WriteLine("Date: {0} of {1}.", now.Day, months[now.Month - 1]);
            foreach (Cliente cliente2 in c1)
            {
                
                Console.WriteLine("Time : {0} hrs ; {1} mins ; {2} secs", now.Hour, now.Minute, now.Second);
                Console.WriteLine("Name: " + cliente2.GetName() + " Bought: ");
                cliente2.PrintList();
                Console.WriteLine("Has {0}USD on the wallet now", cliente2.GetMoney());
                foreach (Empleado ee in e1)
                {
                    bool a = ee.Askbox();
                    if (a == true)
                    {
                        string abc = ee.GetName();
                        nombreempleado = abc;
                        c += 1;
                    }
                }
                double sumweight = 0;
                if (c >= 1)
                {

                    Console.WriteLine("At the box {0}, attended by {1}", rdn.Next(1, c), nombreempleado);
                }
                else
                {
                    Console.WriteLine("Theres no employee in boxes, {0} bought at autoservice!", cliente2.GetName());
                }

                foreach (Producto p in cliente2.productoscliente)
                {
                    double y = p.GetWeightProd();
                    sumweight += y;
                }
                if (sumweight >= 350)
                {
                    Console.WriteLine(cliente2.GetName() + " Have used more than 1 shopping car");
                }
                Console.WriteLine("Shopping cart weights: {0}", sumweight);



            }


        }
        public void Buy2(Registro r)//BONUS//
        {
            List<Cliente> c1 = r.ListClient();
            List<Empleado> e1 = r.ListEmployee();
            List<Producto> p1 = r.ListProduct();
            int u = 1;
            foreach (Producto producto in p1)
            {
                Console.WriteLine("Product nº {0} created:", u);
                Console.WriteLine(producto.InfoProd());
                u += 1;
            }
            int numclient = 1;
            foreach (Cliente cliente in c1)
            {
                Console.WriteLine("Client {1}: " + cliente.GetName() + " has {0} USD on the wallet", cliente.GetMoney(), numclient);
                
                for (int k = 0; k < 5; k++)
                {

                    Producto productt = p1[rdn.Next(0,20)];
                    string producttName = productt.GetNameProd();
                    int producttStock = productt.GetStockProd();
                    int producttPrice = productt.GetPriceProd();
                    Console.WriteLine("Name: " + producttName + " Cost: " + producttPrice + "USD Stock available: " + producttStock);
                    int cantidad = rdn.Next(0, 2);
                    int costt = cantidad * producttPrice;
                    cliente.productoscliente.Add(productt);
                    cliente.LessMoney(costt);
                    productt.LessStock(cantidad);
                    int stockkkk = producttStock - cantidad;
                }
                numclient += 1;
                
            }
            int c = 0;
            Console.WriteLine("Now it will show every payment of the clients");
            string nombreempleado = "";
            DateTime now = DateTime.Now;
            string[] months = {"January", "February", "March", "April", "May",
                    "June", "July", "September", "October", "November", "December"};
            Console.WriteLine("Date: {0} of {1}.", now.Day, months[now.Month - 1]);
            foreach (Cliente cliente2 in c1)
            {

                Console.WriteLine("Time : {0} hrs ; {1} mins ; {2} secs", now.Hour, now.Minute, now.Second);
                Console.WriteLine("Client {o}, Name: " + cliente2.GetName() + " Bought: ",cliente2.GetName());
                cliente2.PrintList();
                Console.WriteLine("Has {0}USD on the wallet now", cliente2.GetMoney());
                foreach (Empleado ee in e1)
                {
                    bool a = ee.Askbox();
                    if (a == true)
                    {
                        string abc = ee.GetName();
                        nombreempleado = abc;
                        c += 1;
                    }
                }
                double sumweight = 0;
                if (c >= 1)
                {

                    Console.WriteLine("At the box {0}, attended by {1}", rdn.Next(1, c), nombreempleado);
                }
                else
                {
                    Console.WriteLine("Theres no employee in boxes, {0} bought at autoservice!", cliente2.GetName());
                }

                foreach (Producto p in cliente2.productoscliente)
                {
                    double y = p.GetWeightProd();
                    sumweight += y;
                }
                if (sumweight >= 350)
                {
                    Console.WriteLine(cliente2.GetName() + " Have used more than 1 shopping car");
                }
                Console.WriteLine("Shopping cart weights: {0}", sumweight);



            }
        }
    }
}
