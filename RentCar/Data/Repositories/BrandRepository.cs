using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Models;
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

    }
}
