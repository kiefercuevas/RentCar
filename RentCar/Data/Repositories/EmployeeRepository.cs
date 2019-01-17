using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Models;
using RentCar.Data.Core;
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
    }
}
