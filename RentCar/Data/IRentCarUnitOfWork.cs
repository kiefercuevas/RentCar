using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
namespace RentCar.Data
{
    public interface IRentCarUnitOfWork :IDisposable
    {
        IBrandRepository Brands { get; }
        IClientRepository Clients { get; }
        IEmployeeRepository Employees { get; }
        IFluelTypeRepository FluelTypes { get; }
        IIncomeAndRefundRepository IncomeAndRefund { get; }
        IInspectionRepository Inspections { get; }
        IModelRepository Models { get; }
        IPersonTypeRepository PersonTypes { get;}
        IRoleRepository Roles { get; }
        IRubberStateRepository RubberStates { get; }
        IUserRepository User { get; }
        IVehicleRepository Vehicles { get; }
        IWorkShiftRepository WorkShifts { get; }
        IFluelQuantityRepository FluelQuantities { get; }
        IVehicleTypeRepository VehicleTypes { get; }
        int Complete();
    }
}
