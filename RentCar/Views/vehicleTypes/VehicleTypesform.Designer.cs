namespace RentCar.Views.vehicleTypes
{
    partial class VehicleTypesForm
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
            this.BTNcancel = new System.Windows.Forms.Button();
            this.LBvehicleType = new System.Windows.Forms.Label();
            this.TBXvehicleTypeName = new System.Windows.Forms.TextBox();
            this.LBvehicletypeName = new System.Windows.Forms.Label();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNsearchVehicleType = new System.Windows.Forms.Button();
            this.TBXsearchVehicleType = new System.Windows.Forms.TextBox();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNaddVehicleType = new System.Windows.Forms.Button();
            this.DTGVvehicleType = new System.Windows.Forms.DataGridView();
            this.VehicleTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBrubberQuantity = new System.Windows.Forms.Label();
            this.NUDrubberQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVvehicleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDrubberQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcancel
            // 
            this.BTNcancel.Enabled = false;
            this.BTNcancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancel.Location = new System.Drawing.Point(367, 198);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(217, 34);
            this.BTNcancel.TabIndex = 41;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Visible = false;
            this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
            // 
            // LBvehicleType
            // 
            this.LBvehicleType.AutoSize = true;
            this.LBvehicleType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvehicleType.Location = new System.Drawing.Point(12, 17);
            this.LBvehicleType.Name = "LBvehicleType";
            this.LBvehicleType.Size = new System.Drawing.Size(67, 25);
            this.LBvehicleType.TabIndex = 39;
            this.LBvehicleType.Text = "Buscar";
            // 
            // TBXvehicleTypeName
            // 
            this.TBXvehicleTypeName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXvehicleTypeName.Location = new System.Drawing.Point(473, 52);
            this.TBXvehicleTypeName.Name = "TBXvehicleTypeName";
            this.TBXvehicleTypeName.Size = new System.Drawing.Size(111, 29);
            this.TBXvehicleTypeName.TabIndex = 38;
            // 
            // LBvehicletypeName
            // 
            this.LBvehicletypeName.AutoSize = true;
            this.LBvehicletypeName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvehicletypeName.Location = new System.Drawing.Point(362, 52);
            this.LBvehicletypeName.Name = "LBvehicletypeName";
            this.LBvehicletypeName.Size = new System.Drawing.Size(105, 25);
            this.LBvehicletypeName.TabIndex = 37;
            this.LBvehicletypeName.Text = "Descripcion";
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(318, 10);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(38, 35);
            this.BTNclear.TabIndex = 36;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNsearchVehicleType
            // 
            this.BTNsearchVehicleType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearchVehicleType.Location = new System.Drawing.Point(190, 10);
            this.BTNsearchVehicleType.Name = "BTNsearchVehicleType";
            this.BTNsearchVehicleType.Size = new System.Drawing.Size(101, 35);
            this.BTNsearchVehicleType.TabIndex = 35;
            this.BTNsearchVehicleType.Text = "Buscar";
            this.BTNsearchVehicleType.UseVisualStyleBackColor = true;
            this.BTNsearchVehicleType.Click += new System.EventHandler(this.BTNsearchVehicleType_Click);
            // 
            // TBXsearchVehicleType
            // 
            this.TBXsearchVehicleType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXsearchVehicleType.Location = new System.Drawing.Point(85, 12);
            this.TBXsearchVehicleType.Name = "TBXsearchVehicleType";
            this.TBXsearchVehicleType.Size = new System.Drawing.Size(99, 32);
            this.TBXsearchVehicleType.TabIndex = 34;
            // 
            // BTNdelete
            // 
            this.BTNdelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(367, 325);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(217, 33);
            this.BTNdelete.TabIndex = 33;
            this.BTNdelete.Text = "Eliminar";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // BTNaddVehicleType
            // 
            this.BTNaddVehicleType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddVehicleType.Location = new System.Drawing.Point(367, 158);
            this.BTNaddVehicleType.Name = "BTNaddVehicleType";
            this.BTNaddVehicleType.Size = new System.Drawing.Size(217, 34);
            this.BTNaddVehicleType.TabIndex = 32;
            this.BTNaddVehicleType.Text = "Agregar";
            this.BTNaddVehicleType.UseVisualStyleBackColor = true;
            this.BTNaddVehicleType.Click += new System.EventHandler(this.BTNaddVehicleType_Click);
            // 
            // DTGVvehicleType
            // 
            this.DTGVvehicleType.AllowUserToAddRows = false;
            this.DTGVvehicleType.AllowUserToDeleteRows = false;
            this.DTGVvehicleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVvehicleType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleTypeID,
            this.Description,
            this.State});
            this.DTGVvehicleType.Location = new System.Drawing.Point(12, 48);
            this.DTGVvehicleType.Name = "DTGVvehicleType";
            this.DTGVvehicleType.ReadOnly = true;
            this.DTGVvehicleType.Size = new System.Drawing.Size(344, 310);
            this.DTGVvehicleType.TabIndex = 31;
            this.DTGVvehicleType.DoubleClick += new System.EventHandler(this.DTGVvehicleType_DoubleClick);
            // 
            // VehicleTypeID
            // 
            this.VehicleTypeID.DataPropertyName = "VehicleTypeID";
            this.VehicleTypeID.HeaderText = "Codigo";
            this.VehicleTypeID.Name = "VehicleTypeID";
            this.VehicleTypeID.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // LBrubberQuantity
            // 
            this.LBrubberQuantity.AutoSize = true;
            this.LBrubberQuantity.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBrubberQuantity.Location = new System.Drawing.Point(362, 107);
            this.LBrubberQuantity.Name = "LBrubberQuantity";
            this.LBrubberQuantity.Size = new System.Drawing.Size(141, 25);
            this.LBrubberQuantity.TabIndex = 42;
            this.LBrubberQuantity.Text = "Cantidad gomas";
            // 
            // NUDrubberQuantity
            // 
            this.NUDrubberQuantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDrubberQuantity.Location = new System.Drawing.Point(509, 107);
            this.NUDrubberQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NUDrubberQuantity.Name = "NUDrubberQuantity";
            this.NUDrubberQuantity.Size = new System.Drawing.Size(74, 29);
            this.NUDrubberQuantity.TabIndex = 43;
            // 
            // VehicleTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.NUDrubberQuantity);
            this.Controls.Add(this.LBrubberQuantity);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.LBvehicleType);
            this.Controls.Add(this.TBXvehicleTypeName);
            this.Controls.Add(this.LBvehicletypeName);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNsearchVehicleType);
            this.Controls.Add(this.TBXsearchVehicleType);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNaddVehicleType);
            this.Controls.Add(this.DTGVvehicleType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VehicleTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipos de vehiculo";
            this.Load += new System.EventHandler(this.VehicleTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVvehicleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDrubberQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.Label LBvehicleType;
        private System.Windows.Forms.TextBox TBXvehicleTypeName;
        private System.Windows.Forms.Label LBvehicletypeName;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNsearchVehicleType;
        private System.Windows.Forms.TextBox TBXsearchVehicleType;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNaddVehicleType;
        private System.Windows.Forms.DataGridView DTGVvehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Label LBrubberQuantity;
        private System.Windows.Forms.NumericUpDown NUDrubberQuantity;
    }
}