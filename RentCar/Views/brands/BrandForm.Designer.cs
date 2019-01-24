namespace RentCar.Views.brands
{
    partial class BrandForm
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
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNsearchBrand = new System.Windows.Forms.Button();
            this.TBXsearchBrand = new System.Windows.Forms.TextBox();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNaddBrand = new System.Windows.Forms.Button();
            this.DTGVbrands = new System.Windows.Forms.DataGridView();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBXbrandName = new System.Windows.Forms.TextBox();
            this.LBbrandName = new System.Windows.Forms.Label();
            this.LBbrand = new System.Windows.Forms.Label();
            this.BTNcancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVbrands)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(318, 9);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(38, 35);
            this.BTNclear.TabIndex = 13;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNsearchBrand
            // 
            this.BTNsearchBrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearchBrand.Location = new System.Drawing.Point(190, 9);
            this.BTNsearchBrand.Name = "BTNsearchBrand";
            this.BTNsearchBrand.Size = new System.Drawing.Size(101, 35);
            this.BTNsearchBrand.TabIndex = 12;
            this.BTNsearchBrand.Text = "Buscar";
            this.BTNsearchBrand.UseVisualStyleBackColor = true;
            this.BTNsearchBrand.Click += new System.EventHandler(this.BTNsearchBrand_Click);
            // 
            // TBXsearchBrand
            // 
            this.TBXsearchBrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXsearchBrand.Location = new System.Drawing.Point(85, 11);
            this.TBXsearchBrand.Name = "TBXsearchBrand";
            this.TBXsearchBrand.Size = new System.Drawing.Size(99, 32);
            this.TBXsearchBrand.TabIndex = 11;
            // 
            // BTNdelete
            // 
            this.BTNdelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(367, 324);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(217, 33);
            this.BTNdelete.TabIndex = 10;
            this.BTNdelete.Text = "Eliminar";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // BTNaddBrand
            // 
            this.BTNaddBrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddBrand.Location = new System.Drawing.Point(367, 101);
            this.BTNaddBrand.Name = "BTNaddBrand";
            this.BTNaddBrand.Size = new System.Drawing.Size(217, 34);
            this.BTNaddBrand.TabIndex = 9;
            this.BTNaddBrand.Text = "Agregar";
            this.BTNaddBrand.UseVisualStyleBackColor = true;
            this.BTNaddBrand.Click += new System.EventHandler(this.BTNaddBrand_Click);
            // 
            // DTGVbrands
            // 
            this.DTGVbrands.AllowUserToAddRows = false;
            this.DTGVbrands.AllowUserToDeleteRows = false;
            this.DTGVbrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVbrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrandID,
            this.Description,
            this.State});
            this.DTGVbrands.Location = new System.Drawing.Point(12, 47);
            this.DTGVbrands.Name = "DTGVbrands";
            this.DTGVbrands.ReadOnly = true;
            this.DTGVbrands.Size = new System.Drawing.Size(344, 310);
            this.DTGVbrands.TabIndex = 8;
            this.DTGVbrands.DoubleClick += new System.EventHandler(this.DTGVbrands_DoubleClick);
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "BrandID";
            this.BrandID.HeaderText = "Codigo";
            this.BrandID.Name = "BrandID";
            this.BrandID.ReadOnly = true;
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
            // TBXbrandName
            // 
            this.TBXbrandName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXbrandName.Location = new System.Drawing.Point(473, 51);
            this.TBXbrandName.Name = "TBXbrandName";
            this.TBXbrandName.Size = new System.Drawing.Size(111, 29);
            this.TBXbrandName.TabIndex = 15;
            // 
            // LBbrandName
            // 
            this.LBbrandName.AutoSize = true;
            this.LBbrandName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBbrandName.Location = new System.Drawing.Point(362, 51);
            this.LBbrandName.Name = "LBbrandName";
            this.LBbrandName.Size = new System.Drawing.Size(105, 25);
            this.LBbrandName.TabIndex = 14;
            this.LBbrandName.Text = "Descripcion";
            // 
            // LBbrand
            // 
            this.LBbrand.AutoSize = true;
            this.LBbrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBbrand.Location = new System.Drawing.Point(12, 16);
            this.LBbrand.Name = "LBbrand";
            this.LBbrand.Size = new System.Drawing.Size(67, 25);
            this.LBbrand.TabIndex = 16;
            this.LBbrand.Text = "Buscar";
            // 
            // BTNcancel
            // 
            this.BTNcancel.Enabled = false;
            this.BTNcancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancel.Location = new System.Drawing.Point(367, 141);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(217, 34);
            this.BTNcancel.TabIndex = 19;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Visible = false;
            this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.LBbrand);
            this.Controls.Add(this.TBXbrandName);
            this.Controls.Add(this.LBbrandName);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNsearchBrand);
            this.Controls.Add(this.TBXsearchBrand);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNaddBrand);
            this.Controls.Add(this.DTGVbrands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVbrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNsearchBrand;
        private System.Windows.Forms.TextBox TBXsearchBrand;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNaddBrand;
        private System.Windows.Forms.DataGridView DTGVbrands;
        private System.Windows.Forms.TextBox TBXbrandName;
        private System.Windows.Forms.Label LBbrandName;
        private System.Windows.Forms.Label LBbrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button BTNcancel;
    }
}