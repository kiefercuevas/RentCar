namespace RentCar.Views.models
{
    partial class ModelsForm
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
            this.LBModel = new System.Windows.Forms.Label();
            this.TBXmodelName = new System.Windows.Forms.TextBox();
            this.LBmodelName = new System.Windows.Forms.Label();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNsearchModel = new System.Windows.Forms.Button();
            this.TBXsearchModel = new System.Windows.Forms.TextBox();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNaddModel = new System.Windows.Forms.Button();
            this.DTGVmodels = new System.Windows.Forms.DataGridView();
            this.ModelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBXbrands = new System.Windows.Forms.ComboBox();
            this.LBbrand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVmodels)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcancel
            // 
            this.BTNcancel.Enabled = false;
            this.BTNcancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancel.Location = new System.Drawing.Point(367, 190);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(217, 34);
            this.BTNcancel.TabIndex = 30;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Visible = false;
            this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
            // 
            // LBModel
            // 
            this.LBModel.AutoSize = true;
            this.LBModel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBModel.Location = new System.Drawing.Point(12, 17);
            this.LBModel.Name = "LBModel";
            this.LBModel.Size = new System.Drawing.Size(67, 25);
            this.LBModel.TabIndex = 28;
            this.LBModel.Text = "Buscar";
            // 
            // TBXmodelName
            // 
            this.TBXmodelName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXmodelName.Location = new System.Drawing.Point(473, 52);
            this.TBXmodelName.Name = "TBXmodelName";
            this.TBXmodelName.Size = new System.Drawing.Size(111, 29);
            this.TBXmodelName.TabIndex = 27;
            // 
            // LBmodelName
            // 
            this.LBmodelName.AutoSize = true;
            this.LBmodelName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBmodelName.Location = new System.Drawing.Point(362, 52);
            this.LBmodelName.Name = "LBmodelName";
            this.LBmodelName.Size = new System.Drawing.Size(105, 25);
            this.LBmodelName.TabIndex = 26;
            this.LBmodelName.Text = "Descripcion";
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
            // BTNsearchModel
            // 
            this.BTNsearchModel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearchModel.Location = new System.Drawing.Point(190, 10);
            this.BTNsearchModel.Name = "BTNsearchModel";
            this.BTNsearchModel.Size = new System.Drawing.Size(101, 35);
            this.BTNsearchModel.TabIndex = 24;
            this.BTNsearchModel.Text = "Buscar";
            this.BTNsearchModel.UseVisualStyleBackColor = true;
            this.BTNsearchModel.Click += new System.EventHandler(this.BTNsearchModel_Click);
            // 
            // TBXsearchModel
            // 
            this.TBXsearchModel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXsearchModel.Location = new System.Drawing.Point(85, 12);
            this.TBXsearchModel.Name = "TBXsearchModel";
            this.TBXsearchModel.Size = new System.Drawing.Size(99, 32);
            this.TBXsearchModel.TabIndex = 23;
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
            this.BTNdelete.Visible = false;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // BTNaddModel
            // 
            this.BTNaddModel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddModel.Location = new System.Drawing.Point(367, 150);
            this.BTNaddModel.Name = "BTNaddModel";
            this.BTNaddModel.Size = new System.Drawing.Size(217, 34);
            this.BTNaddModel.TabIndex = 21;
            this.BTNaddModel.Text = "Agregar";
            this.BTNaddModel.UseVisualStyleBackColor = true;
            this.BTNaddModel.Click += new System.EventHandler(this.BTNaddModel_Click);
            // 
            // DTGVmodels
            // 
            this.DTGVmodels.AllowUserToAddRows = false;
            this.DTGVmodels.AllowUserToDeleteRows = false;
            this.DTGVmodels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVmodels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelID,
            this.Description,
            this.State});
            this.DTGVmodels.Location = new System.Drawing.Point(12, 48);
            this.DTGVmodels.Name = "DTGVmodels";
            this.DTGVmodels.ReadOnly = true;
            this.DTGVmodels.Size = new System.Drawing.Size(344, 310);
            this.DTGVmodels.TabIndex = 20;
            this.DTGVmodels.DoubleClick += new System.EventHandler(this.DTGVmodels_DoubleClick);
            // 
            // ModelID
            // 
            this.ModelID.DataPropertyName = "ModelID";
            this.ModelID.HeaderText = "Codigo";
            this.ModelID.Name = "ModelID";
            this.ModelID.ReadOnly = true;
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
            // CBXbrands
            // 
            this.CBXbrands.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXbrands.FormattingEnabled = true;
            this.CBXbrands.Location = new System.Drawing.Point(473, 99);
            this.CBXbrands.Name = "CBXbrands";
            this.CBXbrands.Size = new System.Drawing.Size(111, 31);
            this.CBXbrands.TabIndex = 31;
            // 
            // LBbrand
            // 
            this.LBbrand.AutoSize = true;
            this.LBbrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBbrand.Location = new System.Drawing.Point(362, 105);
            this.LBbrand.Name = "LBbrand";
            this.LBbrand.Size = new System.Drawing.Size(62, 25);
            this.LBbrand.TabIndex = 32;
            this.LBbrand.Text = "Marca";
            // 
            // ModelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.LBbrand);
            this.Controls.Add(this.CBXbrands);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.LBModel);
            this.Controls.Add(this.TBXmodelName);
            this.Controls.Add(this.LBmodelName);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNsearchModel);
            this.Controls.Add(this.TBXsearchModel);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNaddModel);
            this.Controls.Add(this.DTGVmodels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos";
            this.Load += new System.EventHandler(this.ModelsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVmodels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.Label LBModel;
        private System.Windows.Forms.TextBox TBXmodelName;
        private System.Windows.Forms.Label LBmodelName;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNsearchModel;
        private System.Windows.Forms.TextBox TBXsearchModel;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNaddModel;
        private System.Windows.Forms.DataGridView DTGVmodels;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.ComboBox CBXbrands;
        private System.Windows.Forms.Label LBbrand;
    }
}