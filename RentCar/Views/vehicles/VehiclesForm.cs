﻿using RentCar.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models.ViewModels;
using RentCar.Models;

namespace RentCar.Views.vehicles
{
    public partial class VehiclesForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        public VehiclesForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            var data = GetVehicleViewModels(_context.Vehicles.GetVehiclesWithAll(v => v.State == true));
            LoadVehicleGridView(data);
        }

        private void LoadVehicleGridView(IEnumerable<VehicleViewModel> data)
        {
            DTGVvehicle.AutoGenerateColumns = false;
            DTGVvehicle.DataSource = data;
        }

        public IEnumerable<VehicleViewModel> GetVehicleViewModels(IEnumerable<Vehicle> vehicles)
        {
            List<VehicleViewModel> vehicleViewModels = new List<VehicleViewModel>();
            foreach(var vehicle in vehicles)
            {
                vehicleViewModels.Add(new VehicleViewModel()
                {
                    VehicleID = vehicle.VehicleID,
                    VehicleType = vehicle.VehicleType.Description,
                    Description = vehicle.Description,
                    Brand = vehicle.Brand.Description,
                    ChassisNumber = vehicle.ChassisNumber,
                    EngineNumber = vehicle.EngineNumber,
                    FluelType = vehicle.FluelType.Description,
                    LicensePlateNumber = vehicle.LicensePlateNumber,
                    Model = vehicle.Model.Description,
                });
            }
            return vehicleViewModels;
        }

        private void BTNaddVehicle_Click(object sender, EventArgs e)
        {
            SaveVehicleForm saveVehicle = new SaveVehicleForm(new Vehicle());
            saveVehicle.ShowDialog();
            var data = GetVehicleViewModels(_context.Vehicles.GetVehiclesWithAll());
            LoadVehicleGridView(data);
        }

        private void DTGVvehicle_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVvehicle.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVvehicle.CurrentRow.Cells["VehicleID"].Value);

                var vehicle = _context.Vehicles.GetVehiclesWithAll(v => v.VehicleID == id).FirstOrDefault();

                SaveVehicleForm saveVehicle = new SaveVehicleForm(vehicle);
                saveVehicle.ShowDialog();
            }
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVvehicle.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVvehicle.CurrentRow.Cells["VehicleID"].Value);
                var vehicle = _context.Vehicles.GetVehiclesWithAll(v => v.VehicleID == id).FirstOrDefault();

                switch (MessageBox.Show("Esta seguro de que desea Eliminar el vehiculo "+vehicle.Description, "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        _context.Vehicles.Remove(vehicle);
                       if( _context.Complete() > 0){
                            var result = MessageBox.Show("El vehiculo ha sido eliminado correctamente");
                            if (result == DialogResult.OK)
                            {
                                var data = _context.Vehicles.GetVehiclesWithAll();
                                var viewmodel = GetVehicleViewModels(data);
                                LoadVehicleGridView(viewmodel);
                            };
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
