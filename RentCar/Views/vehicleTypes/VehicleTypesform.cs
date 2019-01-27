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

namespace RentCar.Views.vehicleTypes
{
    public partial class VehicleTypesForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private VehicleType VehicleType;
        string Action;
        public VehicleTypesForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            VehicleType = new VehicleType();
        }

        private void VehicleTypes_Load(object sender, EventArgs e)
        {
            LoadVehicleTypeGrid();
            if (Global.Variables[Global.rol].ToString() != "ADMIN")
                BTNdelete.Enabled = false;
        }

        private void LoadVehicleTypeGrid()
        {
            DTGVvehicleType.AutoGenerateColumns = false;
            DTGVvehicleType.DataSource = _context.VehicleTypes
                .Find(vt => vt.State == true);
        }

        private void BTNsearchVehicleType_Click(object sender, EventArgs e)
        {
            string param = TBXsearchVehicleType.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(param)){
                IEnumerable<VehicleType> vehicleTypes = _context.VehicleTypes
                    .Find(vt => vt.Description.ToLower() 
                    .Contains(param) &&
                     vt.State == true);

                DTGVvehicleType.DataSource = vehicleTypes;
            }
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            TBXsearchVehicleType.Text = null;
            LoadVehicleTypeGrid();
        }

        private string ValidateVehicleType()
        {
            if (!string.IsNullOrWhiteSpace(TBXvehicleTypeName.Text))
                if (_context.VehicleTypes.Count(v => v.State == true && v.Description.ToLower() == TBXvehicleTypeName.Text.ToLower() && v.VehicleTypeID != VehicleType.VehicleTypeID) == 0)
                {
                    return "";
                }
                else
                    return "Ya existe un tipo de vehiculo con el nombre introducido";
            else
                return "El campo Descripcion no puede estar vacio";
        }
        private string ValidateRubberQuantity()
        {
            if (NUDrubberQuantity.Value < 999999999)
                return "";
            else
                return "Ha excedido el limite de 999999999";
        }

        private void SetVehicleType(VehicleType vehicleType)
        {
            vehicleType.Description = TBXvehicleTypeName.Text;
            VehicleType.RubberQuantity = Convert.ToInt32(NUDrubberQuantity.Value);
            VehicleType.State = true;
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVvehicleType.Rows.Count > 0 && DTGVvehicleType.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVvehicleType.CurrentRow.Cells["VehicleTypeID"].Value);
                var vehicletype = _context.VehicleTypes.GetVehicleTypeWithAll(id);
                var vehicles = vehicletype.Vehicles;

                switch (MessageBox.Show("Esta seguro de que desea Eliminar el tipo de vehiculo " + vehicletype.Description + "? si lo elimina se borraran todos los autos asociados a este", "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:

                        foreach (var vehicle in vehicles)
                            vehicle.State = false;

                        vehicletype.State = false;

                        if (_context.Complete() > 0){
                            var result = MessageBox.Show("El Tipo de vehiculo ha sido eliminado correctamente");
                            if (result == DialogResult.OK){
                                LoadVehicleTypeGrid();
                                Reset();
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

        private string GetErrors()
        {
            string vehicleType = ValidateVehicleType();
            string rubberQuantity = ValidateRubberQuantity();

            if (string.IsNullOrWhiteSpace(vehicleType))
            {
                if (string.IsNullOrWhiteSpace(rubberQuantity))
                {
                    return "";
                }
                else
                    return rubberQuantity;
            }
            else
                return vehicleType;
        }

        private void Reset()
        {
            TBXsearchVehicleType.Text = null;
            TBXvehicleTypeName.Text = null;
            NUDrubberQuantity.Value = 0;
            BTNaddVehicleType.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            VehicleType = new VehicleType();
        }


        private void BTNaddVehicleType_Click(object sender, EventArgs e)
        {
            string errors = GetErrors();
            if (string.IsNullOrWhiteSpace(errors))
            {
                SetVehicleType(VehicleType);
                if (VehicleType.VehicleTypeID == 0){
                    Action = "Agregado";
                    _context.VehicleTypes.Add(VehicleType);
                }
                else{
                    Action = "Editado";
                }
                SaveVehicleType();
            }
            else
                MessageBox.Show(errors);
        }

        private void SaveVehicleType()
        {
            try
            {
                if (_context.Complete() > 0)
                {
                    MessageBox.Show("Se ha " + Action + " el tipo de vehiculo Correctamente");
                    LoadVehicleTypeGrid();
                    Reset();
                }
            }
            catch (Exception ex){
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DTGVvehicleType_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVvehicleType.Rows.Count > 0 && DTGVvehicleType.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVvehicleType.CurrentRow.Cells["VehicleTypeID"].Value);
                VehicleType = _context.VehicleTypes.Get(id);
                TBXvehicleTypeName.Text = VehicleType.Description;

                BTNaddVehicleType.Text = "Editar";
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
                NUDrubberQuantity.Value = VehicleType.RubberQuantity;
            }
        }
    }
}
