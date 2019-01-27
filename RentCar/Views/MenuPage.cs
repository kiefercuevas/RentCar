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
using RentCar.Views.employees;
using RentCar.Views.fluel;
using RentCar.Views.user;
namespace RentCar.Views
{
    public partial class MenuPage : Form
    {
        private readonly RentCarUnitOfWork _context;
        private bool IsRequiredClosing;
        public MenuPage()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            BTNchangeState.Enabled = false;
            IsRequiredClosing = false;
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            BTNuserName.Text = Global.Variables[Global.Username].ToString();
            ShowIncomes(_context.IncomeAndRefund.GetAll());
            string rol = Global.Variables[Global.rol].ToString();

            if (rol != Global.ADMINROLE){
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
            if (e.CloseReason == CloseReason.UserClosing && !IsRequiredClosing)
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
            }else
                Global.Variables.Clear();
        }

        private void BTNIncome_Click(object sender, EventArgs e)
        {
            InspectionForm inspection = new InspectionForm();
            inspection.ShowDialog();
            ShowIncomes(_context.IncomeAndRefund.GetAll());
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

        private void BTNEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm form = new EmployeesForm();
            form.ShowDialog();
        }

        private void BTNfluels_Click(object sender, EventArgs e)
        {
            FluelForm form = new FluelForm();
            form.ShowDialog();
        }

        private void BTNchangeState_Click(object sender, EventArgs e)
        {

            if (DTGVIncomes.Rows.Count > 0 && DTGVIncomes.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVIncomes.CurrentRow.Cells["IncomeID"].Value);
                switch (MessageBox.Show("Esta seguro de que desea finalizar la renta", "Confirmar Finalizar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        
                        var income = _context.IncomeAndRefund.Get(id);
                        income.State = false;
                        if (_context.Complete() > 0)
                        {
                            var result = MessageBox.Show("la venta ha sido finalizada correctamente");
                            if (result == DialogResult.OK){
                                ShowIncomes(_context.IncomeAndRefund.GetAll());
                            }
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private void DTGVIncomes_SelectionChanged(object sender, EventArgs e)
        {
            if (DTGVIncomes.Rows.Count > 0 && DTGVIncomes.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVIncomes.CurrentRow.Cells["IncomeID"].Value);
                var income = _context.IncomeAndRefund.Get(id);
                if (income.State == true)
                    BTNchangeState.Enabled = true;
                else
                    BTNchangeState.Enabled = false;
            }
        }

        private void BTNuserName_Click(object sender, EventArgs e)
        {
            UserSettings form = new UserSettings(Convert.ToInt32(Global.Variables[Global.Id]));
            var result = form.ShowDialog();

            if(result == DialogResult.OK)
            {
                IsRequiredClosing = true;
                Close();
            }
        }
    }
}
