﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
namespace RentCar.Data.Core
{
    public interface IVehicleTypeRepository:IRepository<VehicleType>
    {
        VehicleType GetVehicleTypeWithAll(int id);
    }
}
