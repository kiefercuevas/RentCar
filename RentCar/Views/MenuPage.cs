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
            LBUserName.Text = Global.Variables[Global.Username].ToString();
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
                     (i.IncomeID.ToString().Contains(param) ||
                      i.AmountPerDay.ToString().Contains(param)));
            else
                return _context.IncomeAndRefund
                     .Find(i => i.IncomeDate >= start && i.RefundDate < end);
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
            ShowIncomes(_context.IncomeAndRefund.GetAll());
        }

        private void DTGVIncomes_DoubleClick(object sender, EventArgs e)
        {
            if(DTGVIncomes.CurrentRow.Index != -1){
                int id = Convert.ToInt32(DTGVIncomes.CurrentRow.Cells["IncomeID"].Value);

                var income = _context.IncomeAndRefund.GetIncomeAndRefundWithAll(id);
                ShowIncomeForm showIncome = new ShowIncomeForm(income);
                showIncome.ShowDialog();
            }
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            ShowIncomes(_context.IncomeAndRefund.GetAll());
        }

        private void BTNvehicles_Click(object sender, EventArgs e)
        {
            VehiclesForm vehiclesForm = new VehiclesForm();
            vehiclesForm.ShowDialog();
        }
    }
}
