namespace RentCar.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LBdividerLine = new System.Windows.Forms.Label();
            this.LBSlogan = new System.Windows.Forms.Label();
            this.LBRentCar = new System.Windows.Forms.Label();
            this.LBEmail = new System.Windows.Forms.Label();
            this.LBPassword = new System.Windows.Forms.Label();
            this.TBXEmail = new System.Windows.Forms.TextBox();
            this.TBXPassword = new System.Windows.Forms.TextBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.PBRentCarImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBRentCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LBdividerLine
            // 
            this.LBdividerLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBdividerLine.Location = new System.Drawing.Point(-9, 135);
            this.LBdividerLine.Name = "LBdividerLine";
            this.LBdividerLine.Size = new System.Drawing.Size(822, 2);
            this.LBdividerLine.TabIndex = 0;
            this.LBdividerLine.Text = "_________________";
            // 
            // LBSlogan
            // 
            this.LBSlogan.AutoSize = true;
            this.LBSlogan.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSlogan.Location = new System.Drawing.Point(487, 81);
            this.LBSlogan.Name = "LBSlogan";
            this.LBSlogan.Size = new System.Drawing.Size(259, 25);
            this.LBSlogan.TabIndex = 2;
            this.LBSlogan.Text = "Sistema de Renta de Vehiculos";
            // 
            // LBRentCar
            // 
            this.LBRentCar.AutoSize = true;
            this.LBRentCar.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRentCar.Location = new System.Drawing.Point(614, 38);
            this.LBRentCar.Name = "LBRentCar";
            this.LBRentCar.Size = new System.Drawing.Size(132, 43);
            this.LBRentCar.TabIndex = 1;
            this.LBRentCar.Text = "RentCar";
            // 
            // LBEmail
            // 
            this.LBEmail.AutoSize = true;
            this.LBEmail.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEmail.Location = new System.Drawing.Point(233, 231);
            this.LBEmail.Name = "LBEmail";
            this.LBEmail.Size = new System.Drawing.Size(74, 29);
            this.LBEmail.TabIndex = 2;
            this.LBEmail.Text = "Correo";
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPassword.Location = new System.Drawing.Point(233, 282);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(62, 29);
            this.LBPassword.TabIndex = 3;
            this.LBPassword.Text = "Clave";
            // 
            // TBXEmail
            // 
            this.TBXEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXEmail.Location = new System.Drawing.Point(315, 233);
            this.TBXEmail.Name = "TBXEmail";
            this.TBXEmail.Size = new System.Drawing.Size(227, 29);
            this.TBXEmail.TabIndex = 0;
            // 
            // TBXPassword
            // 
            this.TBXPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXPassword.Location = new System.Drawing.Point(315, 283);
            this.TBXPassword.Multiline = true;
            this.TBXPassword.Name = "TBXPassword";
            this.TBXPassword.PasswordChar = '*';
            this.TBXPassword.Size = new System.Drawing.Size(227, 28);
            this.TBXPassword.TabIndex = 1;
            // 
            // BTNLogin
            // 
            this.BTNLogin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogin.Location = new System.Drawing.Point(238, 332);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(304, 41);
            this.BTNLogin.TabIndex = 2;
            this.BTNLogin.Text = "Ingresar";
            this.BTNLogin.UseVisualStyleBackColor = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // PBRentCarImage
            // 
            this.PBRentCarImage.Image = ((System.Drawing.Image)(resources.GetObject("PBRentCarImage.Image")));
            this.PBRentCarImage.Location = new System.Drawing.Point(-9, -2);
            this.PBRentCarImage.Name = "PBRentCarImage";
            this.PBRentCarImage.Size = new System.Drawing.Size(809, 136);
            this.PBRentCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBRentCarImage.TabIndex = 0;
            this.PBRentCarImage.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBSlogan);
            this.Controls.Add(this.LBRentCar);
            this.Controls.Add(this.PBRentCarImage);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.TBXPassword);
            this.Controls.Add(this.TBXEmail);
            this.Controls.Add(this.LBPassword);
            this.Controls.Add(this.LBEmail);
            this.Controls.Add(this.LBdividerLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PBRentCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBdividerLine;
        private System.Windows.Forms.Label LBSlogan;
        private System.Windows.Forms.Label LBRentCar;
        private System.Windows.Forms.Label LBEmail;
        private System.Windows.Forms.Label LBPassword;
        private System.Windows.Forms.TextBox TBXEmail;
        private System.Windows.Forms.TextBox TBXPassword;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.PictureBox PBRentCarImage;
    }
}

