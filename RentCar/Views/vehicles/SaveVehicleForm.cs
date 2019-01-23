using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                Vehicle = _context.Vehicles
                    .GetVehiclesWithAll(v => v.VehicleID == Vehicle.VehicleID)
                    .FirstOrDefault();

                EditVehicle();
                BTNsave.Text = "Editar";
                Text = "Editar vehiculo";
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
            CBXvehicleType.SelectedIndex = CBXvehicleType.FindString(Vehicle.VehicleType.Description);
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
                CBXmodel.Items.Add("No hay modelos del vehiculo");
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
            } else
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

            for (int i = 0; i < chassisNumber.Length;i++){
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

            if (string.IsNullOrWhiteSpace(vehicleErrors)){
                if (string.IsNullOrWhiteSpace(chassisErrors)){
                    if (string.IsNullOrWhiteSpace(engineNumberErrors)){
                        if (string.IsNullOrWhiteSpace(plateNumberErrors)){
                            return "";
                        }else
                            return plateNumberErrors;
                    }else
                        return engineNumberErrors;
                }else
                    return chassisErrors;
            }else
                return vehicleErrors;
        }

        private void BTNsave_Click(object sender, EventArgs e)
        {
            string errors = GetErrors();

            if (string.IsNullOrEmpty(errors)) {
                if (Vehicle.VehicleID == 0){
                    SetVehicleObject(Vehicle);
                    _context.Vehicles.Add(Vehicle);
                    Action = "Agregado";
                    SaveVehicle();
                }
                else{
                    Vehicle vehicleToEdit = _context.Vehicles.Get(Vehicle.VehicleID);
                    SetVehicleObject(vehicleToEdit);
                    Action = "Editado";
                    SaveVehicle();
                }  
            }else
                MessageBox.Show(errors);
        }
        private void ChangeRow(Vehicle vehicle)
        {
            vehicle = Vehicle;
        }
        private void SaveVehicle()
        {
            try{
                if (_context.Complete() > 0)
                    if (MessageBox.Show("Se ha " + Action + " el vehiculo Correctamente") == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }  
            }
            catch (Exception ex){
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }
    }
}
