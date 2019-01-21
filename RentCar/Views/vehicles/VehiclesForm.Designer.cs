﻿namespace RentCar.Views.vehicles
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
            this.BTNaddVehicle = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
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
            this.FluelType});
            this.DTGVvehicle.Location = new System.Drawing.Point(12, 130);
            this.DTGVvehicle.Name = "DTGVvehicle";
            this.DTGVvehicle.ReadOnly = true;
            this.DTGVvehicle.Size = new System.Drawing.Size(776, 308);
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
            // BTNaddVehicle
            // 
            this.BTNaddVehicle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddVehicle.Location = new System.Drawing.Point(12, 12);
            this.BTNaddVehicle.Name = "BTNaddVehicle";
            this.BTNaddVehicle.Size = new System.Drawing.Size(151, 51);
            this.BTNaddVehicle.TabIndex = 1;
            this.BTNaddVehicle.Text = "Agregar";
            this.BTNaddVehicle.UseVisualStyleBackColor = true;
            this.BTNaddVehicle.Click += new System.EventHandler(this.BTNaddVehicle_Click);
            // 
            // BTNdelete
            // 
            this.BTNdelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(689, 78);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(99, 46);
            this.BTNdelete.TabIndex = 4;
            this.BTNdelete.Text = "Eliminar";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNaddVehicle);
            this.Controls.Add(this.DTGVvehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VehiclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVvehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVvehicle;
        private System.Windows.Forms.Button BTNaddVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChassisNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FluelType;
        private System.Windows.Forms.Button BTNdelete;
    }
}