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
using RentCar.Models.ViewModels;
using RentCar.Models;
using System.Text.RegularExpressions;

namespace RentCar.Views.vehicles
{
    public partial class VehiclesForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private Vehicle Vehicle { get; set; }
        private string Action { get; set; }
        public VehiclesForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Vehicle = new Vehicle();
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            LoadVehicleData();
        }
        private void LoadVehicleData()
        {
            var data = GetVehicleViewModels(_context.Vehicles.GetVehiclesWithAll(v => v.State == true));
            DTGVvehicle.AutoGenerateColumns = false;
            DTGVvehicle.DataSource = data;
            LoadComboxes();
        }

        public void LoadComboxes()
        {
            LoadVehicleTypes(_context.VehicleTypes.Find(vt => vt.State == true));
            LoadBrands(_context.Brands.Find(b => b.State == true));
            LoadFluelTypes(_context.FluelTypes.Find(fl => fl.State == true));
            LoadModels(_context.Models.Find(m => m.State == true));
        }
        private void LoadBrands(IEnumerable<Brand> brands)
        {
            if (brands.Count() > 0)
            {
                Dictionary<int, string> brandsdata = new Dictionary<int, string>();

                foreach (var brand in brands)
                    brandsdata.Add(brand.BrandID, brand.Description);

                CBXbrand.DataSource = new BindingSource(brandsdata, null);
                CBXbrand.DisplayMember = "Value";
                CBXbrand.ValueMember = "Key";
            }
            else
            {
                CBXbrand.DataSource = null;
                CBXbrand.Items.Clear();
                CBXbrand.Items.Add("No hay marcas");
            }
        }

        private void LoadVehicleTypes(IEnumerable<VehicleType> vehicleTypes)
        {
            if (vehicleTypes.Count() > 0)
            {
                Dictionary<int, string> vehicleTypesdata = new Dictionary<int, string>();

                foreach (var vehicleType in vehicleTypes)
                    vehicleTypesdata.Add(vehicleType.VehicleTypeID, vehicleType.Description);

                CBXvehicleType.DataSource = new BindingSource(vehicleTypesdata, null);
                CBXvehicleType.DisplayMember = "Value";
                CBXvehicleType.ValueMember = "Key";
            }
            else
            {
                CBXvehicleType.DataSource = null;
                CBXvehicleType.Items.Clear();
                CBXvehicleType.Items.Add("No hay tipos de vehiculo");
            }
        }

        private void LoadModels(IEnumerable<Model> models)
        {
            if (models.Count() > 0)
            {
                Dictionary<int, string> modelsdata = new Dictionary<int, string>();

                foreach (var model in models)
                    modelsdata.Add(model.ModelID, model.Description);

                CBXmodel.DataSource = new BindingSource(modelsdata, null);
                CBXmodel.DisplayMember = "Value";
                CBXmodel.ValueMember = "Key";
            }
            else
            {
                CBXmodel.DataSource = null;
                CBXmodel.Items.Clear();
                CBXmodel.Items.Add("No hay modelos del vehiculo");
            }
        }
        private void LoadFluelTypes(IEnumerable<FluelType> fluelTypes)
        {
            if (fluelTypes.Count() > 0)
            {
                Dictionary<int, string> modelsdata = new Dictionary<int, string>();

                foreach (var fluelType in fluelTypes)
                    modelsdata.Add(fluelType.FluelTypeID, fluelType.Description);

                CBXfluelType.DataSource = new BindingSource(modelsdata, null);
                CBXfluelType.DisplayMember = "Value";
                CBXfluelType.ValueMember = "Key";
            }
            else
            {
                CBXfluelType.DataSource = null;
                CBXfluelType.Items.Clear();
                CBXfluelType.Items.Add("No hay combustibles");
            }
        }

        private void SetVehicleObject(Vehicle Vehicle)
        {
            Vehicle.BrandID = GetSourceId(CBXbrand);
            Vehicle.ModelID = GetSourceId(CBXmodel);
            Vehicle.FluelTypeID = GetSourceId(CBXfluelType);
            Vehicle.VehicleTypeID = GetSourceId(CBXvehicleType);

            Vehicle.ChassisNumber = TBXchasisNumber.Text;
            Vehicle.LicensePlateNumber = TBXplateNumber.Text;
            Vehicle.EngineNumber = TBXengineNumber.Text;
            Vehicle.Description = TBXvehicleName.Text;
            Vehicle.State = true;
        }
        private int GetSourceId(ComboBox comboBox)
        {
            if (comboBox.DataSource != null)
                return ((KeyValuePair<int, string>)comboBox.SelectedItem).Key;
            else
                return 0;
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
                    State = vehicle.State
                });
            }
            return vehicleViewModels;
        }

        private void BTNaddVehicle_Click(object sender, EventArgs e)
        {
            string errors = GetErrors();

            if (string.IsNullOrEmpty(errors))
            {
                if (Vehicle.VehicleID == 0)
                {
                    SetVehicleObject(Vehicle);
                    _context.Vehicles.Add(Vehicle);
                    Action = "Agregado";
                }
                else{
                    Vehicle vehicleToEdit = _context.Vehicles.Get(Vehicle.VehicleID);
                    SetVehicleObject(vehicleToEdit);
                    Action = "Editado";
                }
                SaveVehicle();
            }
            else
                MessageBox.Show(errors);
        }

        private void DTGVvehicle_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVvehicle.Rows.Count > 0 && DTGVvehicle.CurrentRow.Index != -1){
                int id = Convert.ToInt32(DTGVvehicle.CurrentRow.Cells["VehicleID"].Value);
                Vehicle = _context.Vehicles
                    .GetVehiclesWithAll(v => v.VehicleID == id)
                    .FirstOrDefault();

                EditVehicle();
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
                BTNaddVehicle.Text = "Editar";
            }
        }


        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVvehicle.Rows.Count > 0 && DTGVvehicle.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVvehicle.CurrentRow.Cells["VehicleID"].Value);
                var vehicle = _context.Vehicles.Get(id);

                switch (MessageBox.Show("Esta seguro de que desea Eliminar el vehiculo "+vehicle.Description, "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        vehicle.State = false;
                       if( _context.Complete() > 0){
                            var result = MessageBox.Show("El vehiculo ha sido eliminado correctamente");
                            if (result == DialogResult.OK)
                                LoadVehicleData();
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private void BTNsearchVehicle_Click(object sender, EventArgs e)
        {
            string param = TBXsearchVehicle.Text.ToLower();
            if (!string.IsNullOrEmpty(param))
            {
                IEnumerable<Vehicle> vehicles = _context.Vehicles
                    .GetVehiclesWithAll(v => v.State == true &&
                     (v.Description.ToLower().Contains(param) ||
                     v.Brand.Description.ToLower().Contains(param) ||
                     v.ChassisNumber.ToLower().Contains(param) ||
                     v.EngineNumber.ToLower().Contains(param) ||
                     v.FluelType.Description.ToLower().Contains(param) ||
                     v.LicensePlateNumber.ToLower().Contains(param) ||
                     v.Model.Description.ToLower().Contains(param) ||
                     v.VehicleType.Description.ToLower().Contains(param)));

                DTGVvehicle.DataSource = GetVehicleViewModels(vehicles);
            }
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            Reset();
            LoadVehicleData();
        }
        private void Reset()
        {
            TBXchasisNumber.Text = null;
            TBXengineNumber.Text = null;
            TBXplateNumber.Text = null;
            TBXsearchVehicle.Text = null;
            TBXvehicleName.Text = null;
            
            BTNaddVehicle.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            Vehicle = new Vehicle();
            LoadComboxes();
        }


        private string ValidateVehicleName()
        {
            string vehicleDescription = TBXvehicleName.Text;
            if (!string.IsNullOrEmpty(vehicleDescription))
                return "";
            else
                return "El nombre del vehiculo no puede estar vacio";
        }
        private string ValidateChassisNumber()
        {
            string chassisNo = TBXchasisNumber.Text;
            if (!string.IsNullOrWhiteSpace(chassisNo))
            {
                if (chassisNo.Length == 17)
                {
                    if (CheckValidChassisNumber(chassisNo))
                        return "";
                    else
                        return "El numero de chasis no es valido";
                }
                else
                    return "El numero de chassis debe tener 17 digitos";
            }
            else
                return "El numero de chasis no puede estar vacio";
        }
        private string ValidatePlateNumber()
        {
            string plateNumber = TBXplateNumber.Text;
            if (!string.IsNullOrWhiteSpace(plateNumber))
            {
                if (TBXplateNumber.TextLength == 7)
                {
                    string pattern = @"^[A-Za-z]{1}[0-9]{6}$";
                    var regex = new Regex(pattern);
                    if (regex.IsMatch(plateNumber))
                        return "";
                    else
                        return "La Matricula no es valida";
                }
                else
                    return "La matricula debe tener 7 digitos";
            }
            else
                return "La matricula no puede estar vacia";
        }
        private string ValidateEngineNumber()
        {
            string engineNumber = TBXengineNumber.Text;
            if (!string.IsNullOrWhiteSpace(engineNumber))
            {
                if (engineNumber.Length >= 8)
                    return "";
                else
                    return "El numero del motor debe ser mayor que 8";
            }
            else
                return "El numero del motor no puede estar vacio";
        }
        private bool CheckValidChassisNumber(string chassisNumber)
        {
            string weightsFactor = "8765432X098765432";
            string stringNumbers = "0123456789X";
            int sum = 0;
            int remainder = 0;
            char checkValue = chassisNumber[8];

            for (int i = 0; i < chassisNumber.Length; i++)
            {
                sum += ChanceLetterToVinValue(chassisNumber[i]) * stringNumbers.IndexOf(weightsFactor[i]);
            }
            remainder = sum % 11;

            return stringNumbers[remainder] == checkValue;
        }
        private int ChanceLetterToVinValue(char c)
        {
            string pattern = "0123456789.ABCDEFGH..JKLMN.P.R..STUVWXYZ";
            return pattern.IndexOf(c) % 10;
        }

        private string GetErrors()
        {
            string chassisErrors = ValidateChassisNumber();
            string plateNumberErrors = ValidatePlateNumber();
            string vehicleErrors = ValidateVehicleName();
            string engineNumberErrors = ValidateEngineNumber();

            if (string.IsNullOrWhiteSpace(vehicleErrors))
            {
                if (string.IsNullOrWhiteSpace(chassisErrors))
                {
                    if (string.IsNullOrWhiteSpace(engineNumberErrors))
                    {
                        if (string.IsNullOrWhiteSpace(plateNumberErrors))
                        {
                            return "";
                        }
                        else
                            return plateNumberErrors;
                    }
                    else
                        return engineNumberErrors;
                }
                else
                    return chassisErrors;
            }
            else
                return vehicleErrors;
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
            CBXvehicleType.SelectedIndex = CBXvehicleType.FindString(Vehicle.VehicleType.Description);
        }

        private void SaveVehicle()
        {
            try
            {
                if (_context.Complete() > 0){
                    MessageBox.Show("Se ha " + Action + " el vehiculo Correctamente");
                    LoadVehicleData();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
