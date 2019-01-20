namespace RentCar.Views
{
    partial class InspectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBInspectionLogo = new System.Windows.Forms.Label();
            this.LBVehicle = new System.Windows.Forms.Label();
            this.CBXvehicles = new System.Windows.Forms.ComboBox();
            this.CBXclients = new System.Windows.Forms.ComboBox();
            this.LBClient = new System.Windows.Forms.Label();
            this.CBXfluelQuantity = new System.Windows.Forms.ComboBox();
            this.LBFluelQuantity = new System.Windows.Forms.Label();
            this.GBXcheckboxes = new System.Windows.Forms.GroupBox();
            this.CLBXrubbers = new System.Windows.Forms.CheckedListBox();
            this.BTNIncomeForm = new System.Windows.Forms.Button();
            this.LBetc = new System.Windows.Forms.Label();
            this.RTBXetc = new System.Windows.Forms.RichTextBox();
            this.LBRubberState = new System.Windows.Forms.Label();
            this.CKBhasGlassBreaks = new System.Windows.Forms.CheckBox();
            this.CKBhasLeverCat = new System.Windows.Forms.CheckBox();
            this.CKBhasReplacementRubber = new System.Windows.Forms.CheckBox();
            this.CKBhasgrazes = new System.Windows.Forms.CheckBox();
            this.GBXcomboxes = new System.Windows.Forms.GroupBox();
            this.TBXEmployee = new System.Windows.Forms.TextBox();
            this.LBEmployee = new System.Windows.Forms.Label();
            this.TBXfuelquantity = new System.Windows.Forms.TextBox();
            this.TXBclients = new System.Windows.Forms.TextBox();
            this.TXBvehicle = new System.Windows.Forms.TextBox();
            this.GBXcheckboxes.SuspendLayout();
            this.GBXcomboxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBInspectionLogo
            // 
            this.LBInspectionLogo.AutoSize = true;
            this.LBInspectionLogo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInspectionLogo.Location = new System.Drawing.Point(12, 20);
            this.LBInspectionLogo.Name = "LBInspectionLogo";
            this.LBInspectionLogo.Size = new System.Drawing.Size(140, 42);
            this.LBInspectionLogo.TabIndex = 0;
            this.LBInspectionLogo.Text = "Inpeccion";
            // 
            // LBVehicle
            // 
            this.LBVehicle.AutoSize = true;
            this.LBVehicle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBVehicle.Location = new System.Drawing.Point(6, 11);
            this.LBVehicle.Name = "LBVehicle";
            this.LBVehicle.Size = new System.Drawing.Size(80, 25);
            this.LBVehicle.TabIndex = 1;
            this.LBVehicle.Text = "Vehiculo";
            // 
            // CBXvehicles
            // 
            this.CBXvehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXvehicles.FormattingEnabled = true;
            this.CBXvehicles.Location = new System.Drawing.Point(11, 47);
            this.CBXvehicles.Name = "CBXvehicles";
            this.CBXvehicles.Size = new System.Drawing.Size(181, 21);
            this.CBXvehicles.TabIndex = 2;
            this.CBXvehicles.SelectedIndexChanged += new System.EventHandler(this.CBXvehicles_SelectedIndexChanged);
            // 
            // CBXclients
            // 
            this.CBXclients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXclients.FormattingEnabled = true;
            this.CBXclients.Location = new System.Drawing.Point(11, 116);
            this.CBXclients.Name = "CBXclients";
            this.CBXclients.Size = new System.Drawing.Size(181, 21);
            this.CBXclients.TabIndex = 4;
            // 
            // LBClient
            // 
            this.LBClient.AutoSize = true;
            this.LBClient.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBClient.Location = new System.Drawing.Point(9, 78);
            this.LBClient.Name = "LBClient";
            this.LBClient.Size = new System.Drawing.Size(67, 25);
            this.LBClient.TabIndex = 3;
            this.LBClient.Text = "Cliente";
            // 
            // CBXfluelQuantity
            // 
            this.CBXfluelQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXfluelQuantity.FormattingEnabled = true;
            this.CBXfluelQuantity.Location = new System.Drawing.Point(320, 47);
            this.CBXfluelQuantity.Name = "CBXfluelQuantity";
            this.CBXfluelQuantity.Size = new System.Drawing.Size(211, 21);
            this.CBXfluelQuantity.TabIndex = 6;
            // 
            // LBFluelQuantity
            // 
            this.LBFluelQuantity.AutoSize = true;
            this.LBFluelQuantity.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFluelQuantity.Location = new System.Drawing.Point(315, 14);
            this.LBFluelQuantity.Name = "LBFluelQuantity";
            this.LBFluelQuantity.Size = new System.Drawing.Size(110, 25);
            this.LBFluelQuantity.TabIndex = 5;
            this.LBFluelQuantity.Text = "Combustible";
            // 
            // GBXcheckboxes
            // 
            this.GBXcheckboxes.Controls.Add(this.CLBXrubbers);
            this.GBXcheckboxes.Controls.Add(this.BTNIncomeForm);
            this.GBXcheckboxes.Controls.Add(this.LBetc);
            this.GBXcheckboxes.Controls.Add(this.RTBXetc);
            this.GBXcheckboxes.Controls.Add(this.LBRubberState);
            this.GBXcheckboxes.Controls.Add(this.CKBhasGlassBreaks);
            this.GBXcheckboxes.Controls.Add(this.CKBhasLeverCat);
            this.GBXcheckboxes.Controls.Add(this.CKBhasReplacementRubber);
            this.GBXcheckboxes.Controls.Add(this.CKBhasgrazes);
            this.GBXcheckboxes.Location = new System.Drawing.Point(19, 257);
            this.GBXcheckboxes.Name = "GBXcheckboxes";
            this.GBXcheckboxes.Size = new System.Drawing.Size(549, 299);
            this.GBXcheckboxes.TabIndex = 7;
            this.GBXcheckboxes.TabStop = false;
            // 
            // CLBXrubbers
            // 
            this.CLBXrubbers.FormattingEnabled = true;
            this.CLBXrubbers.Location = new System.Drawing.Point(316, 123);
            this.CLBXrubbers.Name = "CLBXrubbers";
            this.CLBXrubbers.Size = new System.Drawing.Size(144, 64);
            this.CLBXrubbers.TabIndex = 13;
            // 
            // BTNIncomeForm
            // 
            this.BTNIncomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIncomeForm.Location = new System.Drawing.Point(311, 238);
            this.BTNIncomeForm.Name = "BTNIncomeForm";
            this.BTNIncomeForm.Size = new System.Drawing.Size(221, 49);
            this.BTNIncomeForm.TabIndex = 12;
            this.BTNIncomeForm.Text = "Siguiente";
            this.BTNIncomeForm.UseVisualStyleBackColor = true;
            this.BTNIncomeForm.Click += new System.EventHandler(this.BTNIncomeForm_Click);
            // 
            // LBetc
            // 
            this.LBetc.AutoSize = true;
            this.LBetc.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBetc.Location = new System.Drawing.Point(16, 161);
            this.LBetc.Name = "LBetc";
            this.LBetc.Size = new System.Drawing.Size(35, 23);
            this.LBetc.TabIndex = 11;
            this.LBetc.Text = "Etc.";
            // 
            // RTBXetc
            // 
            this.RTBXetc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBXetc.Location = new System.Drawing.Point(17, 194);
            this.RTBXetc.Name = "RTBXetc";
            this.RTBXetc.Size = new System.Drawing.Size(236, 99);
            this.RTBXetc.TabIndex = 10;
            this.RTBXetc.Text = "";
            // 
            // LBRubberState
            // 
            this.LBRubberState.AutoSize = true;
            this.LBRubberState.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRubberState.Location = new System.Drawing.Point(314, 80);
            this.LBRubberState.Name = "LBRubberState";
            this.LBRubberState.Size = new System.Drawing.Size(110, 23);
            this.LBRubberState.TabIndex = 9;
            this.LBRubberState.Text = "Estado gomas";
            // 
            // CKBhasGlassBreaks
            // 
            this.CKBhasGlassBreaks.AutoSize = true;
            this.CKBhasGlassBreaks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CKBhasGlassBreaks.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKBhasGlassBreaks.Location = new System.Drawing.Point(311, 32);
            this.CKBhasGlassBreaks.Name = "CKBhasGlassBreaks";
            this.CKBhasGlassBreaks.Size = new System.Drawing.Size(151, 27);
            this.CKBhasGlassBreaks.TabIndex = 8;
            this.CKBhasGlassBreaks.Text = "Roturas de Cristal";
            this.CKBhasGlassBreaks.UseVisualStyleBackColor = true;
            // 
            // CKBhasLeverCat
            // 
            this.CKBhasLeverCat.AutoSize = true;
            this.CKBhasLeverCat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CKBhasLeverCat.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKBhasLeverCat.Location = new System.Drawing.Point(15, 123);
            this.CKBhasLeverCat.Name = "CKBhasLeverCat";
            this.CKBhasLeverCat.Size = new System.Drawing.Size(62, 27);
            this.CKBhasLeverCat.TabIndex = 7;
            this.CKBhasLeverCat.Text = "Gato";
            this.CKBhasLeverCat.UseVisualStyleBackColor = true;
            // 
            // CKBhasReplacementRubber
            // 
            this.CKBhasReplacementRubber.AutoSize = true;
            this.CKBhasReplacementRubber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CKBhasReplacementRubber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKBhasReplacementRubber.Location = new System.Drawing.Point(14, 79);
            this.CKBhasReplacementRubber.Name = "CKBhasReplacementRubber";
            this.CKBhasReplacementRubber.Size = new System.Drawing.Size(169, 27);
            this.CKBhasReplacementRubber.TabIndex = 6;
            this.CKBhasReplacementRubber.Text = "Goma de Remplazo";
            this.CKBhasReplacementRubber.UseVisualStyleBackColor = true;
            // 
            // CKBhasgrazes
            // 
            this.CKBhasgrazes.AutoSize = true;
            this.CKBhasgrazes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CKBhasgrazes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKBhasgrazes.Location = new System.Drawing.Point(15, 32);
            this.CKBhasgrazes.Name = "CKBhasgrazes";
            this.CKBhasgrazes.Size = new System.Drawing.Size(104, 27);
            this.CKBhasgrazes.TabIndex = 5;
            this.CKBhasgrazes.Text = "Ralladuras";
            this.CKBhasgrazes.UseVisualStyleBackColor = true;
            // 
            // GBXcomboxes
            // 
            this.GBXcomboxes.Controls.Add(this.TBXEmployee);
            this.GBXcomboxes.Controls.Add(this.LBEmployee);
            this.GBXcomboxes.Controls.Add(this.TBXfuelquantity);
            this.GBXcomboxes.Controls.Add(this.TXBclients);
            this.GBXcomboxes.Controls.Add(this.TXBvehicle);
            this.GBXcomboxes.Controls.Add(this.CBXvehicles);
            this.GBXcomboxes.Controls.Add(this.CBXfluelQuantity);
            this.GBXcomboxes.Controls.Add(this.LBVehicle);
            this.GBXcomboxes.Controls.Add(this.LBFluelQuantity);
            this.GBXcomboxes.Controls.Add(this.LBClient);
            this.GBXcomboxes.Controls.Add(this.CBXclients);
            this.GBXcomboxes.Location = new System.Drawing.Point(20, 74);
            this.GBXcomboxes.Name = "GBXcomboxes";
            this.GBXcomboxes.Size = new System.Drawing.Size(548, 166);
            this.GBXcomboxes.TabIndex = 8;
            this.GBXcomboxes.TabStop = false;
            // 
            // TBXEmployee
            // 
            this.TBXEmployee.Enabled = false;
            this.TBXEmployee.Location = new System.Drawing.Point(431, 115);
            this.TBXEmployee.Name = "TBXEmployee";
            this.TBXEmployee.Size = new System.Drawing.Size(100, 20);
            this.TBXEmployee.TabIndex = 8;
            // 
            // LBEmployee
            // 
            this.LBEmployee.AutoSize = true;
            this.LBEmployee.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEmployee.Location = new System.Drawing.Point(315, 110);
            this.LBEmployee.Name = "LBEmployee";
            this.LBEmployee.Size = new System.Drawing.Size(91, 25);
            this.LBEmployee.TabIndex = 7;
            this.LBEmployee.Text = "Empleado";
            // 
            // TBXfuelquantity
            // 
            this.TBXfuelquantity.Location = new System.Drawing.Point(431, 16);
            this.TBXfuelquantity.Name = "TBXfuelquantity";
            this.TBXfuelquantity.Size = new System.Drawing.Size(100, 20);
            this.TBXfuelquantity.TabIndex = 9;
            this.TBXfuelquantity.TextChanged += new System.EventHandler(this.TBXfuelquantity_TextChanged);
            // 
            // TXBclients
            // 
            this.TXBclients.Location = new System.Drawing.Point(92, 83);
            this.TXBclients.Name = "TXBclients";
            this.TXBclients.Size = new System.Drawing.Size(100, 20);
            this.TXBclients.TabIndex = 8;
            this.TXBclients.TextChanged += new System.EventHandler(this.TXBclients_TextChanged);
            // 
            // TXBvehicle
            // 
            this.TXBvehicle.Location = new System.Drawing.Point(92, 14);
            this.TXBvehicle.Name = "TXBvehicle";
            this.TXBvehicle.Size = new System.Drawing.Size(100, 20);
            this.TXBvehicle.TabIndex = 7;
            this.TXBvehicle.TextChanged += new System.EventHandler(this.TXBvehicle_TextChanged);
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 568);
            this.Controls.Add(this.GBXcheckboxes);
            this.Controls.Add(this.LBInspectionLogo);
            this.Controls.Add(this.GBXcomboxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InspectionForm";
            this.Load += new System.EventHandler(this.InspectionForm_Load);
            this.GBXcheckboxes.ResumeLayout(false);
            this.GBXcheckboxes.PerformLayout();
            this.GBXcomboxes.ResumeLayout(false);
            this.GBXcomboxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBInspectionLogo;
        private System.Windows.Forms.Label LBVehicle;
        private System.Windows.Forms.ComboBox CBXvehicles;
        private System.Windows.Forms.ComboBox CBXclients;
        private System.Windows.Forms.Label LBClient;
        private System.Windows.Forms.ComboBox CBXfluelQuantity;
        private System.Windows.Forms.Label LBFluelQuantity;
        private System.Windows.Forms.GroupBox GBXcheckboxes;
        private System.Windows.Forms.CheckBox CKBhasLeverCat;
        private System.Windows.Forms.CheckBox CKBhasReplacementRubber;
        private System.Windows.Forms.CheckBox CKBhasgrazes;
        private System.Windows.Forms.GroupBox GBXcomboxes;
        private System.Windows.Forms.TextBox TBXEmployee;
        private System.Windows.Forms.Label LBEmployee;
        private System.Windows.Forms.CheckBox CKBhasGlassBreaks;
        private System.Windows.Forms.Label LBRubberState;
        private System.Windows.Forms.RichTextBox RTBXetc;
        private System.Windows.Forms.Label LBetc;
        private System.Windows.Forms.Button BTNIncomeForm;
        private System.Windows.Forms.CheckedListBox CLBXrubbers;
        private System.Windows.Forms.TextBox TBXfuelquantity;
        private System.Windows.Forms.TextBox TXBclients;
        private System.Windows.Forms.TextBox TXBvehicle;
    }
}