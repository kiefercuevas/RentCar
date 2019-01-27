using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
using RentCar.Data.Core;
using System.Linq.Expressions;
using System.Data.Entity;
namespace RentCar.Data.Repositories
{
    public class FluelTypeRepository :Repository<FluelType>,IFluelTypeRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public FluelTypeRepository(RentCarContex contex)
            :base(contex)
        {

        }

        public IEnumerable<FluelType> GetFluelTypesWithAll(Expression<Func<FluelType, bool>> predicate)
        {
            return _RentCarContex.FluelType.Include(fl => fl.Vehicles)
                .Where(predicate)
                .ToList();
        }
    }
}
