using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
using System.Linq.Expressions;
namespace RentCar.Data.Core
{
    public interface IVehicleRepository :IRepository<Vehicle>
    {
        IEnumerable<Vehicle> GetVehiclesWithTypes(Expression<Func<Vehicle, bool>> predicate);
    }
}
