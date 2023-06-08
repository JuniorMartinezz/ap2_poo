using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ap2_poo
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public double Price { get; set; }
        public Supplier Supplier { get; set; }
        public static String CurrencyFormatter(double price){
            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", price);
        }
    }
}