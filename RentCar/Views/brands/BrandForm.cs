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

namespace RentCar.Views.brands
{
    public partial class BrandForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private Brand Brand;
        string Action;
        public BrandForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Brand = new Brand();
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            LoadBrandGrid();
        }


        private void LoadBrandGrid()
        {
            DTGVbrands.AutoGenerateColumns = false;
            DTGVbrands.DataSource = _context.Brands.GetAll();
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            TBXsearchBrand.Text = null;
            LoadBrandGrid();
        }

        private void BTNsearchBrand_Click(object sender, EventArgs e)
        {
            string param = TBXsearchBrand.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(param))
            {
                IEnumerable<Brand> brands = _context.Brands
                    .Find(b => b.Description.ToLower()
                    .Contains(param));

                DTGVbrands.DataSource = brands;
            }
            
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVbrands.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVbrands.CurrentRow.Cells["BrandID"].Value);
                var brand = _context.Brands.GetBrandWithAll(id);
                var vehicles = brand.Vehicles;
                var models = brand.Models;

                switch (MessageBox.Show("Esta seguro de que desea Eliminar la marca " + brand.Description + " si la elimina se borraran todos los autos y modelos asociados a esta", "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:

                        _context.Vehicles.RemoveRange(vehicles);
                        _context.Models.RemoveRange(models);
                        _context.Brands.Remove(brand);
                        if (_context.Complete() > 0)
                        {
                            var result = MessageBox.Show("La Marca ha sido eliminada correctamente");
                            if (result == DialogResult.OK){
                                LoadBrandGrid();
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

        private void SetBrand(Brand brand)
        {
            brand.Description = TBXbrandName.Text;
            brand.State = CKBXstate.Checked;
        }

        private string ValidateBrand()
        {
            if (!string.IsNullOrWhiteSpace(TBXbrandName.Text)){
                return "";
            }
            else
                return "El campo Descripcion no puede estar vacio";
        }

        private void BTNaddBrand_Click(object sender, EventArgs e)
        {
            string errors = ValidateBrand();
            if (string.IsNullOrWhiteSpace(errors)){
                SetBrand(Brand);
                if(Brand.BrandID == 0){
                    Action = "Agregado";
                    _context.Brands.Add(Brand);
                }else{
                    Action = "Editado";
                }
                SaveBrand();
            }
            else
                MessageBox.Show(errors);
        }

        private void SaveBrand()
        {
            try
            {
                if (_context.Complete() > 0)
                    MessageBox.Show("Se ha " + Action + " el vehiculo Correctamente");
                    LoadBrandGrid();
                    Reset();
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void DTGVbrands_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVbrands.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVbrands.CurrentRow.Cells["BrandID"].Value);
                Brand = _context.Brands.Get(id);
                TBXbrandName.Text = Brand.Description;

                CKBXstate.Enabled = true;
                BTNaddBrand.Text = "Editar";
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
                CKBXstate.Checked = Brand.State;
            }
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            TBXsearchBrand.Text = null;
            TBXbrandName.Text = null;
            CKBXstate.Enabled = false;
            BTNaddBrand.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            CKBXstate.Checked = true;
            Brand = new Brand();
        }
    }
}
