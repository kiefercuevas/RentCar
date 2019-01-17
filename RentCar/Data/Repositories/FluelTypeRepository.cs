using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
using RentCar.Data.Core;
namespace RentCar.Data.Repositories
{
    public class FluelTypeRepository :Repository<FuelType>,IFluelTypeRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public FluelTypeRepository(RentCarContex contex)
            :base(contex)
        {

        }
    }
}
