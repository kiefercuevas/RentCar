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

namespace RentCar.Views.models
{
    public partial class ModelsForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private Model Model;
        string Action;
        public ModelsForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Model = new Model();
        }
        private void ModelsForm_Load(object sender, EventArgs e)
        {
            LoadModelsGrid();
        }
        private void LoadModelsGrid()
        {
            DTGVmodels.AutoGenerateColumns = false;
            DTGVmodels.DataSource = _context.Models.GetAll();
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            TBXsearchModel.Text = null;
            LoadModelsGrid();
        }

        private void BTNsearchModel_Click(object sender, EventArgs e)
        {
            string param = TBXsearchModel.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(param))
            {
                IEnumerable<Model> models = _context.Models
                    .Find(b => b.Description.ToLower()
                    .Contains(param));

                DTGVmodels.DataSource = models;
            }
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVmodels.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVmodels.CurrentRow.Cells["ModelID"].Value);
                var model = _context.Models.GetModelWithAll(id);
                var vehicles = model.Vehicles;

                switch (MessageBox.Show("Esta seguro de que desea Eliminar el modelo " + model.Description + "? si lo elimina se borraran todos los autos asociados a este", "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:

                        _context.Vehicles.RemoveRange(vehicles);
                        _context.Models.Remove(model);
                        if (_context.Complete() > 0)
                        {
                            var result = MessageBox.Show("El Modelo ha sido eliminado correctamente");
                            if (result == DialogResult.OK)
                            {
                                LoadModelsGrid();
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

        private void SetModel(Model model)
        {
            model.Description = TBXmodelName.Text;
            model.State = CKBXstate.Checked;
        }

        private string ValidateModel()
        {
            if (!string.IsNullOrWhiteSpace(TBXmodelName.Text)){
                return "";
            }
            else
                return "El campo Descripcion no puede estar vacio";
        }


        private void BTNaddModel_Click(object sender, EventArgs e)
        {
            string errors = ValidateModel();
            if (string.IsNullOrWhiteSpace(errors))
            {
                SetModel(Model);
                if (Model.ModelID == 0){
                    Action = "Agregado";
                    _context.Models.Add(Model);
                }
                else{
                    Action = "Editado";
                }
                SaveModel();
            }
            else
                MessageBox.Show(errors);
        }

        private void SaveModel()
        {
            try
            {
                if (_context.Complete() > 0)
                    MessageBox.Show("Se ha " + Action + " el modelo Correctamente");
                LoadModelsGrid();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void DTGVmodels_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVmodels.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVmodels.CurrentRow.Cells["ModelID"].Value);
                Model = _context.Models.Get(id);
                TBXmodelName.Text = Model.Description;

                CKBXstate.Enabled = true;
                BTNaddModel.Text = "Editar";
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
                CKBXstate.Checked = Model.State;
            }
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            TBXsearchModel.Text = null;
            TBXmodelName.Text = null;
            CKBXstate.Enabled = false;
            BTNaddModel.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            CKBXstate.Checked = true;
            Model = new Model();
        }
    }
}
