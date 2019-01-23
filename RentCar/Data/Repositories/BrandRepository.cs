using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Models;
using System.Data.Entity;
namespace RentCar.Data.Repositories
{
    public class BrandRepository :Repository<Brand>,IBrandRepository
    {
        public RentCarContex _RentCarContex{
            get { return _Context as RentCarContex; }
        }
        public BrandRepository(RentCarContex context)
            : base(context)
        {
        }

        public Brand GetBrandWithAll(int id)
        {
            return _Context.Brands
                .Include(b => b.Vehicles)
                .Include(b => b.Models)
                .SingleOrDefault(b => b.BrandID == id);
        }
    }
}
