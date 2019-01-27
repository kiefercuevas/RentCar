namespace RentCar.Views.fluel
{
    partial class FluelForm
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
            this.LBbrand = new System.Windows.Forms.Label();
            this.TBXFluelName = new System.Windows.Forms.TextBox();
            this.LBFluelName = new System.Windows.Forms.Label();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNsearchFluel = new System.Windows.Forms.Button();
            this.TBXsearchFluel = new System.Windows.Forms.TextBox();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNaddFluel = new System.Windows.Forms.Button();
            this.DTGVFluel = new System.Windows.Forms.DataGridView();
            this.FluelTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVFluel)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcancel
            // 
            this.BTNcancel.Enabled = false;
            this.BTNcancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancel.Location = new System.Drawing.Point(367, 142);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(217, 34);
            this.BTNcancel.TabIndex = 29;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Visible = false;
            this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
            // 
            // LBbrand
            // 
            this.LBbrand.AutoSize = true;
            this.LBbrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBbrand.Location = new System.Drawing.Point(12, 17);
            this.LBbrand.Name = "LBbrand";
            this.LBbrand.Size = new System.Drawing.Size(67, 25);
            this.LBbrand.TabIndex = 28;
            this.LBbrand.Text = "Buscar";
            // 
            // TBXFluelName
            // 
            this.TBXFluelName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXFluelName.Location = new System.Drawing.Point(473, 52);
            this.TBXFluelName.Name = "TBXFluelName";
            this.TBXFluelName.Size = new System.Drawing.Size(111, 29);
            this.TBXFluelName.TabIndex = 27;
            // 
            // LBFluelName
            // 
            this.LBFluelName.AutoSize = true;
            this.LBFluelName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFluelName.Location = new System.Drawing.Point(362, 52);
            this.LBFluelName.Name = "LBFluelName";
            this.LBFluelName.Size = new System.Drawing.Size(105, 25);
            this.LBFluelName.TabIndex = 26;
            this.LBFluelName.Text = "Descripcion";
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(318, 10);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(38, 35);
            this.BTNclear.TabIndex = 25;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNsearchFluel
            // 
            this.BTNsearchFluel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearchFluel.Location = new System.Drawing.Point(190, 10);
            this.BTNsearchFluel.Name = "BTNsearchFluel";
            this.BTNsearchFluel.Size = new System.Drawing.Size(101, 35);
            this.BTNsearchFluel.TabIndex = 24;
            this.BTNsearchFluel.Text = "Buscar";
            this.BTNsearchFluel.UseVisualStyleBackColor = true;
            this.BTNsearchFluel.Click += new System.EventHandler(this.BTNsearchFluel_Click);
            // 
            // TBXsearchFluel
            // 
            this.TBXsearchFluel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXsearchFluel.Location = new System.Drawing.Point(85, 12);
            this.TBXsearchFluel.Name = "TBXsearchFluel";
            this.TBXsearchFluel.Size = new System.Drawing.Size(99, 32);
            this.TBXsearchFluel.TabIndex = 23;
            // 
            // BTNdelete
            // 
            this.BTNdelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(367, 325);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(217, 33);
            this.BTNdelete.TabIndex = 22;
            this.BTNdelete.Text = "Eliminar";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // BTNaddFluel
            // 
            this.BTNaddFluel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddFluel.Location = new System.Drawing.Point(367, 102);
            this.BTNaddFluel.Name = "BTNaddFluel";
            this.BTNaddFluel.Size = new System.Drawing.Size(217, 34);
            this.BTNaddFluel.TabIndex = 21;
            this.BTNaddFluel.Text = "Agregar";
            this.BTNaddFluel.UseVisualStyleBackColor = true;
            this.BTNaddFluel.Click += new System.EventHandler(this.BTNaddFluel_Click);
            // 
            // DTGVFluel
            // 
            this.DTGVFluel.AllowUserToAddRows = false;
            this.DTGVFluel.AllowUserToDeleteRows = false;
            this.DTGVFluel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVFluel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FluelTypeID,
            this.Description,
            this.State});
            this.DTGVFluel.Location = new System.Drawing.Point(12, 48);
            this.DTGVFluel.Name = "DTGVFluel";
            this.DTGVFluel.ReadOnly = true;
            this.DTGVFluel.Size = new System.Drawing.Size(344, 310);
            this.DTGVFluel.TabIndex = 20;
            this.DTGVFluel.DoubleClick += new System.EventHandler(this.DTGVFluel_DoubleClick);
            // 
            // FluelTypeID
            // 
            this.FluelTypeID.DataPropertyName = "FluelTypeID";
            this.FluelTypeID.HeaderText = "Codigo";
            this.FluelTypeID.Name = "FluelTypeID";
            this.FluelTypeID.ReadOnly = true;
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
            // FluelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.LBbrand);
            this.Controls.Add(this.TBXFluelName);
            this.Controls.Add(this.LBFluelName);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNsearchFluel);
            this.Controls.Add(this.TBXsearchFluel);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNaddFluel);
            this.Controls.Add(this.DTGVFluel);
            this.Name = "FluelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combustibles";
            this.Load += new System.EventHandler(this.FluelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVFluel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.Label LBbrand;
        private System.Windows.Forms.TextBox TBXFluelName;
        private System.Windows.Forms.Label LBFluelName;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNsearchFluel;
        private System.Windows.Forms.TextBox TBXsearchFluel;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNaddFluel;
        private System.Windows.Forms.DataGridView DTGVFluel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FluelTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}