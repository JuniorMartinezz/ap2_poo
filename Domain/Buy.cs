using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ap2_poo
{
    public class Buy
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public Product Product { get; set; }

/*         public Buy(int id, DateTime date, Product product, int amount, double totalPrice){
            this.Id = id;
            this.Date = date;
            Products.Add(product);
            this.Amount = amount;
            this.TotalPrice = totalPrice;
        } */
    }
}