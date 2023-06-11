using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ap2_poo.Domain;

namespace ap2_poo
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public long Cnpj { get; set; }
        public City City { get; set; }

/*         public Supplier(string name, string phone, City city, long cnpj)
        {
            this.Name = name;
            this.Phone = phone;
            this.City = city;
            this.Cnpj = cnpj;
        } */
    }
}