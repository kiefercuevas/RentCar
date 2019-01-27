namespace RentCar.Views.user
{
    partial class UserSettings
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
            this.TBXcurrentPassword = new System.Windows.Forms.TextBox();
            this.LBchangePassword = new System.Windows.Forms.Label();
            this.LBcurrentPassword = new System.Windows.Forms.Label();
            this.LBnewPassword = new System.Windows.Forms.Label();
            this.TBXnewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBXconfirmNewPassword = new System.Windows.Forms.TextBox();
            this.BTNchangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBXcurrentPassword
            // 
            this.TBXcurrentPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXcurrentPassword.Location = new System.Drawing.Point(191, 45);
            this.TBXcurrentPassword.Name = "TBXcurrentPassword";
            this.TBXcurrentPassword.Size = new System.Drawing.Size(148, 26);
            this.TBXcurrentPassword.TabIndex = 4;
            // 
            // LBchangePassword
            // 
            this.LBchangePassword.AutoSize = true;
            this.LBchangePassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBchangePassword.Location = new System.Drawing.Point(12, 9);
            this.LBchangePassword.Name = "LBchangePassword";
            this.LBchangePassword.Size = new System.Drawing.Size(165, 23);
            this.LBchangePassword.TabIndex = 3;
            this.LBchangePassword.Text = "Cambiar Contraseña";
            // 
            // LBcurrentPassword
            // 
            this.LBcurrentPassword.AutoSize = true;
            this.LBcurrentPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcurrentPassword.Location = new System.Drawing.Point(12, 48);
            this.LBcurrentPassword.Name = "LBcurrentPassword";
            this.LBcurrentPassword.Size = new System.Drawing.Size(136, 23);
            this.LBcurrentPassword.TabIndex = 5;
            this.LBcurrentPassword.Text = "Contraseña actual";
            // 
            // LBnewPassword
            // 
            this.LBnewPassword.AutoSize = true;
            this.LBnewPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnewPassword.Location = new System.Drawing.Point(12, 94);
            this.LBnewPassword.Name = "LBnewPassword";
            this.LBnewPassword.Size = new System.Drawing.Size(137, 23);
            this.LBnewPassword.TabIndex = 7;
            this.LBnewPassword.Text = "Nueva contraseña";
            // 
            // TBXnewPassword
            // 
            this.TBXnewPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXnewPassword.Location = new System.Drawing.Point(191, 91);
            this.TBXnewPassword.Name = "TBXnewPassword";
            this.TBXnewPassword.Size = new System.Drawing.Size(148, 26);
            this.TBXnewPassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirmar contraseña";
            // 
            // TBXconfirmNewPassword
            // 
            this.TBXconfirmNewPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXconfirmNewPassword.Location = new System.Drawing.Point(191, 137);
            this.TBXconfirmNewPassword.Name = "TBXconfirmNewPassword";
            this.TBXconfirmNewPassword.Size = new System.Drawing.Size(148, 26);
            this.TBXconfirmNewPassword.TabIndex = 8;
            // 
            // BTNchangePassword
            // 
            this.BTNchangePassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNchangePassword.Location = new System.Drawing.Point(16, 177);
            this.BTNchangePassword.Name = "BTNchangePassword";
            this.BTNchangePassword.Size = new System.Drawing.Size(323, 55);
            this.BTNchangePassword.TabIndex = 10;
            this.BTNchangePassword.Text = "Cambiar contraseña";
            this.BTNchangePassword.UseVisualStyleBackColor = true;
            this.BTNchangePassword.Click += new System.EventHandler(this.BTNchangePassword_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 244);
            this.Controls.Add(this.BTNchangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBXconfirmNewPassword);
            this.Controls.Add(this.LBnewPassword);
            this.Controls.Add(this.TBXnewPassword);
            this.Controls.Add(this.LBcurrentPassword);
            this.Controls.Add(this.TBXcurrentPassword);
            this.Controls.Add(this.LBchangePassword);
            this.Name = "UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBXcurrentPassword;
        private System.Windows.Forms.Label LBchangePassword;
        private System.Windows.Forms.Label LBcurrentPassword;
        private System.Windows.Forms.Label LBnewPassword;
        private System.Windows.Forms.TextBox TBXnewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBXconfirmNewPassword;
        private System.Windows.Forms.Button BTNchangePassword;
    }
}