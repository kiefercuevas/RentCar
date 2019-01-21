using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
namespace RentCar.Data.Core
{
    public interface IInspectionRepository :IRepository<Inspection>
    {
        Inspection GetInspectionWithAll(Expression<Func<Inspection, bool>> predicate);
    }
}
