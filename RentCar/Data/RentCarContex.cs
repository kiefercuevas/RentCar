using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RentCar.Models;
namespace RentCar.Data
{
    public class RentCarContex: DbContext
    {
        public RentCarContex()
            :base("RentCarDB"){}

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<IncomeAndRefund> IncomeAndRefunds { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
    }
}
