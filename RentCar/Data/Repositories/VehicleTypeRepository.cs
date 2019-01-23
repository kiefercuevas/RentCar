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
    public class VehicleTypeRepository :Repository<VehicleType>,IVehicleTypeRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public VehicleTypeRepository(RentCarContex contex)
            : base(contex)
        {
        }

        public VehicleType GetVehicleTypeWithAll(int id)
        {
            return _Context.VehicleTypes.Include(vt => vt.Vehicles)
                .SingleOrDefault(vt => vt.VehicleTypeID == id);
        }
    }
}
