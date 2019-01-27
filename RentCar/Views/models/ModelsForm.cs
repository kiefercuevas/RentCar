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
            LoadBrands(_context.Brands.Find(b => b.State == true));
            if (Global.Variables[Global.rol].ToString() != "ADMIN")
                BTNdelete.Enabled = false;
        }
        private void LoadModelsGrid()
        {
            DTGVmodels.AutoGenerateColumns = false;
            DTGVmodels.DataSource = _context.Models.Find(m => m.State == true);
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            TBXsearchModel.Text = null;
            LoadModelsGrid();
        }

        private void BTNsearchModel_Click(object sender, EventArgs e)
        {
            string param = TBXsearchModel.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(param)){
                IEnumerable<Model> models = _context.Models
                    .Find(m => m.Description.ToLower()
                    .Contains(param) &&
                    m.State == true);

                DTGVmodels.DataSource = models;
            }
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVmodels.Rows.Count > 0 && DTGVmodels.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVmodels.CurrentRow.Cells["ModelID"].Value);
                var model = _context.Models.GetModelWithAll(id);
                var vehicles = model.Vehicles;

                switch (MessageBox.Show("Esta seguro de que desea Eliminar el modelo " + model.Description + "? si lo elimina se borraran todos los autos asociados a este", "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:

                        foreach (var vehicle in vehicles)
                            vehicle.State = false;

                        model.State = false;

                        if (_context.Complete() > 0){
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

        private void LoadBrands(IEnumerable<Brand> brands)
        {
            if (brands.Count() > 0)
            {
                Dictionary<int, string> brandsdata = new Dictionary<int, string>();

                foreach (Brand brand in brands)
                    brandsdata.Add(brand.BrandID, brand.Description);

                CBXbrands.DataSource = new BindingSource(brandsdata, null);
                CBXbrands.DisplayMember = "Value";
                CBXbrands.ValueMember = "Key";
            }
            else
            {
                CBXbrands.DataSource = null;
                CBXbrands.Items.Clear();
                CBXbrands.Items.Add("No hay marcas");
            }


        }

        private void SetModel(Model model)
        {
            model.Description = TBXmodelName.Text;
            model.BrandID = ((KeyValuePair<int, string>)CBXbrands.SelectedItem).Key;
            model.State = true;
        }

        private string ValidateModel()
        {
            if (!string.IsNullOrWhiteSpace(TBXmodelName.Text))
                if (_context.Models.Count(m => m.State == true && m.Description.ToLower() == TBXmodelName.Text.ToLower() && m.ModelID != Model.ModelID) == 0)
                {
                    return "";
                }
                else
                    return "Ya existe un modelo con ese nombre";
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
            if (DTGVmodels.Rows.Count > 0 && DTGVmodels.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVmodels.CurrentRow.Cells["ModelID"].Value);
                Model = _context.Models.GetModelWithAll(id);

                TBXmodelName.Text = Model.Description;
                CBXbrands.SelectedIndex = CBXbrands.FindString(Model.Brand.Description);

                BTNaddModel.Text = "Editar";
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
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
            BTNaddModel.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            Model = new Model();
        }
    }
}
