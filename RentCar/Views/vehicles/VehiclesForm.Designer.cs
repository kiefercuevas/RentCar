namespace RentCar.Views.vehicles
{
    partial class VehiclesForm
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
            this.DTGVvehicle = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChassisNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FluelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNaddVehicle = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.TBXsearchVehicle = new System.Windows.Forms.TextBox();
            this.BTNsearchVehicle = new System.Windows.Forms.Button();
            this.BTNclear = new System.Windows.Forms.Button();
            this.LBclient = new System.Windows.Forms.Label();
            this.TBXvehicleName = new System.Windows.Forms.TextBox();
            this.LBvehicleName = new System.Windows.Forms.Label();
            this.TBXchasisNumber = new System.Windows.Forms.TextBox();
            this.LBchasisNumber = new System.Windows.Forms.Label();
            this.TBXengineNumber = new System.Windows.Forms.TextBox();
            this.LBengineNumber = new System.Windows.Forms.Label();
            this.TBXplateNumber = new System.Windows.Forms.TextBox();
            this.LBplateNumber = new System.Windows.Forms.Label();
            this.LBvehicleType = new System.Windows.Forms.Label();
            this.CBXvehicleType = new System.Windows.Forms.ComboBox();
            this.LBbrand = new System.Windows.Forms.Label();
            this.CBXbrand = new System.Windows.Forms.ComboBox();
            this.CBXmodel = new System.Windows.Forms.ComboBox();
            this.LBmodel = new System.Windows.Forms.Label();
            this.CBXfluelType = new System.Windows.Forms.ComboBox();
            this.LBfluelType = new System.Windows.Forms.Label();
            this.BTNcancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVvehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVvehicle
            // 
            this.DTGVvehicle.AllowUserToAddRows = false;
            this.DTGVvehicle.AllowUserToDeleteRows = false;
            this.DTGVvehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVvehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.Description,
            this.Brand,
            this.Model,
            this.LicensePlateNumber,
            this.ChassisNumber,
            this.EngineNumber,
            this.VehicleType,
            this.FluelType,
            this.State});
            this.DTGVvehicle.Location = new System.Drawing.Point(12, 48);
            this.DTGVvehicle.Name = "DTGVvehicle";
            this.DTGVvehicle.ReadOnly = true;
            this.DTGVvehicle.Size = new System.Drawing.Size(344, 356);
            this.DTGVvehicle.TabIndex = 0;
            this.DTGVvehicle.DoubleClick += new System.EventHandler(this.DTGVvehicle_DoubleClick);
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "Codigo";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Marca";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Modelo";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // LicensePlateNumber
            // 
            this.LicensePlateNumber.DataPropertyName = "LicensePlateNumber";
            this.LicensePlateNumber.HeaderText = "Matricula";
            this.LicensePlateNumber.Name = "LicensePlateNumber";
            this.LicensePlateNumber.ReadOnly = true;
            // 
            // ChassisNumber
            // 
            this.ChassisNumber.DataPropertyName = "ChassisNumber";
            this.ChassisNumber.HeaderText = "No. Chasis";
            this.ChassisNumber.Name = "ChassisNumber";
            this.ChassisNumber.ReadOnly = true;
            // 
            // EngineNumber
            // 
            this.EngineNumber.DataPropertyName = "EngineNumber";
            this.EngineNumber.HeaderText = "No. Motor";
            this.EngineNumber.Name = "EngineNumber";
            this.EngineNumber.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "Tipo de vehiculo";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // FluelType
            // 
            this.FluelType.DataPropertyName = "FluelType";
            this.FluelType.HeaderText = "Tipo de Combustible";
            this.FluelType.Name = "FluelType";
            this.FluelType.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // BTNaddVehicle
            // 
            this.BTNaddVehicle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddVehicle.Location = new System.Drawing.Point(372, 277);
            this.BTNaddVehicle.Name = "BTNaddVehicle";
            this.BTNaddVehicle.Size = new System.Drawing.Size(290, 54);
            this.BTNaddVehicle.TabIndex = 1;
            this.BTNaddVehicle.Text = "Agregar";
            this.BTNaddVehicle.UseVisualStyleBackColor = true;
            this.BTNaddVehicle.Click += new System.EventHandler(this.BTNaddVehicle_Click);
            // 
            // BTNdelete
            // 
            this.BTNdelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(372, 350);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(599, 49);
            this.BTNdelete.TabIndex = 4;
            this.BTNdelete.Text = "Eliminar";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // TBXsearchVehicle
            // 
            this.TBXsearchVehicle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXsearchVehicle.Location = new System.Drawing.Point(85, 12);
            this.TBXsearchVehicle.Name = "TBXsearchVehicle";
            this.TBXsearchVehicle.Size = new System.Drawing.Size(99, 32);
            this.TBXsearchVehicle.TabIndex = 5;
            // 
            // BTNsearchVehicle
            // 
            this.BTNsearchVehicle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearchVehicle.Location = new System.Drawing.Point(190, 10);
            this.BTNsearchVehicle.Name = "BTNsearchVehicle";
            this.BTNsearchVehicle.Size = new System.Drawing.Size(101, 35);
            this.BTNsearchVehicle.TabIndex = 6;
            this.BTNsearchVehicle.Text = "Buscar";
            this.BTNsearchVehicle.UseVisualStyleBackColor = true;
            this.BTNsearchVehicle.Click += new System.EventHandler(this.BTNsearchVehicle_Click);
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(318, 10);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(38, 35);
            this.BTNclear.TabIndex = 7;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // LBclient
            // 
            this.LBclient.AutoSize = true;
            this.LBclient.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBclient.Location = new System.Drawing.Point(12, 17);
            this.LBclient.Name = "LBclient";
            this.LBclient.Size = new System.Drawing.Size(67, 25);
            this.LBclient.TabIndex = 53;
            this.LBclient.Text = "Buscar";
            // 
            // TBXvehicleName
            // 
            this.TBXvehicleName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXvehicleName.Location = new System.Drawing.Point(476, 48);
            this.TBXvehicleName.Name = "TBXvehicleName";
            this.TBXvehicleName.Size = new System.Drawing.Size(186, 29);
            this.TBXvehicleName.TabIndex = 55;
            // 
            // LBvehicleName
            // 
            this.LBvehicleName.AutoSize = true;
            this.LBvehicleName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvehicleName.Location = new System.Drawing.Point(365, 52);
            this.LBvehicleName.Name = "LBvehicleName";
            this.LBvehicleName.Size = new System.Drawing.Size(105, 25);
            this.LBvehicleName.TabIndex = 54;
            this.LBvehicleName.Text = "Descripcion";
            // 
            // TBXchasisNumber
            // 
            this.TBXchasisNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXchasisNumber.Location = new System.Drawing.Point(476, 100);
            this.TBXchasisNumber.Name = "TBXchasisNumber";
            this.TBXchasisNumber.Size = new System.Drawing.Size(186, 29);
            this.TBXchasisNumber.TabIndex = 57;
            // 
            // LBchasisNumber
            // 
            this.LBchasisNumber.AutoSize = true;
            this.LBchasisNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBchasisNumber.Location = new System.Drawing.Point(365, 104);
            this.LBchasisNumber.Name = "LBchasisNumber";
            this.LBchasisNumber.Size = new System.Drawing.Size(95, 25);
            this.LBchasisNumber.TabIndex = 56;
            this.LBchasisNumber.Text = "No. chasis";
            // 
            // TBXengineNumber
            // 
            this.TBXengineNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXengineNumber.Location = new System.Drawing.Point(476, 157);
            this.TBXengineNumber.Name = "TBXengineNumber";
            this.TBXengineNumber.Size = new System.Drawing.Size(186, 29);
            this.TBXengineNumber.TabIndex = 59;
            // 
            // LBengineNumber
            // 
            this.LBengineNumber.AutoSize = true;
            this.LBengineNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBengineNumber.Location = new System.Drawing.Point(365, 161);
            this.LBengineNumber.Name = "LBengineNumber";
            this.LBengineNumber.Size = new System.Drawing.Size(90, 25);
            this.LBengineNumber.TabIndex = 58;
            this.LBengineNumber.Text = "No. Motor";
            // 
            // TBXplateNumber
            // 
            this.TBXplateNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXplateNumber.Location = new System.Drawing.Point(476, 211);
            this.TBXplateNumber.Name = "TBXplateNumber";
            this.TBXplateNumber.Size = new System.Drawing.Size(186, 29);
            this.TBXplateNumber.TabIndex = 61;
            // 
            // LBplateNumber
            // 
            this.LBplateNumber.AutoSize = true;
            this.LBplateNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBplateNumber.Location = new System.Drawing.Point(367, 215);
            this.LBplateNumber.Name = "LBplateNumber";
            this.LBplateNumber.Size = new System.Drawing.Size(88, 25);
            this.LBplateNumber.TabIndex = 60;
            this.LBplateNumber.Text = "No. Placa";
            // 
            // LBvehicleType
            // 
            this.LBvehicleType.AutoSize = true;
            this.LBvehicleType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvehicleType.Location = new System.Drawing.Point(673, 159);
            this.LBvehicleType.Name = "LBvehicleType";
            this.LBvehicleType.Size = new System.Drawing.Size(143, 25);
            this.LBvehicleType.TabIndex = 63;
            this.LBvehicleType.Text = "Tipo de vehiculo";
            // 
            // CBXvehicleType
            // 
            this.CBXvehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXvehicleType.FormattingEnabled = true;
            this.CBXvehicleType.Location = new System.Drawing.Point(822, 154);
            this.CBXvehicleType.Name = "CBXvehicleType";
            this.CBXvehicleType.Size = new System.Drawing.Size(147, 32);
            this.CBXvehicleType.TabIndex = 62;
            // 
            // LBbrand
            // 
            this.LBbrand.AutoSize = true;
            this.LBbrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBbrand.Location = new System.Drawing.Point(674, 50);
            this.LBbrand.Name = "LBbrand";
            this.LBbrand.Size = new System.Drawing.Size(62, 25);
            this.LBbrand.TabIndex = 65;
            this.LBbrand.Text = "Marca";
            // 
            // CBXbrand
            // 
            this.CBXbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXbrand.FormattingEnabled = true;
            this.CBXbrand.Location = new System.Drawing.Point(772, 45);
            this.CBXbrand.Name = "CBXbrand";
            this.CBXbrand.Size = new System.Drawing.Size(197, 32);
            this.CBXbrand.TabIndex = 64;
            // 
            // CBXmodel
            // 
            this.CBXmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXmodel.FormattingEnabled = true;
            this.CBXmodel.Location = new System.Drawing.Point(772, 97);
            this.CBXmodel.Name = "CBXmodel";
            this.CBXmodel.Size = new System.Drawing.Size(197, 32);
            this.CBXmodel.TabIndex = 67;
            // 
            // LBmodel
            // 
            this.LBmodel.AutoSize = true;
            this.LBmodel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBmodel.Location = new System.Drawing.Point(674, 104);
            this.LBmodel.Name = "LBmodel";
            this.LBmodel.Size = new System.Drawing.Size(71, 25);
            this.LBmodel.TabIndex = 66;
            this.LBmodel.Text = "Modelo";
            // 
            // CBXfluelType
            // 
            this.CBXfluelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXfluelType.FormattingEnabled = true;
            this.CBXfluelType.Location = new System.Drawing.Point(852, 208);
            this.CBXfluelType.Name = "CBXfluelType";
            this.CBXfluelType.Size = new System.Drawing.Size(117, 32);
            this.CBXfluelType.TabIndex = 69;
            // 
            // LBfluelType
            // 
            this.LBfluelType.AutoSize = true;
            this.LBfluelType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBfluelType.Location = new System.Drawing.Point(674, 215);
            this.LBfluelType.Name = "LBfluelType";
            this.LBfluelType.Size = new System.Drawing.Size(172, 25);
            this.LBfluelType.TabIndex = 68;
            this.LBfluelType.Text = "Tipo de combustible";
            // 
            // BTNcancel
            // 
            this.BTNcancel.Enabled = false;
            this.BTNcancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancel.Location = new System.Drawing.Point(679, 277);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(290, 54);
            this.BTNcancel.TabIndex = 70;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Visible = false;
            this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 411);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.CBXfluelType);
            this.Controls.Add(this.LBfluelType);
            this.Controls.Add(this.CBXmodel);
            this.Controls.Add(this.LBmodel);
            this.Controls.Add(this.LBbrand);
            this.Controls.Add(this.CBXbrand);
            this.Controls.Add(this.LBvehicleType);
            this.Controls.Add(this.CBXvehicleType);
            this.Controls.Add(this.TBXplateNumber);
            this.Controls.Add(this.LBplateNumber);
            this.Controls.Add(this.TBXengineNumber);
            this.Controls.Add(this.LBengineNumber);
            this.Controls.Add(this.TBXchasisNumber);
            this.Controls.Add(this.LBchasisNumber);
            this.Controls.Add(this.TBXvehicleName);
            this.Controls.Add(this.LBvehicleName);
            this.Controls.Add(this.LBclient);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNsearchVehicle);
            this.Controls.Add(this.TBXsearchVehicle);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNaddVehicle);
            this.Controls.Add(this.DTGVvehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VehiclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVvehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVvehicle;
        private System.Windows.Forms.Button BTNaddVehicle;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.TextBox TBXsearchVehicle;
        private System.Windows.Forms.Button BTNsearchVehicle;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChassisNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FluelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Label LBclient;
        private System.Windows.Forms.TextBox TBXvehicleName;
        private System.Windows.Forms.Label LBvehicleName;
        private System.Windows.Forms.TextBox TBXchasisNumber;
        private System.Windows.Forms.Label LBchasisNumber;
        private System.Windows.Forms.TextBox TBXengineNumber;
        private System.Windows.Forms.Label LBengineNumber;
        private System.Windows.Forms.TextBox TBXplateNumber;
        private System.Windows.Forms.Label LBplateNumber;
        private System.Windows.Forms.Label LBvehicleType;
        private System.Windows.Forms.ComboBox CBXvehicleType;
        private System.Windows.Forms.Label LBbrand;
        private System.Windows.Forms.ComboBox CBXbrand;
        private System.Windows.Forms.ComboBox CBXmodel;
        private System.Windows.Forms.Label LBmodel;
        private System.Windows.Forms.ComboBox CBXfluelType;
        private System.Windows.Forms.Label LBfluelType;
        private System.Windows.Forms.Button BTNcancel;
    }
}