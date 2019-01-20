namespace RentCar.Views
{
    partial class IncomeForm
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
            this.DTPrefundDate = new System.Windows.Forms.DateTimePicker();
            this.LBincome = new System.Windows.Forms.Label();
            this.LBrefountDate = new System.Windows.Forms.Label();
            this.LBamountxDay = new System.Windows.Forms.Label();
            this.NUDamountxDay = new System.Windows.Forms.NumericUpDown();
            this.RTBXcomment = new System.Windows.Forms.RichTextBox();
            this.LBcomment = new System.Windows.Forms.Label();
            this.BTNfinishIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDamountxDay)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPrefundDate
            // 
            this.DTPrefundDate.Location = new System.Drawing.Point(158, 83);
            this.DTPrefundDate.Name = "DTPrefundDate";
            this.DTPrefundDate.Size = new System.Drawing.Size(200, 20);
            this.DTPrefundDate.TabIndex = 0;
            // 
            // LBincome
            // 
            this.LBincome.AutoSize = true;
            this.LBincome.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBincome.Location = new System.Drawing.Point(12, 9);
            this.LBincome.Name = "LBincome";
            this.LBincome.Size = new System.Drawing.Size(88, 37);
            this.LBincome.TabIndex = 1;
            this.LBincome.Text = "Renta";
            // 
            // LBrefountDate
            // 
            this.LBrefountDate.AutoSize = true;
            this.LBrefountDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBrefountDate.Location = new System.Drawing.Point(14, 83);
            this.LBrefountDate.Name = "LBrefountDate";
            this.LBrefountDate.Size = new System.Drawing.Size(138, 25);
            this.LBrefountDate.TabIndex = 2;
            this.LBrefountDate.Text = "Fec. devolucion";
            // 
            // LBamountxDay
            // 
            this.LBamountxDay.AutoSize = true;
            this.LBamountxDay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBamountxDay.Location = new System.Drawing.Point(14, 142);
            this.LBamountxDay.Name = "LBamountxDay";
            this.LBamountxDay.Size = new System.Drawing.Size(104, 25);
            this.LBamountxDay.TabIndex = 3;
            this.LBamountxDay.Text = "Monto x dia";
            // 
            // NUDamountxDay
            // 
            this.NUDamountxDay.Location = new System.Drawing.Point(158, 144);
            this.NUDamountxDay.Name = "NUDamountxDay";
            this.NUDamountxDay.Size = new System.Drawing.Size(99, 20);
            this.NUDamountxDay.TabIndex = 4;
            // 
            // RTBXcomment
            // 
            this.RTBXcomment.Location = new System.Drawing.Point(19, 234);
            this.RTBXcomment.Name = "RTBXcomment";
            this.RTBXcomment.Size = new System.Drawing.Size(339, 149);
            this.RTBXcomment.TabIndex = 5;
            this.RTBXcomment.Text = "";
            // 
            // LBcomment
            // 
            this.LBcomment.AutoSize = true;
            this.LBcomment.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcomment.Location = new System.Drawing.Point(14, 197);
            this.LBcomment.Name = "LBcomment";
            this.LBcomment.Size = new System.Drawing.Size(103, 25);
            this.LBcomment.TabIndex = 6;
            this.LBcomment.Text = "Comentario";
            // 
            // BTNfinishIncome
            // 
            this.BTNfinishIncome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfinishIncome.Location = new System.Drawing.Point(19, 389);
            this.BTNfinishIncome.Name = "BTNfinishIncome";
            this.BTNfinishIncome.Size = new System.Drawing.Size(339, 49);
            this.BTNfinishIncome.TabIndex = 7;
            this.BTNfinishIncome.Text = "Finalizar Renta";
            this.BTNfinishIncome.UseVisualStyleBackColor = true;
            this.BTNfinishIncome.Click += new System.EventHandler(this.BTNfinishIncome_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.BTNfinishIncome);
            this.Controls.Add(this.LBcomment);
            this.Controls.Add(this.RTBXcomment);
            this.Controls.Add(this.NUDamountxDay);
            this.Controls.Add(this.LBamountxDay);
            this.Controls.Add(this.LBrefountDate);
            this.Controls.Add(this.LBincome);
            this.Controls.Add(this.DTPrefundDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncomeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NUDamountxDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPrefundDate;
        private System.Windows.Forms.Label LBincome;
        private System.Windows.Forms.Label LBrefountDate;
        private System.Windows.Forms.Label LBamountxDay;
        private System.Windows.Forms.NumericUpDown NUDamountxDay;
        private System.Windows.Forms.RichTextBox RTBXcomment;
        private System.Windows.Forms.Label LBcomment;
        private System.Windows.Forms.Button BTNfinishIncome;
    }
}