using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proyecto3Neira
{
    public class Registro
    {
        private List<Producto> productos;
        private List<Empleado> empleados;
        private List<Cliente> clientes;
        public Registro()
        {
            empleados = new List<Empleado>();
            productos = new List<Producto>();
            clientes = new List<Cliente>();
        }
        public void AddProduct(Producto p)
        {
            productos.Add(p);
        }
        public void AddEmployee(Empleado e)
        {
            empleados.Add(e);
        }
        public void AddClient(Cliente c)
        {
            clientes.Add(c);
        }
        public void SeeClients()
        {
                int c = 1;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine("Customer nº{0}:", c);
                    c += 1;
                    cliente.Info();
                }
                if (c == 1)
                {
                    Console.WriteLine("Program does not have clients.");
                }
        
        }
        public List<Cliente> ListClient()
        {
            return clientes;
        }
        public List<Producto> ListProduct()
        {
            return productos;
        }
        public List<Empleado> ListEmployee()
        {
            return empleados;
        }
        public void SeeEmployees()
        {
                int c = 1;
                foreach (Empleado empleado in empleados)
                {
                    Console.WriteLine("Employee nº{0}:", c);
                    c += 1;
                    empleado.Info();
                }
                if (c == 1)
                {
                    Console.WriteLine("Program does not have employees.");
                }
            
          
        }
        public void SeeProducts()
        {

                int c = 1;
                foreach (Producto producto in productos)
                {
                    Console.WriteLine("Product nº{0}:",c);
                    c += 1;
                    producto.InfoProd();
                }
                if (c == 1)
                {
                    Console.WriteLine("Program does not have products.");
                }
            
        }
    }

}
