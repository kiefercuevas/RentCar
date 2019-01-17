using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Models;
namespace RentCar.Data.Repositories
{
    public class RoleRepository :Repository<Role> ,IRoleRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public RoleRepository(RentCarContex context)
            : base(context)
        {
        }
    }
}
