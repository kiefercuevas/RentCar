﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
namespace RentCar.Data.Core
{
    public interface IModelRepository :IRepository<Model>
    {
        Model GetModelWithAll(int id);
    }
}
