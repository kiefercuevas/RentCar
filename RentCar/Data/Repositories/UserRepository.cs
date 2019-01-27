using System;
using System.Linq.Expressions;
using RentCar.Data.Core;
using RentCar.Models;
using System.Data.Entity;
using System.Linq;

namespace RentCar.Data.Repositories
{
    public class UserRepository :Repository<User>,IUserRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public UserRepository(RentCarContex context)
            : base(context)
        {
        }

        public User GetUserWithEmployeeAndRoles(Expression<Func<User, bool>> predicate)
        {
            return _RentCarContex.Users.Include(u => u.Employee)
                .Include(u => u.Role)
                .SingleOrDefault(predicate);
        }
    }
}
