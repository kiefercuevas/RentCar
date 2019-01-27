namespace RentCar.Views.employees
{
    partial class EmployeesForm
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
            this.LBworkShift = new System.Windows.Forms.Label();
            this.CBXworkShift = new System.Windows.Forms.ComboBox();
            this.BTNcancel = new System.Windows.Forms.Button();
            this.BTNaddEmployee = new System.Windows.Forms.Button();
            this.LBadmissionDate = new System.Windows.Forms.Label();
            this.TBXidentitficationCard = new System.Windows.Forms.TextBox();
            this.LBidentitficationCard = new System.Windows.Forms.Label();
            this.NUDcommissionPercentage = new System.Windows.Forms.NumericUpDown();
            this.LBcommissionPercentage = new System.Windows.Forms.Label();
            this.LBcemployee = new System.Windows.Forms.Label();
            this.TBXemployeeName = new System.Windows.Forms.TextBox();
            this.LBemployeeName = new System.Windows.Forms.Label();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNsearchEmployee = new System.Windows.Forms.Button();
            this.TBXsearchEmployee = new System.Windows.Forms.TextBox();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.DTGVemployees = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificationCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommissionPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPadmissionDate = new System.Windows.Forms.DateTimePicker();
            this.LBtypeOfUser = new System.Windows.Forms.Label();
            this.CBXroles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDcommissionPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVemployees)).BeginInit();
            this.SuspendLayout();
            // 
            // LBworkShift
            // 
            this.LBworkShift.AutoSize = true;
            this.LBworkShift.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBworkShift.Location = new System.Drawing.Point(362, 168);
            this.LBworkShift.Name = "LBworkShift";
            this.LBworkShift.Size = new System.Drawing.Size(122, 25);
            this.LBworkShift.TabIndex = 81;
            this.LBworkShift.Text = "Tanda laboral";
            // 
            // CBXworkShift
            // 
            this.CBXworkShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXworkShift.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXworkShift.FormattingEnabled = true;
            this.CBXworkShift.Location = new System.Drawing.Point(485, 166);
            this.CBXworkShift.Name = "CBXworkShift";
            this.CBXworkShift.Size = new System.Drawing.Size(141, 31);
            this.CBXworkShift.TabIndex = 3;
            // 
            // BTNcancel
            // 
            this.BTNcancel.Enabled = false;
            this.BTNcancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancel.Location = new System.Drawing.Point(367, 373);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(259, 34);
            this.BTNcancel.TabIndex = 80;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Visible = false;
            this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
            // 
            // BTNaddEmployee
            // 
            this.BTNaddEmployee.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddEmployee.Location = new System.Drawing.Point(367, 325);
            this.BTNaddEmployee.Name = "BTNaddEmployee";
            this.BTNaddEmployee.Size = new System.Drawing.Size(259, 34);
            this.BTNaddEmployee.TabIndex = 6;
            this.BTNaddEmployee.Text = "Agregar";
            this.BTNaddEmployee.UseVisualStyleBackColor = true;
            this.BTNaddEmployee.Click += new System.EventHandler(this.BTNaddEmployee_Click);
            // 
            // LBadmissionDate
            // 
            this.LBadmissionDate.AutoSize = true;
            this.LBadmissionDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBadmissionDate.Location = new System.Drawing.Point(362, 226);
            this.LBadmissionDate.Name = "LBadmissionDate";
            this.LBadmissionDate.Size = new System.Drawing.Size(124, 25);
            this.LBadmissionDate.TabIndex = 79;
            this.LBadmissionDate.Text = "Fec. Admision";
            // 
            // TBXidentitficationCard
            // 
            this.TBXidentitficationCard.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXidentitficationCard.Location = new System.Drawing.Point(436, 67);
            this.TBXidentitficationCard.Name = "TBXidentitficationCard";
            this.TBXidentitficationCard.Size = new System.Drawing.Size(190, 29);
            this.TBXidentitficationCard.TabIndex = 1;
            // 
            // LBidentitficationCard
            // 
            this.LBidentitficationCard.AutoSize = true;
            this.LBidentitficationCard.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBidentitficationCard.Location = new System.Drawing.Point(362, 67);
            this.LBidentitficationCard.Name = "LBidentitficationCard";
            this.LBidentitficationCard.Size = new System.Drawing.Size(68, 25);
            this.LBidentitficationCard.TabIndex = 78;
            this.LBidentitficationCard.Text = "Cedula";
            // 
            // NUDcommissionPercentage
            // 
            this.NUDcommissionPercentage.DecimalPlaces = 2;
            this.NUDcommissionPercentage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDcommissionPercentage.Location = new System.Drawing.Point(485, 281);
            this.NUDcommissionPercentage.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NUDcommissionPercentage.Name = "NUDcommissionPercentage";
            this.NUDcommissionPercentage.Size = new System.Drawing.Size(141, 29);
            this.NUDcommissionPercentage.TabIndex = 5;
            // 
            // LBcommissionPercentage
            // 
            this.LBcommissionPercentage.AutoSize = true;
            this.LBcommissionPercentage.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcommissionPercentage.Location = new System.Drawing.Point(362, 281);
            this.LBcommissionPercentage.Name = "LBcommissionPercentage";
            this.LBcommissionPercentage.Size = new System.Drawing.Size(106, 25);
            this.LBcommissionPercentage.TabIndex = 77;
            this.LBcommissionPercentage.Text = "% comision";
            // 
            // LBcemployee
            // 
            this.LBcemployee.AutoSize = true;
            this.LBcemployee.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcemployee.Location = new System.Drawing.Point(12, 18);
            this.LBcemployee.Name = "LBcemployee";
            this.LBcemployee.Size = new System.Drawing.Size(67, 25);
            this.LBcemployee.TabIndex = 76;
            this.LBcemployee.Text = "Buscar";
            // 
            // TBXemployeeName
            // 
            this.TBXemployeeName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXemployeeName.Location = new System.Drawing.Point(473, 18);
            this.TBXemployeeName.Name = "TBXemployeeName";
            this.TBXemployeeName.Size = new System.Drawing.Size(153, 29);
            this.TBXemployeeName.TabIndex = 0;
            // 
            // LBemployeeName
            // 
            this.LBemployeeName.AutoSize = true;
            this.LBemployeeName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBemployeeName.Location = new System.Drawing.Point(362, 18);
            this.LBemployeeName.Name = "LBemployeeName";
            this.LBemployeeName.Size = new System.Drawing.Size(105, 25);
            this.LBemployeeName.TabIndex = 75;
            this.LBemployeeName.Text = "Descripcion";
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(318, 11);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(38, 35);
            this.BTNclear.TabIndex = 74;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNsearchEmployee
            // 
            this.BTNsearchEmployee.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearchEmployee.Location = new System.Drawing.Point(190, 11);
            this.BTNsearchEmployee.Name = "BTNsearchEmployee";
            this.BTNsearchEmployee.Size = new System.Drawing.Size(101, 35);
            this.BTNsearchEmployee.TabIndex = 73;
            this.BTNsearchEmployee.Text = "Buscar";
            this.BTNsearchEmployee.UseVisualStyleBackColor = true;
            this.BTNsearchEmployee.Click += new System.EventHandler(this.BTNsearchEmployee_Click);
            // 
            // TBXsearchEmployee
            // 
            this.TBXsearchEmployee.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXsearchEmployee.Location = new System.Drawing.Point(85, 13);
            this.TBXsearchEmployee.Name = "TBXsearchEmployee";
            this.TBXsearchEmployee.Size = new System.Drawing.Size(99, 32);
            this.TBXsearchEmployee.TabIndex = 72;
            // 
            // BTNdelete
            // 
            this.BTNdelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(367, 421);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(259, 33);
            this.BTNdelete.TabIndex = 7;
            this.BTNdelete.Text = "Eliminar";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // DTGVemployees
            // 
            this.DTGVemployees.AllowUserToAddRows = false;
            this.DTGVemployees.AllowUserToDeleteRows = false;
            this.DTGVemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVemployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmpName,
            this.IdentificationCard,
            this.WorkShift,
            this.CommissionPercentage,
            this.AdmissionDate,
            this.State,
            this.UserRole});
            this.DTGVemployees.Location = new System.Drawing.Point(12, 49);
            this.DTGVemployees.Name = "DTGVemployees";
            this.DTGVemployees.ReadOnly = true;
            this.DTGVemployees.Size = new System.Drawing.Size(344, 405);
            this.DTGVemployees.TabIndex = 70;
            this.DTGVemployees.DoubleClick += new System.EventHandler(this.DTGVemployees_DoubleClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Codigo";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Nombre";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // IdentificationCard
            // 
            this.IdentificationCard.DataPropertyName = "IdentificationCard";
            this.IdentificationCard.HeaderText = "Cedula";
            this.IdentificationCard.Name = "IdentificationCard";
            this.IdentificationCard.ReadOnly = true;
            // 
            // WorkShift
            // 
            this.WorkShift.DataPropertyName = "WorkShift";
            this.WorkShift.HeaderText = "Tanda laboral";
            this.WorkShift.Name = "WorkShift";
            this.WorkShift.ReadOnly = true;
            // 
            // CommissionPercentage
            // 
            this.CommissionPercentage.DataPropertyName = "CommissionPercentage";
            this.CommissionPercentage.HeaderText = "Porcentaje de comision";
            this.CommissionPercentage.Name = "CommissionPercentage";
            this.CommissionPercentage.ReadOnly = true;
            // 
            // AdmissionDate
            // 
            this.AdmissionDate.DataPropertyName = "AdmissionDate";
            this.AdmissionDate.HeaderText = "Fec. Admision";
            this.AdmissionDate.Name = "AdmissionDate";
            this.AdmissionDate.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // UserRole
            // 
            this.UserRole.DataPropertyName = "UserRole";
            this.UserRole.HeaderText = "Tipo de usuario";
            this.UserRole.Name = "UserRole";
            this.UserRole.ReadOnly = true;
            // 
            // DTPadmissionDate
            // 
            this.DTPadmissionDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPadmissionDate.Location = new System.Drawing.Point(485, 226);
            this.DTPadmissionDate.Name = "DTPadmissionDate";
            this.DTPadmissionDate.Size = new System.Drawing.Size(141, 29);
            this.DTPadmissionDate.TabIndex = 4;
            // 
            // LBtypeOfUser
            // 
            this.LBtypeOfUser.AutoSize = true;
            this.LBtypeOfUser.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtypeOfUser.Location = new System.Drawing.Point(362, 115);
            this.LBtypeOfUser.Name = "LBtypeOfUser";
            this.LBtypeOfUser.Size = new System.Drawing.Size(38, 25);
            this.LBtypeOfUser.TabIndex = 84;
            this.LBtypeOfUser.Text = "Rol";
            // 
            // CBXroles
            // 
            this.CBXroles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXroles.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXroles.FormattingEnabled = true;
            this.CBXroles.Location = new System.Drawing.Point(419, 113);
            this.CBXroles.Name = "CBXroles";
            this.CBXroles.Size = new System.Drawing.Size(207, 31);
            this.CBXroles.TabIndex = 2;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 465);
            this.Controls.Add(this.LBtypeOfUser);
            this.Controls.Add(this.CBXroles);
            this.Controls.Add(this.DTPadmissionDate);
            this.Controls.Add(this.LBworkShift);
            this.Controls.Add(this.CBXworkShift);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.BTNaddEmployee);
            this.Controls.Add(this.LBadmissionDate);
            this.Controls.Add(this.TBXidentitficationCard);
            this.Controls.Add(this.LBidentitficationCard);
            this.Controls.Add(this.NUDcommissionPercentage);
            this.Controls.Add(this.LBcommissionPercentage);
            this.Controls.Add(this.LBcemployee);
            this.Controls.Add(this.TBXemployeeName);
            this.Controls.Add(this.LBemployeeName);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNsearchEmployee);
            this.Controls.Add(this.TBXsearchEmployee);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.DTGVemployees);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDcommissionPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVemployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBworkShift;
        private System.Windows.Forms.ComboBox CBXworkShift;
        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.Button BTNaddEmployee;
        private System.Windows.Forms.Label LBadmissionDate;
        private System.Windows.Forms.TextBox TBXidentitficationCard;
        private System.Windows.Forms.Label LBidentitficationCard;
        private System.Windows.Forms.NumericUpDown NUDcommissionPercentage;
        private System.Windows.Forms.Label LBcommissionPercentage;
        private System.Windows.Forms.Label LBcemployee;
        private System.Windows.Forms.TextBox TBXemployeeName;
        private System.Windows.Forms.Label LBemployeeName;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNsearchEmployee;
        private System.Windows.Forms.TextBox TBXsearchEmployee;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.DataGridView DTGVemployees;
        private System.Windows.Forms.DateTimePicker DTPadmissionDate;
        private System.Windows.Forms.Label LBtypeOfUser;
        private System.Windows.Forms.ComboBox CBXroles;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificationCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommissionPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
    }
}