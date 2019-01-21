using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models;
namespace RentCar.Views.inspections
{
    public partial class ShowInspection : Form
    {
        private Inspection Inspection { get; set; }
        public ShowInspection(Inspection inspection)
        {
            InitializeComponent();
            Inspection = inspection;
        }

        private void ShowInspection_Load(object sender, EventArgs e)
        {
            CKBhasGlassBreaks.Checked = Inspection.HasGlassBreaks;
            CKBhasgrazes.Checked = Inspection.HasGrazes;
            CKBhasLeverCat.Checked = Inspection.HasLeverCat;
            CKBhasReplacementRubber.Checked = Inspection.HasReplacementRubber;
            RTBXetc.Text = Inspection.Etc;


            TBXfuelQuantity.Text = Inspection.FluelQuantity.Quantity.ToString();
            TBXinspectionDate.Text = Inspection.InspectionDate.ToShortDateString();

            int index = 0;
            foreach(var rubber in Inspection.RubberStates){
                CreateRubberCheckBoxes(index,rubber.State);
                index++;
            }
        }

        private void CreateRubberCheckBoxes(int index,bool state)
        {
            string rubber = "Goma";
            CLBXrubbers.Items.Add(rubber + (index + 1));
            CLBXrubbers.SetItemChecked(index, state);

            GBXcheckboxes.Controls.Add(CLBXrubbers);
        }
    }
}
