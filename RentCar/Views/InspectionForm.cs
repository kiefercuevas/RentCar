using RentCar.Data;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RentCar.Views.Incomes;

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

            LoadClients(_context.Clients.GetAll());
            LoadVehicle(_context.Vehicles.GetAll());
            LoadFuelQuantity(_context.FluelQuantities.GetAll()); 
        }

        private void LoadClients(IEnumerable<Client> clients)
        {
            if (clients.Count() > 0)
            {
                Dictionary<int, string> clientsdata = new Dictionary<int, string>();

                foreach (var client in clients)
                    clientsdata.Add(client.ClientID, client.Name);

                CBXclients.DataSource = new BindingSource(clientsdata, null);
                CBXclients.DisplayMember = "Value";
                CBXclients.ValueMember = "Key";
            }
            else{
                CBXclients.DataSource = null;
                CBXclients.Items.Clear();
                CBXclients.Items.Add("No hay datos");
            }
        }

        private void LoadVehicle(IEnumerable<Vehicle> vehicles)
        {
            if (vehicles.Count() > 0)
            {
                Dictionary<int, string> vehiclesdata = new Dictionary<int, string>();

                foreach (Vehicle vehicle in vehicles)
                    vehiclesdata.Add(vehicle.VehicleID, vehicle.Description);

                CBXvehicles.DataSource = new BindingSource(vehiclesdata, null);
                CBXvehicles.DisplayMember = "Value";
                CBXvehicles.ValueMember = "Key";
            }
            else{
                CBXvehicles.DataSource = null;
                CBXvehicles.Items.Clear();
                CBXvehicles.Items.Add("No hay vehiculos");
            }
               

        }

        private void LoadFuelQuantity(IEnumerable<FluelQuantity> fuelQuantities)
        {
            if (fuelQuantities.Count() > 0)
            {
                Dictionary<int, string> fuelQuantitydata = new Dictionary<int, string>();

                foreach (var fluelQuantity in fuelQuantities)
                    fuelQuantitydata.Add(fluelQuantity.FluelQuantityID, fluelQuantity.Quantity.ToString());

                CBXfluelQuantity.DataSource = new BindingSource(fuelQuantitydata, null);
                CBXfluelQuantity.DisplayMember = "Value";
                CBXfluelQuantity.ValueMember = "Key";
            }
            else{
                CBXfluelQuantity.DataSource = null;
                CBXfluelQuantity.Items.Clear();
                CBXfluelQuantity.Items.Add("No hay combustibles");
            }
                
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
            if(CBXvehicles.DataSource != null){
                int id = ((KeyValuePair<int, string>)CBXvehicles.SelectedItem).Key;
                var vehicle = _context.Vehicles
                    .GetVehiclesWithTypes(v => v.VehicleID == id)
                    .FirstOrDefault();

                if (vehicle != null)
                    CreateRubberCheckBoxes(vehicle.VehicleType.RubberQuantity);
            }
        }

        private void TXBvehicle_TextChanged(object sender, EventArgs e)
        {
            string text = TXBvehicle.Text;
            IEnumerable<Vehicle> vehicles;
            if (!string.IsNullOrWhiteSpace(text))
            {
               vehicles = _context.Vehicles.Find(v => v.Brand.Description.Contains(text) ||
                   v.ChassisNumber.Contains(text) ||
                   v.Description.Contains(text) ||
                   v.EngineNumber.Contains(text) ||
                   v.FluelType.Description.Contains(text) ||
                   v.LicensePlateNumber.Contains(text) ||
                   v.Model.Description.Contains(text) ||
                   v.VehicleType.Description.Contains(text));
            }
            else
                vehicles = _context.Vehicles.GetAll();

            
            CLBXrubbers.Items.Clear();
            LoadVehicle(vehicles);
        }

        private void TXBclients_TextChanged(object sender, EventArgs e)
        {
            string text = TXBclients.Text;
            IEnumerable<Client> clients;
            if (!string.IsNullOrWhiteSpace(text)){
                clients = _context.Clients.Find(c => c.CreditCardNumber.Contains(text) ||
                            c.CreditLimit.ToString().Contains(text) ||
                            c.IdentificationCard.Contains(text) ||
                            c.Name.Contains(text));
            }
            else
                clients = _context.Clients.GetAll();

            LoadClients(clients);
        }

        private void TBXfuelquantity_TextChanged(object sender, EventArgs e)
        {
            string text = TBXfuelquantity.Text;
            IEnumerable<FluelQuantity> fluels;
            if (!string.IsNullOrWhiteSpace(text))
                fluels = _context.FluelQuantities.Find(f => f.Quantity.ToString().Contains(text));
            else
                fluels = _context.FluelQuantities.GetAll();

            LoadFuelQuantity(fluels);
        }

        private void BTNIncomeForm_Click(object sender, EventArgs e)
        {
            int vehicleId = GetSourceId(CBXvehicles);
            int clientId = GetSourceId(CBXclients);
            int fluelQuantityId = GetSourceId(CBXfluelQuantity);

            if (vehicleId == 0)
                MessageBox.Show("Debe Elegir un vehiculo");
            else if (clientId == 0)
                MessageBox.Show("Debe Elegir un cliente");
            else if (fluelQuantityId == 0)
                MessageBox.Show("Debe Elegir una cantidad de Combustible");
            else{
                Inspection inspection = new Inspection()
                {
                    ClientID = clientId,
                    VehicleID = vehicleId,
                    FluelQuantityID = fluelQuantityId,
                    EmployeeID = Convert.ToInt32(Global.Variables[Global.Id]),
                    HasGlassBreaks = CKBhasGlassBreaks.Checked,
                    HasGrazes = CKBhasgrazes.Checked,
                    HasLeverCat = CKBhasLeverCat.Checked,
                    HasReplacementRubber = CKBhasReplacementRubber.Checked,
                    State = true,
                    InspectionDate = DateTime.Now,
                    Etc = RTBXetc.Text,
                    RubberStates = new List<RubberState>()
                };

                for(int i=0;i < CLBXrubbers.Items.Count; i++)
                {
                    inspection.RubberStates.Add(new RubberState() {
                        Description = CLBXrubbers.Items[i].ToString(),
                        State = CLBXrubbers.GetItemChecked(i)
                    });
                }

                IncomeForm income = new IncomeForm(inspection);
                income.ShowDialog();
                Close();
            }
        }

        

        private int GetSourceId(ComboBox comboBox)
        {
            if (comboBox.DataSource != null)
                return ((KeyValuePair<int, string>)comboBox.SelectedItem).Key;
            else
                return 0;
        }

    }
}
