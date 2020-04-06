using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3Neira
{
    public class Cliente : Persona
    {
        
        private int money;
        private int frequency;

        public Cliente(string name, string surname, string bday, string nation, string sex, int age, string rut, int money,int frequency) : base (name,surname,bday,nation,sex,age,rut)
        {
            this.money = money;
            this.frequency = frequency;
        }
        //Comprar

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
            Console.WriteLine("Client {1}: "+cliente.GetName()+" has {0}USD on the wallet",money, numclient);





            Console.WriteLine(p.InfoProd());
            Console.WriteLine("How much of {0} do you want to buy");
            int a = Convert.ToInt32(Console.ReadLine());
            int stock = p.GetStockProd();
            int moneyprod = p.GetPriceProd();
            if (stock >= a && money >= moneyprod )
            {

                r.AddProduct(p);
                p.LessStock(a);
                c.LessMoney(p.GetPriceProd());
                Console.WriteLine("Product {0} was added to cart");
            }
            else if (stock <= a)
            {
                Console.WriteLine("Not enough of stock!");
            }
            else
            {
                Console.WriteLine("No money enough you need {0} and have {1}",moneyprod,money);
            }
        }
    }

}
