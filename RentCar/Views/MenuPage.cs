using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RentCar.Models;
using RentCar.Views.Incomes;
using RentCar.Views.inspections;
using RentCar.Views.vehicles;
using RentCar.Views.brands;
using RentCar.Views.models;
using RentCar.Views.vehicleTypes;
using RentCar.Views.clients;
namespace RentCar.Views
{
    public partial class MenuPage : Form
    {
        private readonly RentCarUnitOfWork _context;
        public MenuPage()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            BTNuserName.Text = Global.Variables[Global.Username].ToString();
            ShowIncomes(_context.IncomeAndRefund.GetAll());
            List<string> roles = (List<string>)Global.Variables[Global.Roles];

            if (!roles.Contains(Global.ADMINROLE)){
                BTNEmployees.Enabled = false;
            }
        }


        
        private void ShowIncomes(IEnumerable<IncomeAndRefund> data)
        {
            DTGVIncomes.AutoGenerateColumns = false;
            DTGVIncomes.DataSource = data;
        }

        private void BTNDateFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = DTPStartDate.Value.Date;
            DateTime endDate = DTPEndDate.Value.Date.AddDays(1);
            IEnumerable<IncomeAndRefund> data;

            if (startDate > endDate)
                ShowMessage("La fecha inicial no puede ser mayor a la final");
            else{
                data = FilterGridViewByDatesAndParam(startDate,endDate,TBXIncomeSearch.Text);
                ShowIncomes(data);
            }
        }

        private IEnumerable<IncomeAndRefund> FilterGridViewByDatesAndParam(DateTime start,DateTime end,string param = null)
        {
            if (!string.IsNullOrEmpty(param))
                return _context.IncomeAndRefund
                     .Find(i => i.IncomeDate >= start && i.RefundDate < end &&
                     i.State == true &&
                     (i.IncomeID.ToString().Contains(param) ||
                      i.AmountPerDay.ToString().Contains(param)));
            else
                return _context.IncomeAndRefund
                     .Find(i => i.IncomeDate >= start && i.RefundDate < end && i.State == true);
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void MenuPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                switch (MessageBox.Show("Esta seguro de que desea salir?", "Confirmar salir", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        Global.Variables.Clear();
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void BTNIncome_Click(object sender, EventArgs e)
        {
            InspectionForm inspection = new InspectionForm();
            inspection.ShowDialog();
            ShowIncomes(_context.IncomeAndRefund.Find(i => i.State == true));
        }

        private void DTGVIncomes_DoubleClick(object sender, EventArgs e)
        {
            if(DTGVIncomes.Rows.Count > 0 && DTGVIncomes.CurrentRow.Index != -1){
                int id = Convert.ToInt32(DTGVIncomes.CurrentRow.Cells["IncomeID"].Value);

                var income = _context.IncomeAndRefund.GetIncomeAndRefundWithAll(id);
                ShowIncomeForm showIncome = new ShowIncomeForm(income);
                showIncome.ShowDialog();
            }
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            DTPStartDate.Value = DateTime.Now;
            DTPEndDate.Value = DateTime.Now;
            TBXIncomeSearch.Text = null;
            ShowIncomes(_context.IncomeAndRefund.Find(i => i.State == true));
        }

        private void BTNvehicles_Click(object sender, EventArgs e)
        {
            VehiclesForm vehiclesForm = new VehiclesForm();
            vehiclesForm.ShowDialog();
        }

        private void BTNbrands_Click(object sender, EventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            brandForm.ShowDialog();
        }

        private void BTNmodels_Click(object sender, EventArgs e)
        {
            ModelsForm modelform = new ModelsForm();
            modelform.ShowDialog();
        }

        private void BTNvehicleTypes_Click(object sender, EventArgs e)
        {
            VehicleTypesForm form = new VehicleTypesForm();
            form.ShowDialog();
        }

        private void BTNclients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }
    }
}
