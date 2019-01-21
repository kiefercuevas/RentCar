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
    public class IncomeAndRefundRepository :Repository<IncomeAndRefund>,IIncomeAndRefundRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public IncomeAndRefundRepository(RentCarContex context)
            : base(context)
        {

        }

        public IncomeAndRefund GetIncomeAndRefundWithAll(int id)
        {
            return _RentCarContex.IncomeAndRefunds
                .Include(i => i.Employee)
                .Include(i => i.Client)
                .Include(i => i.Client.PersonType)
                .Include(i => i.Vehicle)
                .Include(i => i.Vehicle.VehicleType)
                .Include(i => i.Vehicle.Brand)
                .Include(i => i.Vehicle.Model)
                .Include(i => i.Vehicle.FluelType)
                .SingleOrDefault(i => i.IncomeID == id);
        }
    }
}
