using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_WpfApp
{
    public enum Сategories 
    { 
       food,
        appliances

    }
    public class Product
    {
       
        public string NameProduct { get; set;}
        public int Cost { get; set; }
        public string Image { get; set; }
        public Сategories Category { get; set; }
    }
}
