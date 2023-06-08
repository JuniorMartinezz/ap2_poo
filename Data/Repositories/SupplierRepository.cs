using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ap2_poo
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly DataContext context;

        public SupplierRepository()
        {
            this.context = new DataContext();
        }

        public void Delete(int entityId)
        {
            var s = GetById(entityId);
            context.Suppliers.Remove(s);
            context.SaveChanges();
        }
        
        public IList<Supplier> GetAll()
        {
            return context.Suppliers.Include(x => x.City).ToList();
        }

        public Supplier GetById(int entityId)
        {
            return context.Suppliers.Include(x => x.City).SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(Supplier entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Supplier entity)
        {
            context.Suppliers.Update(entity);
            context.SaveChanges();
        }
    }
}
