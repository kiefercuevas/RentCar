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

namespace RentCar.Views.fluel
{
    public partial class FluelForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private FluelType FluelType;
        string Action;
        public FluelForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            FluelType = new FluelType();
        }

        private void FluelForm_Load(object sender, EventArgs e)
        {
            LoadFluelTypeGrid();
            if (Global.Variables[Global.rol].ToString() != "ADMIN")
                BTNdelete.Enabled = false;
        }

        private void LoadFluelTypeGrid()
        {
            DTGVFluel.AutoGenerateColumns = false;
            DTGVFluel.DataSource = _context.FluelTypes.Find(b => b.State == true);
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            TBXFluelName.Text = null;
            LoadFluelTypeGrid();
        }

        private void BTNsearchFluel_Click(object sender, EventArgs e)
        {
            string param = TBXsearchFluel.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(param))
            {
                IEnumerable<FluelType> fluelTypes = _context.FluelTypes
                    .Find(b => b.Description.ToLower()
                    .Contains(param) && b.State == true);

                DTGVFluel.DataSource = fluelTypes;
            }
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVFluel.Rows.Count > 0 && DTGVFluel.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVFluel.CurrentRow.Cells["FluelTypeID"].Value);
                var fluelType = _context.FluelTypes.GetFluelTypesWithAll(fl => fl.FluelTypeID == id).FirstOrDefault();
                var vehicles = fluelType.Vehicles;

                switch (MessageBox.Show("Esta seguro de que desea Eliminar el tipo de combustible " + fluelType.Description + " si la elimina se borraran todos los autos asociados a este", "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:

                        foreach (var vehicle in vehicles)
                            vehicle.State = false;

                        fluelType.State = false;
                        if (_context.Complete() > 0)
                        {
                            var result = MessageBox.Show("El tipo de combustible ha sido eliminado correctamente");
                            if (result == DialogResult.OK)
                            {
                                LoadFluelTypeGrid();
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


        private void SetFluelType(FluelType fluelType)
        {
            fluelType.Description = TBXFluelName.Text;
            fluelType.State = true;
        }

        private string ValidateFluelType()
        {
            if (!string.IsNullOrWhiteSpace(TBXFluelName.Text))
            {
                if (_context.FluelTypes.Count(fl => fl.State == true && fl.Description.ToLower() == TBXFluelName.Text.ToLower() && fl.FluelTypeID != FluelType.FluelTypeID) == 0)
                {
                    return "";
                }
                else
                    return "Ya existe un tipo de combustible con ese nombre";
            }
            else
                return "El campo Descripcion no puede estar vacio";
        }



        private void Reset()
        {
            TBXsearchFluel.Text = null;
            TBXFluelName.Text = null;
            BTNaddFluel.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            FluelType = new FluelType();
        }

        private void BTNaddFluel_Click(object sender, EventArgs e)
        {
            string errors = ValidateFluelType();
            if (string.IsNullOrWhiteSpace(errors))
            {
                SetFluelType(FluelType);
                if (FluelType.FluelTypeID == 0)
                {
                    Action = "Agregado";
                    _context.FluelTypes.Add(FluelType);
                }
                else
                {
                    Action = "Editado";
                }
                SaveFluelType();
            }
            else
                MessageBox.Show(errors);
        }

        private void SaveFluelType()
        {
            try
            {
                if (_context.Complete() > 0)
                    MessageBox.Show("Se ha " + Action + " el Tipo de combustible Correctamente");
                LoadFluelTypeGrid();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void DTGVFluel_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVFluel.Rows.Count > 0 && DTGVFluel.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVFluel.CurrentRow.Cells["FluelTypeID"].Value);
                FluelType = _context.FluelTypes.Get(id);
                TBXFluelName.Text = FluelType.Description;

                BTNaddFluel.Text = "Editar";
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
            }
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
