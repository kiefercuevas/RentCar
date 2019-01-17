using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
using RentCar.Data.Core;
namespace RentCar.Data.Repositories
{
    public class FuelTypeRepository :Repository<FuelType>,IFuelTypeRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public FuelTypeRepository(RentCarContex contex)
            :base(contex)
        {

        }
    }
}
