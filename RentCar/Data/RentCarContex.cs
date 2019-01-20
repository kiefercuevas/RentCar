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
        public DbSet<FluelType> FluelType { get; set; }
        public DbSet<IncomeAndRefund> IncomeAndRefunds { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RubberState> RubberStates { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Model>().
                HasRequired(m => m.Brand)
                .WithMany(b => b.Models)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspection>().
                HasRequired(i => i.IncomeAndRefund)
                .WithMany(r => r.Inspections)
                .WillCascadeOnDelete(false);

        }
    }
}
