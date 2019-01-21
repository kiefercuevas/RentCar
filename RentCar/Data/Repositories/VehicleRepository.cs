using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Models;
using System.Data.Entity;
using System.Linq.Expressions;
namespace RentCar.Data.Repositories
{
    public class VehicleRepository :Repository<Vehicle>,IVehicleRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public VehicleRepository(RentCarContex context)
            : base(context)
        {

        }

        public IEnumerable<Vehicle> GetVehiclesWithTypes(Expression<Func<Vehicle,bool>> predicate)
        {
            return _RentCarContex.Vehicles.Include(v => v.VehicleType).Where(predicate);
        }

        public IEnumerable<Vehicle> GetVehiclesWithAll(Expression<Func<Vehicle, bool>> predicate)
        {
            return _RentCarContex.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Model)
                .Include(v => v.VehicleType)
                .Include(v => v.FluelType)
                .Where(predicate)
                .ToList();
        }

        public IEnumerable<Vehicle> GetVehiclesWithAll()
        {
            return _RentCarContex.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Model)
                .Include(v => v.VehicleType)
                .Include(v => v.FluelType)
                .ToList();
        }
    }
}
