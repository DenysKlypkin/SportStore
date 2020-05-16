using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
   public class EFProductRepository : IProductRepository
   {
        EFDbContext context = new EFDbContext();
        public IQueryable<Product> Products => context.Products;
   }
}
