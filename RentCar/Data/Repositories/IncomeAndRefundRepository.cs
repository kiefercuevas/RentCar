using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Models;
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

    }
}
