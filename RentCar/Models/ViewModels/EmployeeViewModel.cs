using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string IdentificationCard { get; set; }
        public string WorkShift { get; set; }
        public string CommissionPercentage { get; set; }
        public string AdmissionDate { get; set; }
        public bool State { get; set; }
        public string UserRole { get; set; }
    }
}
