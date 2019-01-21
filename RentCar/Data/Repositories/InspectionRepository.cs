using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Models;
using System.Data.Entity;
namespace RentCar.Data.Repositories
{
    public class InspectionRepository :Repository<Inspection>,IInspectionRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public InspectionRepository(RentCarContex context)
            : base(context)
        {

        }

        public Inspection GetInspectionWithAll(Expression<Func<Inspection, bool>> predicate)
        {
            return _RentCarContex.Inspections
                .Include(i => i.FluelQuantity)
                .Include(i => i.RubberStates)
                .SingleOrDefault(predicate);
        }
    }
}
