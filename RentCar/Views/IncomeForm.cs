﻿using System;
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
namespace RentCar.Views
{
    public partial class IncomeForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private Inspection Inspection;
        private bool IsIncomeCancel;
        public IncomeForm(Inspection inspection)
        {
            InitializeComponent();
            Inspection = inspection;
            _context = new RentCarUnitOfWork();
            IsIncomeCancel = true;
        }

        private void BTNfinishIncome_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Desea completar la renta?", "Finalizar Renta", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    CompleteIncome();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void CompleteIncome()
        {
            if (DTPrefundDate.Value <= DateTime.Now)
                MessageBox.Show("La fecha de devolucion debe ser mayor a la fecha actual");
            else
            {
                IncomeAndRefund income = new IncomeAndRefund()
                {
                    AmountPerDay = (float)NUDamountxDay.Value,
                    ClientID = Inspection.ClientID,
                    EmployeeID = Inspection.EmployeeID,
                    NumberOfDays = (DTPrefundDate.Value.Date - DateTime.Now.Date).Days,
                    Commentary = RTBXcomment.Text,
                    IncomeDate = Inspection.InspectionDate,
                    RefundDate = DTPrefundDate.Value,
                    VehicleID = Inspection.VehicleID,
                };
                income.Inspections = new List<Inspection>
                {
                    Inspection
                };
                _context.IncomeAndRefund.Add(income);
                if (_context.Complete() > 0){
                    switch(MessageBox.Show("La renta se ha realizado correctamente")){
                        case DialogResult.OK:
                            IsIncomeCancel = false;
                            Close();
                            break;
                    }
                }
            }
        }

        private void IncomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && IsIncomeCancel)
            {
                switch (MessageBox.Show("Esta seguro de que desea cancelar la renta?", "Confirmar Cancelacion renta", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
