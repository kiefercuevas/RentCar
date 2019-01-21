using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Data;
using RentCar.Models;
namespace RentCar.Views.vehicles
{
    public partial class SaveVehicleForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private Vehicle Vehicle { get; set; }
        private string Action { get; set; }
        public SaveVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Vehicle = vehicle;
            LoadComboxes();

            if (vehicle.VehicleID > 0){
                EditVehicle();
                BTNsave.Text = "Editar";

            }
            else
                BTNsave.Text = "Guardar";
        }


        public void LoadComboxes()
        {
            LoadVehicleTypes(_context.VehicleTypes.GetAll());
            LoadBrands(_context.Brands.GetAll());
            LoadFluelTypes(_context.FluelTypes.GetAll());
            LoadModels(_context.Models.GetAll());
        }

        public void EditVehicle()
        {
            TBXvehicleName.Text = Vehicle.Description;
            TBXchasisNumber.Text = Vehicle.ChassisNumber;
            TBXengineNumber.Text = Vehicle.EngineNumber;
            TBXplateNumber.Text = Vehicle.LicensePlateNumber;

            CBXbrand.SelectedIndex = CBXbrand.FindString(Vehicle.Brand.Description);
            CBXfluelType.SelectedIndex = CBXfluelType.FindString(Vehicle.FluelType.Description);
            CBXmodel.SelectedIndex = CBXmodel.FindString(Vehicle.Model.Description);
            CBXvehicleType.SelectedIndex = CBXbrand.FindString(Vehicle.VehicleType.Description);
        }



        private void LoadBrands(IEnumerable<Brand> brands)
        {
            if (brands.Count() > 0){
                Dictionary<int, string> brandsdata = new Dictionary<int, string>();

                foreach (var brand in brands)
                    brandsdata.Add(brand.BrandID, brand.Description);

                CBXbrand.DataSource = new BindingSource(brandsdata, null);
                CBXbrand.DisplayMember = "Value";
                CBXbrand.ValueMember = "Key";
            }
            else{
                CBXbrand.DataSource = null;
                CBXbrand.Items.Clear();
                CBXbrand.Items.Add("No hay marcas");
            }
        }

        private void LoadVehicleTypes(IEnumerable<VehicleType> vehicleTypes)
        {
            if (vehicleTypes.Count() > 0){
                Dictionary<int, string> vehicleTypesdata = new Dictionary<int, string>();

                foreach (var vehicleType in vehicleTypes)
                    vehicleTypesdata.Add(vehicleType.VehicleTypeID, vehicleType.Description);

                CBXvehicleType.DataSource = new BindingSource(vehicleTypesdata, null);
                CBXvehicleType.DisplayMember = "Value";
                CBXvehicleType.ValueMember = "Key";
            }
            else{
                CBXvehicleType.DataSource = null;
                CBXvehicleType.Items.Clear();
                CBXvehicleType.Items.Add("No hay tipos de vehiculo");
            }
        }

        private void LoadModels(IEnumerable<Model> models)
        {
            if (models.Count() > 0){
                Dictionary<int, string> modelsdata = new Dictionary<int, string>();

                foreach (var model in models)
                    modelsdata.Add(model.ModelID, model.Description);

                CBXmodel.DataSource = new BindingSource(modelsdata, null);
                CBXmodel.DisplayMember = "Value";
                CBXmodel.ValueMember = "Key";
            }
            else{
                CBXmodel.DataSource = null;
                CBXmodel.Items.Clear();
                CBXmodel.Items.Add("No hay tipos de vehiculo");
            }
        }
        private void LoadFluelTypes(IEnumerable<FluelType> fluelTypes)
        {
            if (fluelTypes.Count() > 0){
                Dictionary<int, string> modelsdata = new Dictionary<int, string>();

                foreach (var fluelType in fluelTypes)
                    modelsdata.Add(fluelType.FluelTypeID, fluelType.Description);

                CBXfluelType.DataSource = new BindingSource(modelsdata, null);
                CBXfluelType.DisplayMember = "Value";
                CBXfluelType.ValueMember = "Key";
            }
            else{
                CBXfluelType.DataSource = null;
                CBXfluelType.Items.Clear();
                CBXfluelType.Items.Add("No hay combustibles");
            }
        }

        private void AddVehicle()
        {
            Vehicle.BrandID = GetSourceId(CBXbrand);
            Vehicle.ModelID = GetSourceId(CBXmodel);
            Vehicle.FluelTypeID = GetSourceId(CBXfluelType);
            Vehicle.VehicleTypeID = GetSourceId(CBXvehicleType);

            Vehicle.ChassisNumber = TBXchasisNumber.Text;
            Vehicle.LicensePlateNumber = TBXplateNumber.Text;
            Vehicle.EngineNumber = TBXengineNumber.Text;
            Vehicle.Description = TBXvehicleName.Text;
        }

        private int GetSourceId(ComboBox comboBox)
        {
            if (comboBox.DataSource != null)
                return ((KeyValuePair<int, string>)comboBox.SelectedItem).Key;
            else
                return 0;
        }

        private void BTNsave_Click(object sender, EventArgs e)
        {
            if(Vehicle.VehicleID <= 0){
                AddVehicle();
                _context.Vehicles.Add(Vehicle);
                Action = "Agregado";
                //validar datos antes de insertarlos
            }else{
                //editar
                Action = "Editado";
            }

            try{
                if (_context.Complete() > 0)
                    if (MessageBox.Show("Se han " + Action + " Correctamente") == DialogResult.OK)
                        Close();
            }catch(Exception ex){
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
            
        }
    }
}
