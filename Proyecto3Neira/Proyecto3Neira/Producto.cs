using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proyecto3Neira
{
    public class Producto
    {
        private string namep;
        private int price;
        private string mark;
        private int stock;
        private double weight;
        private string type;
        public Producto(string namep,int price,string mark,int stock,double weight,string type)
        {
            this.namep = namep;
            this.price = price;
            this.mark = mark;
            this.stock = stock;
            this.weight = weight;
            this.type= type;
        }
        public string InfoProd()
        {
            return "Name: "+namep+", Price: "+price+", Mark "+mark+", Stock: "+stock+", Weight (lb): "+weight+", Type: "+type;
        }
        public void LessStock(int a)
            {
                stock -= a;
            }
        public string GetNameProd()
        {
            return namep;
        }
        public int GetPriceProd()
        {
            return price;
        }
        public string GetNameMark()
        {
            return mark;
        }
        public int GetStockProd()
        {
            return stock;
        }
        public double GetWeightProd()
        {
            return weight;
        }
        public string GetTypeProd()
        {
            return namep;
        }
 
    }
}
