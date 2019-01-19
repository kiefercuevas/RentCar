using RentCar.Models;
using System;
using System.Linq.Expressions;

namespace RentCar.Data.Core
{
    public interface IUserRepository :IRepository<User>
    {
        User GetUserWithEmployeeAndRoles(Expression<Func<User, bool>> predicate);
    }
}
