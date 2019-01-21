using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Models;
using RentCar.Data.Repositories;
namespace RentCar.Data
{
    public class RentCarUnitOfWork : IRentCarUnitOfWork
    {
        private readonly RentCarContex _context;
        public IBrandRepository Brands { get; private set; }
        public IClientRepository Clients { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IFluelTypeRepository FluelTypes { get; private set; }
        public IIncomeAndRefundRepository IncomeAndRefund { get; private set; }
        public IInspectionRepository Inspections { get; private set; }
        public IModelRepository Models { get; private set; }
        public IPersonTypeRepository PersonTypes { get; private set; }
        public IRoleRepository Roles { get; private set; }
        public IRubberStateRepository RubberStates { get; private set; }
        public IUserRepository User { get; private set; }
        public IVehicleRepository Vehicles { get; private set; }
        public IWorkShiftRepository WorkShifts { get; private set; }
        public IFluelQuantityRepository FluelQuantities { get; private set; }
        public IVehicleTypeRepository VehicleTypes { get; private set; }

        public RentCarUnitOfWork()
        {
            _context = new RentCarContex();

            Brands = new BrandRepository(_context);
            Clients = new ClientRepository(_context);
            Employees = new EmployeeRepository(_context);
            FluelQuantities = new FluelQuantityRepository(_context);
            FluelTypes = new FluelTypeRepository(_context);
            IncomeAndRefund = new IncomeAndRefundRepository(_context);
            Inspections = new InspectionRepository(_context);
            Models = new ModelRepository(_context);
            PersonTypes = new PersonTypeRepository(_context);
            Roles = new RoleRepository(_context);
            RubberStates = new RubberStateRepository(_context);
            User = new UserRepository(_context);
            Vehicles = new VehicleRepository(_context);
            WorkShifts = new WorkShiftRepository(_context);
            VehicleTypes = new VehicleTypeRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
