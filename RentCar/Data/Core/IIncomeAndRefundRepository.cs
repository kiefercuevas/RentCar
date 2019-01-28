using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
namespace RentCar.Data.Core
{
    public interface IIncomeAndRefundRepository :IRepository<IncomeAndRefund>
    {
        IncomeAndRefund GetIncomeAndRefundWithAll(int id);
        IEnumerable<IncomeAndRefund> GetIncomeAndRefundsWithAll(Expression<Func<IncomeAndRefund,bool>> predicate);
    }
}
