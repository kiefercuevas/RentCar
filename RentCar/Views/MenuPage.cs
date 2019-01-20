using RentCar.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models;
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
            ShowIncomes(_context.IncomeAndRefund.GetAll().ToList());

        }


        
        private void ShowIncomes(List<IncomeAndRefund> data)
        {
            DTGVIncomes.Rows.Clear();
            foreach(IncomeAndRefund income in data)
            {
                int index = DTGVIncomes.Rows.Add();
                DataGridViewRow row = DTGVIncomes.Rows[index];

                row.Cells[0].Value = income.IncomeID;
                row.Cells[1].Value = income.IncomeDate.ToShortDateString();
                row.Cells[2].Value = income.RefundDate.ToShortDateString();
                row.Cells[3].Value = income.AmountPerDay;
                row.Cells[4].Value = income.NumberOfDays;
                row.Cells[5].Value = income.State;
            }
        }

        private void BTNDateFilter_Click(object sender, EventArgs e)
        {
            string param = TBXIncomeSearch.Text;
            DateTime startDate = DTPStartDate.Value.Date;
            DateTime endDate = DTPEndDate.Value.Date.AddDays(1);
            List<IncomeAndRefund> data = new List<IncomeAndRefund>();

            if (startDate > endDate)
                ShowMessage("La fecha inicial no puede ser mayor a la final");
            else{
                if (!string.IsNullOrEmpty(param)){
                    data = _context.IncomeAndRefund
                         .Find(i => i.IncomeDate >= startDate && i.RefundDate < endDate &&
                         (i.IncomeID.ToString().Contains(param) ||
                          i.AmountPerDay.ToString().Contains(param)
                         )).ToList();
                }else{
                    data = _context.IncomeAndRefund
                         .Find(i => i.IncomeDate >= startDate && i.RefundDate < endDate)
                         .ToList();
                }
                ShowIncomes(data);
            }
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
            ShowIncomes(_context.IncomeAndRefund.GetAll().ToList());
        }
    }
}
