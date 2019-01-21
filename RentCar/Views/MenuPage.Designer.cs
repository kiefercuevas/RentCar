namespace RentCar.Views
{
    partial class MenuPage
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
            this.LBUserName = new System.Windows.Forms.Label();
            this.DTGVIncomes = new System.Windows.Forms.DataGridView();
            this.IncomeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.TBXIncomeSearch = new System.Windows.Forms.TextBox();
            this.LBStartDate = new System.Windows.Forms.Label();
            this.LBEndDate = new System.Windows.Forms.Label();
            this.BTNDateFilter = new System.Windows.Forms.Button();
            this.BTNIncome = new System.Windows.Forms.Button();
            this.BTNvehicles = new System.Windows.Forms.Button();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNEmployees = new System.Windows.Forms.Button();
            this.BTNbrands = new System.Windows.Forms.Button();
            this.BTNmodels = new System.Windows.Forms.Button();
            this.BTNfluels = new System.Windows.Forms.Button();
            this.BTNvehicleTypes = new System.Windows.Forms.Button();
            this.BTNclients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVIncomes)).BeginInit();
            this.SuspendLayout();
            // 
            // LBUserName
            // 
            this.LBUserName.AutoSize = true;
            this.LBUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUserName.Location = new System.Drawing.Point(678, 22);
            this.LBUserName.Name = "LBUserName";
            this.LBUserName.Size = new System.Drawing.Size(0, 25);
            this.LBUserName.TabIndex = 0;
            // 
            // DTGVIncomes
            // 
            this.DTGVIncomes.AllowUserToDeleteRows = false;
            this.DTGVIncomes.AllowUserToResizeColumns = false;
            this.DTGVIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncomeID,
            this.IncomeDate,
            this.RefundDate,
            this.AmountPerDay,
            this.NumberOfDays,
            this.State});
            this.DTGVIncomes.Location = new System.Drawing.Point(244, 171);
            this.DTGVIncomes.Name = "DTGVIncomes";
            this.DTGVIncomes.ReadOnly = true;
            this.DTGVIncomes.Size = new System.Drawing.Size(544, 267);
            this.DTGVIncomes.TabIndex = 1;
            this.DTGVIncomes.DoubleClick += new System.EventHandler(this.DTGVIncomes_DoubleClick);
            // 
            // IncomeID
            // 
            this.IncomeID.DataPropertyName = "IncomeID";
            this.IncomeID.HeaderText = "Codigo";
            this.IncomeID.Name = "IncomeID";
            this.IncomeID.ReadOnly = true;
            // 
            // IncomeDate
            // 
            this.IncomeDate.DataPropertyName = "IncomeDate";
            this.IncomeDate.HeaderText = "Fecha Renta";
            this.IncomeDate.Name = "IncomeDate";
            this.IncomeDate.ReadOnly = true;
            // 
            // RefundDate
            // 
            this.RefundDate.DataPropertyName = "RefundDate";
            this.RefundDate.HeaderText = "Fecha Devolucion";
            this.RefundDate.Name = "RefundDate";
            this.RefundDate.ReadOnly = true;
            // 
            // AmountPerDay
            // 
            this.AmountPerDay.DataPropertyName = "AmountPerDay";
            this.AmountPerDay.HeaderText = "Monto x Dia";
            this.AmountPerDay.Name = "AmountPerDay";
            this.AmountPerDay.ReadOnly = true;
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.DataPropertyName = "NumberOfDays";
            this.NumberOfDays.HeaderText = "CantidadDias";
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Location = new System.Drawing.Point(303, 144);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(68, 20);
            this.DTPStartDate.TabIndex = 1;
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Location = new System.Drawing.Point(429, 144);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(70, 20);
            this.DTPEndDate.TabIndex = 2;
            // 
            // TBXIncomeSearch
            // 
            this.TBXIncomeSearch.Location = new System.Drawing.Point(547, 144);
            this.TBXIncomeSearch.Name = "TBXIncomeSearch";
            this.TBXIncomeSearch.Size = new System.Drawing.Size(160, 20);
            this.TBXIncomeSearch.TabIndex = 0;
            // 
            // LBStartDate
            // 
            this.LBStartDate.AutoSize = true;
            this.LBStartDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBStartDate.Location = new System.Drawing.Point(240, 143);
            this.LBStartDate.Name = "LBStartDate";
            this.LBStartDate.Size = new System.Drawing.Size(53, 20);
            this.LBStartDate.TabIndex = 3;
            this.LBStartDate.Text = "Desde:";
            // 
            // LBEndDate
            // 
            this.LBEndDate.AutoSize = true;
            this.LBEndDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEndDate.Location = new System.Drawing.Point(377, 143);
            this.LBEndDate.Name = "LBEndDate";
            this.LBEndDate.Size = new System.Drawing.Size(46, 20);
            this.LBEndDate.TabIndex = 4;
            this.LBEndDate.Text = "Hasta:";
            // 
            // BTNDateFilter
            // 
            this.BTNDateFilter.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDateFilter.Location = new System.Drawing.Point(713, 142);
            this.BTNDateFilter.Name = "BTNDateFilter";
            this.BTNDateFilter.Size = new System.Drawing.Size(75, 22);
            this.BTNDateFilter.TabIndex = 5;
            this.BTNDateFilter.Text = "Filtrar";
            this.BTNDateFilter.UseVisualStyleBackColor = true;
            this.BTNDateFilter.Click += new System.EventHandler(this.BTNDateFilter_Click);
            // 
            // BTNIncome
            // 
            this.BTNIncome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIncome.Location = new System.Drawing.Point(12, 22);
            this.BTNIncome.Name = "BTNIncome";
            this.BTNIncome.Size = new System.Drawing.Size(205, 54);
            this.BTNIncome.TabIndex = 6;
            this.BTNIncome.Text = "Rentar Vehiculo";
            this.BTNIncome.UseVisualStyleBackColor = true;
            this.BTNIncome.Click += new System.EventHandler(this.BTNIncome_Click);
            // 
            // BTNvehicles
            // 
            this.BTNvehicles.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvehicles.Location = new System.Drawing.Point(12, 157);
            this.BTNvehicles.Name = "BTNvehicles";
            this.BTNvehicles.Size = new System.Drawing.Size(205, 35);
            this.BTNvehicles.TabIndex = 7;
            this.BTNvehicles.Text = "Vehiculos";
            this.BTNvehicles.UseVisualStyleBackColor = true;
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(508, 144);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(25, 20);
            this.BTNclear.TabIndex = 8;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNEmployees
            // 
            this.BTNEmployees.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEmployees.Location = new System.Drawing.Point(12, 362);
            this.BTNEmployees.Name = "BTNEmployees";
            this.BTNEmployees.Size = new System.Drawing.Size(205, 35);
            this.BTNEmployees.TabIndex = 9;
            this.BTNEmployees.Text = "Empleados";
            this.BTNEmployees.UseVisualStyleBackColor = true;
            // 
            // BTNbrands
            // 
            this.BTNbrands.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNbrands.Location = new System.Drawing.Point(12, 239);
            this.BTNbrands.Name = "BTNbrands";
            this.BTNbrands.Size = new System.Drawing.Size(205, 35);
            this.BTNbrands.TabIndex = 10;
            this.BTNbrands.Text = "Marcas";
            this.BTNbrands.UseVisualStyleBackColor = true;
            // 
            // BTNmodels
            // 
            this.BTNmodels.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNmodels.Location = new System.Drawing.Point(12, 280);
            this.BTNmodels.Name = "BTNmodels";
            this.BTNmodels.Size = new System.Drawing.Size(205, 35);
            this.BTNmodels.TabIndex = 11;
            this.BTNmodels.Text = "Modelos";
            this.BTNmodels.UseVisualStyleBackColor = true;
            // 
            // BTNfluels
            // 
            this.BTNfluels.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfluels.Location = new System.Drawing.Point(12, 403);
            this.BTNfluels.Name = "BTNfluels";
            this.BTNfluels.Size = new System.Drawing.Size(205, 35);
            this.BTNfluels.TabIndex = 12;
            this.BTNfluels.Text = "Combustibles";
            this.BTNfluels.UseVisualStyleBackColor = true;
            // 
            // BTNvehicleTypes
            // 
            this.BTNvehicleTypes.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvehicleTypes.Location = new System.Drawing.Point(12, 198);
            this.BTNvehicleTypes.Name = "BTNvehicleTypes";
            this.BTNvehicleTypes.Size = new System.Drawing.Size(205, 35);
            this.BTNvehicleTypes.TabIndex = 13;
            this.BTNvehicleTypes.Text = "Tipos de vehiculo";
            this.BTNvehicleTypes.UseVisualStyleBackColor = true;
            // 
            // BTNclients
            // 
            this.BTNclients.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclients.Location = new System.Drawing.Point(12, 321);
            this.BTNclients.Name = "BTNclients";
            this.BTNclients.Size = new System.Drawing.Size(205, 35);
            this.BTNclients.TabIndex = 14;
            this.BTNclients.Text = "Clientes";
            this.BTNclients.UseVisualStyleBackColor = true;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNclients);
            this.Controls.Add(this.BTNvehicleTypes);
            this.Controls.Add(this.BTNfluels);
            this.Controls.Add(this.BTNmodels);
            this.Controls.Add(this.BTNbrands);
            this.Controls.Add(this.BTNEmployees);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNvehicles);
            this.Controls.Add(this.BTNIncome);
            this.Controls.Add(this.BTNDateFilter);
            this.Controls.Add(this.LBEndDate);
            this.Controls.Add(this.LBStartDate);
            this.Controls.Add(this.TBXIncomeSearch);
            this.Controls.Add(this.DTPEndDate);
            this.Controls.Add(this.DTPStartDate);
            this.Controls.Add(this.DTGVIncomes);
            this.Controls.Add(this.LBUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPage_FormClosing);
            this.Load += new System.EventHandler(this.MenuPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVIncomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBUserName;
        private System.Windows.Forms.DataGridView DTGVIncomes;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.TextBox TBXIncomeSearch;
        private System.Windows.Forms.Label LBStartDate;
        private System.Windows.Forms.Label LBEndDate;
        private System.Windows.Forms.Button BTNDateFilter;
        private System.Windows.Forms.Button BTNIncome;
        private System.Windows.Forms.Button BTNvehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDays;
        private System.Windows.Forms.DataGridViewCheckBoxColumn State;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNEmployees;
        private System.Windows.Forms.Button BTNbrands;
        private System.Windows.Forms.Button BTNmodels;
        private System.Windows.Forms.Button BTNfluels;
        private System.Windows.Forms.Button BTNvehicleTypes;
        private System.Windows.Forms.Button BTNclients;
    }
}