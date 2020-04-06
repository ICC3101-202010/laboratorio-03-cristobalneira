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


        public Cliente(string name, string surname, string bday, string nation, string sex, int age, string rut, int money,int frequency) : base (name,surname,bday,nation,sex,age,rut)
        {
            this.money = money;
            this.frequency = frequency;
            productoscliente = new List<Producto>();
        }
        public int GetMoney()
        {
            return money;
        }
        //Comprar
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
            Console.WriteLine("Money: " + money + ", Frequency of shopping weekly: "+frequency+".");
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
            Console.WriteLine("The products you made are: ");
            foreach (Producto producto in p1)
            {
                Console.WriteLine(producto.InfoProd());
            }
            int numclient = 1;
            foreach (Cliente cliente in c1)
            {
                Console.WriteLine("Client {1}: " + cliente.GetName() + " has {0} USD on the wallet", cliente.GetMoney(), numclient);
                foreach (Producto producto in p1)
                {
                    Console.WriteLine("Name: "+producto.GetNameProd() + " Cost: "+producto.GetPriceProd() + " Stock available: "+producto.GetStockProd());
                    Console.WriteLine("Want this product? ['yes' or 'no']");
                    string comprar = Console.ReadLine();
                    if (comprar == "yes")
                    {
                        int stk = producto.GetStockProd();
                        Console.WriteLine("Hoy much?");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        int costT = producto.GetStockProd() * cantidad;
                        if (cantidad<=stk && money >= costT)
                        {

                            productoscliente.Add(producto);
                            cliente.LessMoney(costT);
                        }
                        else if (cantidad>= stk)
                        {
                            Console.WriteLine("Not enough stock.");
                        }
                        else if (money <= costT)
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
            foreach (Cliente cliente2 in c1)
            {
                Console.WriteLine("Name: " + cliente2.GetName() + " Bought: ");
                cliente2.PrintList();
                Console.WriteLine("Has {0}USD on the wallet now", cliente2.GetMoney());
                foreach (Empleado ee in e1)
                {
                    bool a = ee.Askbox();
                    if (a == true)
                    {
                        string abc = ee.GetName();
                        nombreempleado =abc;
                        c += 1;
                    }
                }
                double sumweight = 0;
                Console.WriteLine("At the box {0}, attended by {1}",rdn.Next(1, c), nombreempleado);
                foreach(Producto p in cliente2.productoscliente)
                {
                    double y=p.GetWeightProd();
                    sumweight += y;
                }
                if (sumweight >= 350)
                {
                    Console.WriteLine(cliente2.GetName()+" Have used more than 1 shopping car");
                }
                Console.WriteLine("Shopping car weights: {0}",sumweight);
            }

        }
    }

}
