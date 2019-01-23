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
    public class ModelRepository :Repository<Model>,IModelRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public ModelRepository(RentCarContex context)
            : base(context)
        {

        }

        public Model GetModelWithAll(int id)
        {
            return _RentCarContex.Models.Include(m => m.Vehicles)
                .SingleOrDefault(m => m.ModelID == id);
        }
    }
}
