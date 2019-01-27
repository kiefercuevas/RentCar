using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Data;
using RentCar.Models;
using RentCar.Views.inspections;
namespace RentCar.Views.Incomes
{
    public partial class ShowIncomeForm : Form
    {
        IncomeAndRefund Income { get; set; }
        private readonly RentCarUnitOfWork _context;
        public ShowIncomeForm(IncomeAndRefund income)
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Income = income;
        }

        private void ShowIncomeForm_Load(object sender, EventArgs e)
        {
            TBXincomeID.Text = Income.IncomeID.ToString();
            TBXIncomeDate.Text = Income.IncomeDate.ToShortDateString();
            TBXrefundDate.Text = Income.RefundDate.ToShortDateString();
            TBXamountPerDay.Text = Income.AmountPerDay.ToString();
            TBXnumberOfDays.Text = Income.NumberOfDays.ToString();
            RTBXcomment.Text = Income.Commentary;
            CBXstate.Checked = Income.State;

            //employee
            TBXempName.Text = Income.Employee.Name;

            //client
            TBXclientname.Text = Income.Client.Name;
            TBXidentificationCard.Text = Income.Client.IdentificationCard;
            TBXcreditCard.Text = Income.Client.CreditCardNumber;
            TBXtypeOfPerson.Text = Income.Client.PersonType.Title;
            TBXcreditLimit.Text = Income.Client.CreditLimit.ToString();

            //vehicle
            TBXdescription.Text = Income.Vehicle.Description;
            TBXchassisNumber.Text = Income.Vehicle.ChassisNumber;
            TBXengineNumber.Text = Income.Vehicle.EngineNumber;
            TBXplateNumber.Text = Income.Vehicle.LicensePlateNumber;
            TBXtypeOfVehicle.Text = Income.Vehicle.VehicleType.Description;
            TBXbrand.Text = Income.Vehicle.Brand.Description;
            TBXmodel.Text = Income.Vehicle.Model.Description;
            TBXfluelType.Text = Income.Vehicle.FluelType.Description;
            TBXrubberQuantity.Text = Income.Vehicle.VehicleType.RubberQuantity.ToString();
        }

        private void BTNinspection_Click(object sender, EventArgs e)
        {
            Inspection inspection = _context.Inspections
                .GetInspectionWithAll(i => i.IncomeID == Income.IncomeID);

            ShowInspection inspectionForm = new ShowInspection(inspection);
            inspectionForm.ShowDialog();
        }
    }
}
