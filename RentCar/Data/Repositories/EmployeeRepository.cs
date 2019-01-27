using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
using RentCar.Data.Core;
using System.Linq.Expressions;
using System.Data.Entity;
namespace RentCar.Data.Repositories
{
    public class EmployeeRepository :Repository<Employee>,IEmployeeRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public EmployeeRepository(RentCarContex contex)
            :base(contex)
        {
        }

        public IEnumerable<Employee> GetEmployeesWithAll(Expression<Func<Employee, bool>> predicate)
        {
            return _RentCarContex.Employees
                .Include(e => e.Users.Select(u => u.Role))
                .Include(e => e.WorkShift)
                .Where(predicate)
                .ToList();
        }

    }
}
