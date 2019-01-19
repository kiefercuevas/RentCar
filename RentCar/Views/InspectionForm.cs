using RentCar.Data;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Views
{
    public partial class InspectionForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        public InspectionForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
        }

        private void InspectionForm_Load(object sender, EventArgs e)
        {
            TBXEmployee.Text = Global.Variables[Global.Username] as string;
            TBXEmployee.Enabled = false;

            LoadClients();
            LoadVehicle();
            LoadFuelQuantity(); 
        }

        private void LoadClients()
        {
            var clients = _context.Clients.GetAll();
            CBXclients.Items.AddRange(clients.Select(c => c.IdentificationCard).ToArray());
        }

        private void LoadVehicle()
        {
            var vehicles = _context.Vehicles.GetAll();
            CBXvehicles.Items.AddRange(vehicles.Select(v => v.ChassisNumber).ToArray());
        }

        private void LoadFuelQuantity()
        {
            var fuelQuantity = _context.FluelQuantitys.GetAll();
            CBXfluelQuantity.Items.AddRange(fuelQuantity.Select(v => v.Quantity.ToString()).ToArray());
        }

        private void CreateRubberCheckBoxes(int quantity)
        {
            string rubber = "Goma";
            CLBXrubbers.Items.Clear();
            for (int i = 0; i < quantity; i++){
                CLBXrubbers.Items.Add(rubber+(i+1));
            }
            GBXcheckboxes.Controls.Add(CLBXrubbers);
        }

        private void CBXvehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vehicle = _context.Vehicles.GetVehiclesWithTypes(v => v.ChassisNumber == CBXvehicles.Text).FirstOrDefault();

            if (vehicle != null)
                CreateRubberCheckBoxes(vehicle.VehicleType.RubberQuantity);
        }
    }
}
