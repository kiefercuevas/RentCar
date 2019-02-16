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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.DTGVIncomes = new System.Windows.Forms.DataGridView();
            this.IncomeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentary = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BTNuserName = new System.Windows.Forms.Button();
            this.BTNchangeState = new System.Windows.Forms.Button();
            this.CBXfilter = new System.Windows.Forms.ComboBox();
            this.BTNprintRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVIncomes)).BeginInit();
            this.SuspendLayout();
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
            this.Commentary,
            this.State});
            this.DTGVIncomes.Location = new System.Drawing.Point(244, 171);
            this.DTGVIncomes.Name = "DTGVIncomes";
            this.DTGVIncomes.ReadOnly = true;
            this.DTGVIncomes.Size = new System.Drawing.Size(728, 336);
            this.DTGVIncomes.TabIndex = 1;
            this.DTGVIncomes.SelectionChanged += new System.EventHandler(this.DTGVIncomes_SelectionChanged);
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
            // Commentary
            // 
            this.Commentary.DataPropertyName = "Commentary";
            this.Commentary.HeaderText = "Comentario";
            this.Commentary.Name = "Commentary";
            this.Commentary.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado de la renta";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPStartDate.Location = new System.Drawing.Point(297, 135);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(68, 29);
            this.DTPStartDate.TabIndex = 1;
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.CalendarFont = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEndDate.Location = new System.Drawing.Point(423, 134);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(70, 29);
            this.DTPEndDate.TabIndex = 2;
            // 
            // TBXIncomeSearch
            // 
            this.TBXIncomeSearch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXIncomeSearch.Location = new System.Drawing.Point(499, 135);
            this.TBXIncomeSearch.Name = "TBXIncomeSearch";
            this.TBXIncomeSearch.Size = new System.Drawing.Size(100, 29);
            this.TBXIncomeSearch.TabIndex = 0;
            // 
            // LBStartDate
            // 
            this.LBStartDate.AutoSize = true;
            this.LBStartDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBStartDate.Location = new System.Drawing.Point(240, 139);
            this.LBStartDate.Name = "LBStartDate";
            this.LBStartDate.Size = new System.Drawing.Size(51, 20);
            this.LBStartDate.TabIndex = 3;
            this.LBStartDate.Text = "Desde:";
            // 
            // LBEndDate
            // 
            this.LBEndDate.AutoSize = true;
            this.LBEndDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEndDate.Location = new System.Drawing.Point(370, 139);
            this.LBEndDate.Name = "LBEndDate";
            this.LBEndDate.Size = new System.Drawing.Size(47, 20);
            this.LBEndDate.TabIndex = 4;
            this.LBEndDate.Text = "Hasta:";
            // 
            // BTNDateFilter
            // 
            this.BTNDateFilter.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDateFilter.Location = new System.Drawing.Point(751, 134);
            this.BTNDateFilter.Name = "BTNDateFilter";
            this.BTNDateFilter.Size = new System.Drawing.Size(88, 30);
            this.BTNDateFilter.TabIndex = 5;
            this.BTNDateFilter.Text = "Filtrar";
            this.BTNDateFilter.UseVisualStyleBackColor = true;
            this.BTNDateFilter.Click += new System.EventHandler(this.BTNDateFilter_Click);
            // 
            // BTNIncome
            // 
            this.BTNIncome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIncome.Image = ((System.Drawing.Image)(resources.GetObject("BTNIncome.Image")));
            this.BTNIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNIncome.Location = new System.Drawing.Point(12, 22);
            this.BTNIncome.Name = "BTNIncome";
            this.BTNIncome.Size = new System.Drawing.Size(205, 75);
            this.BTNIncome.TabIndex = 6;
            this.BTNIncome.Text = "Rentar vehiculo";
            this.BTNIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNIncome.UseVisualStyleBackColor = true;
            this.BTNIncome.Click += new System.EventHandler(this.BTNIncome_Click);
            // 
            // BTNvehicles
            // 
            this.BTNvehicles.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvehicles.Image = ((System.Drawing.Image)(resources.GetObject("BTNvehicles.Image")));
            this.BTNvehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNvehicles.Location = new System.Drawing.Point(223, 22);
            this.BTNvehicles.Name = "BTNvehicles";
            this.BTNvehicles.Size = new System.Drawing.Size(201, 75);
            this.BTNvehicles.TabIndex = 7;
            this.BTNvehicles.Text = "Vehiculos";
            this.BTNvehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNvehicles.UseVisualStyleBackColor = true;
            this.BTNvehicles.Click += new System.EventHandler(this.BTNvehicles_Click);
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(845, 133);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(25, 30);
            this.BTNclear.TabIndex = 8;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNEmployees
            // 
            this.BTNEmployees.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEmployees.Image = ((System.Drawing.Image)(resources.GetObject("BTNEmployees.Image")));
            this.BTNEmployees.Location = new System.Drawing.Point(12, 360);
            this.BTNEmployees.Name = "BTNEmployees";
            this.BTNEmployees.Size = new System.Drawing.Size(205, 58);
            this.BTNEmployees.TabIndex = 9;
            this.BTNEmployees.Text = "Empleados";
            this.BTNEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNEmployees.UseVisualStyleBackColor = true;
            this.BTNEmployees.Click += new System.EventHandler(this.BTNEmployees_Click);
            // 
            // BTNbrands
            // 
            this.BTNbrands.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNbrands.Image = ((System.Drawing.Image)(resources.GetObject("BTNbrands.Image")));
            this.BTNbrands.Location = new System.Drawing.Point(434, 22);
            this.BTNbrands.Name = "BTNbrands";
            this.BTNbrands.Size = new System.Drawing.Size(205, 75);
            this.BTNbrands.TabIndex = 10;
            this.BTNbrands.Text = "Marcas";
            this.BTNbrands.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNbrands.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNbrands.UseVisualStyleBackColor = true;
            this.BTNbrands.Click += new System.EventHandler(this.BTNbrands_Click);
            // 
            // BTNmodels
            // 
            this.BTNmodels.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNmodels.Image = ((System.Drawing.Image)(resources.GetObject("BTNmodels.Image")));
            this.BTNmodels.Location = new System.Drawing.Point(653, 22);
            this.BTNmodels.Name = "BTNmodels";
            this.BTNmodels.Size = new System.Drawing.Size(205, 75);
            this.BTNmodels.TabIndex = 11;
            this.BTNmodels.Text = "Modelos";
            this.BTNmodels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNmodels.UseVisualStyleBackColor = true;
            this.BTNmodels.Click += new System.EventHandler(this.BTNmodels_Click);
            // 
            // BTNfluels
            // 
            this.BTNfluels.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfluels.Image = ((System.Drawing.Image)(resources.GetObject("BTNfluels.Image")));
            this.BTNfluels.Location = new System.Drawing.Point(12, 444);
            this.BTNfluels.Name = "BTNfluels";
            this.BTNfluels.Size = new System.Drawing.Size(205, 58);
            this.BTNfluels.TabIndex = 12;
            this.BTNfluels.Text = "Combustibles";
            this.BTNfluels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNfluels.UseVisualStyleBackColor = true;
            this.BTNfluels.Click += new System.EventHandler(this.BTNfluels_Click);
            // 
            // BTNvehicleTypes
            // 
            this.BTNvehicleTypes.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvehicleTypes.Image = ((System.Drawing.Image)(resources.GetObject("BTNvehicleTypes.Image")));
            this.BTNvehicleTypes.Location = new System.Drawing.Point(12, 190);
            this.BTNvehicleTypes.Name = "BTNvehicleTypes";
            this.BTNvehicleTypes.Size = new System.Drawing.Size(205, 58);
            this.BTNvehicleTypes.TabIndex = 13;
            this.BTNvehicleTypes.Text = "Tipos de vehiculo";
            this.BTNvehicleTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNvehicleTypes.UseVisualStyleBackColor = true;
            this.BTNvehicleTypes.Click += new System.EventHandler(this.BTNvehicleTypes_Click);
            // 
            // BTNclients
            // 
            this.BTNclients.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclients.Image = ((System.Drawing.Image)(resources.GetObject("BTNclients.Image")));
            this.BTNclients.Location = new System.Drawing.Point(12, 271);
            this.BTNclients.Name = "BTNclients";
            this.BTNclients.Size = new System.Drawing.Size(205, 58);
            this.BTNclients.TabIndex = 14;
            this.BTNclients.Text = "Clientes";
            this.BTNclients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNclients.UseVisualStyleBackColor = true;
            this.BTNclients.Click += new System.EventHandler(this.BTNclients_Click);
            // 
            // BTNuserName
            // 
            this.BTNuserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNuserName.FlatAppearance.BorderSize = 0;
            this.BTNuserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNuserName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNuserName.Image = ((System.Drawing.Image)(resources.GetObject("BTNuserName.Image")));
            this.BTNuserName.Location = new System.Drawing.Point(864, 22);
            this.BTNuserName.Name = "BTNuserName";
            this.BTNuserName.Size = new System.Drawing.Size(108, 37);
            this.BTNuserName.TabIndex = 15;
            this.BTNuserName.Text = "Usuario";
            this.BTNuserName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNuserName.UseVisualStyleBackColor = true;
            this.BTNuserName.Click += new System.EventHandler(this.BTNuserName_Click);
            // 
            // BTNchangeState
            // 
            this.BTNchangeState.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNchangeState.Location = new System.Drawing.Point(876, 133);
            this.BTNchangeState.Name = "BTNchangeState";
            this.BTNchangeState.Size = new System.Drawing.Size(96, 30);
            this.BTNchangeState.TabIndex = 16;
            this.BTNchangeState.Text = "Finalizar Renta";
            this.BTNchangeState.UseVisualStyleBackColor = true;
            this.BTNchangeState.Click += new System.EventHandler(this.BTNchangeState_Click);
            // 
            // CBXfilter
            // 
            this.CBXfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXfilter.DropDownWidth = 280;
            this.CBXfilter.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXfilter.FormattingEnabled = true;
            this.CBXfilter.Location = new System.Drawing.Point(605, 134);
            this.CBXfilter.Name = "CBXfilter";
            this.CBXfilter.Size = new System.Drawing.Size(140, 30);
            this.CBXfilter.TabIndex = 17;
            // 
            // BTNprintRent
            // 
            this.BTNprintRent.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNprintRent.Image = ((System.Drawing.Image)(resources.GetObject("BTNprintRent.Image")));
            this.BTNprintRent.Location = new System.Drawing.Point(12, 116);
            this.BTNprintRent.Name = "BTNprintRent";
            this.BTNprintRent.Size = new System.Drawing.Size(205, 58);
            this.BTNprintRent.TabIndex = 18;
            this.BTNprintRent.Text = "Imprimir";
            this.BTNprintRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNprintRent.UseVisualStyleBackColor = true;
            this.BTNprintRent.Click += new System.EventHandler(this.BTNprintRent_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 519);
            this.Controls.Add(this.BTNprintRent);
            this.Controls.Add(this.CBXfilter);
            this.Controls.Add(this.BTNchangeState);
            this.Controls.Add(this.BTNuserName);
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
        private System.Windows.Forms.DataGridView DTGVIncomes;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.TextBox TBXIncomeSearch;
        private System.Windows.Forms.Label LBStartDate;
        private System.Windows.Forms.Label LBEndDate;
        private System.Windows.Forms.Button BTNDateFilter;
        private System.Windows.Forms.Button BTNIncome;
        private System.Windows.Forms.Button BTNvehicles;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNEmployees;
        private System.Windows.Forms.Button BTNbrands;
        private System.Windows.Forms.Button BTNmodels;
        private System.Windows.Forms.Button BTNfluels;
        private System.Windows.Forms.Button BTNvehicleTypes;
        private System.Windows.Forms.Button BTNclients;
        private System.Windows.Forms.Button BTNuserName;
        private System.Windows.Forms.Button BTNchangeState;
        private System.Windows.Forms.ComboBox CBXfilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn State;
        private System.Windows.Forms.Button BTNprintRent;
    }
}