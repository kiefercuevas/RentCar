namespace RentCar.Views.clients
{
    partial class ClientsForm
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
            this.LBclient = new System.Windows.Forms.Label();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNsearchClient = new System.Windows.Forms.Button();
            this.TBXsearchClient = new System.Windows.Forms.TextBox();
            this.DTGVclients = new System.Windows.Forms.DataGridView();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.LBclientName = new System.Windows.Forms.Label();
            this.TBXclientName = new System.Windows.Forms.TextBox();
            this.NUDcreditLimit = new System.Windows.Forms.NumericUpDown();
            this.LBcreditLimit = new System.Windows.Forms.Label();
            this.TBXidentitficationCard = new System.Windows.Forms.TextBox();
            this.LBidentitficationCard = new System.Windows.Forms.Label();
            this.LBcreditCard = new System.Windows.Forms.Label();
            this.TBXcreditCard = new System.Windows.Forms.TextBox();
            this.BTNaddClient = new System.Windows.Forms.Button();
            this.BTNcancel = new System.Windows.Forms.Button();
            this.CBXtypeOfPerson = new System.Windows.Forms.ComboBox();
            this.LBtypeOfPerson = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificationCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVclients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDcreditLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // LBclient
            // 
            this.LBclient.AutoSize = true;
            this.LBclient.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBclient.Location = new System.Drawing.Point(12, 17);
            this.LBclient.Name = "LBclient";
            this.LBclient.Size = new System.Drawing.Size(67, 25);
            this.LBclient.TabIndex = 52;
            this.LBclient.Text = "Buscar";
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(318, 10);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(38, 35);
            this.BTNclear.TabIndex = 49;
            this.BTNclear.Text = "X";
            this.BTNclear.UseVisualStyleBackColor = true;
            // 
            // BTNsearchClient
            // 
            this.BTNsearchClient.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearchClient.Location = new System.Drawing.Point(190, 10);
            this.BTNsearchClient.Name = "BTNsearchClient";
            this.BTNsearchClient.Size = new System.Drawing.Size(101, 35);
            this.BTNsearchClient.TabIndex = 48;
            this.BTNsearchClient.Text = "Buscar";
            this.BTNsearchClient.UseVisualStyleBackColor = true;
            // 
            // TBXsearchClient
            // 
            this.TBXsearchClient.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXsearchClient.Location = new System.Drawing.Point(85, 12);
            this.TBXsearchClient.Name = "TBXsearchClient";
            this.TBXsearchClient.Size = new System.Drawing.Size(99, 32);
            this.TBXsearchClient.TabIndex = 47;
            // 
            // DTGVclients
            // 
            this.DTGVclients.AllowUserToAddRows = false;
            this.DTGVclients.AllowUserToDeleteRows = false;
            this.DTGVclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVclients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.ClientName,
            this.Title,
            this.IdentificationCard,
            this.CreditCardNumber,
            this.CreditLimit,
            this.State});
            this.DTGVclients.Location = new System.Drawing.Point(12, 48);
            this.DTGVclients.Name = "DTGVclients";
            this.DTGVclients.ReadOnly = true;
            this.DTGVclients.Size = new System.Drawing.Size(344, 405);
            this.DTGVclients.TabIndex = 44;
            this.DTGVclients.DoubleClick += new System.EventHandler(this.DTGVclients_DoubleClick);
            // 
            // BTNdelete
            // 
            this.BTNdelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(367, 420);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(259, 33);
            this.BTNdelete.TabIndex = 46;
            this.BTNdelete.Text = "Eliminar";
            this.BTNdelete.UseVisualStyleBackColor = true;
            // 
            // LBclientName
            // 
            this.LBclientName.AutoSize = true;
            this.LBclientName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBclientName.Location = new System.Drawing.Point(362, 52);
            this.LBclientName.Name = "LBclientName";
            this.LBclientName.Size = new System.Drawing.Size(105, 25);
            this.LBclientName.TabIndex = 50;
            this.LBclientName.Text = "Descripcion";
            // 
            // TBXclientName
            // 
            this.TBXclientName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXclientName.Location = new System.Drawing.Point(473, 52);
            this.TBXclientName.Name = "TBXclientName";
            this.TBXclientName.Size = new System.Drawing.Size(153, 29);
            this.TBXclientName.TabIndex = 51;
            // 
            // NUDcreditLimit
            // 
            this.NUDcreditLimit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDcreditLimit.Location = new System.Drawing.Point(510, 280);
            this.NUDcreditLimit.Name = "NUDcreditLimit";
            this.NUDcreditLimit.Size = new System.Drawing.Size(116, 29);
            this.NUDcreditLimit.TabIndex = 55;
            // 
            // LBcreditLimit
            // 
            this.LBcreditLimit.AutoSize = true;
            this.LBcreditLimit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcreditLimit.Location = new System.Drawing.Point(362, 280);
            this.LBcreditLimit.Name = "LBcreditLimit";
            this.LBcreditLimit.Size = new System.Drawing.Size(143, 25);
            this.LBcreditLimit.TabIndex = 54;
            this.LBcreditLimit.Text = "Limite de credito";
            // 
            // TBXidentitficationCard
            // 
            this.TBXidentitficationCard.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXidentitficationCard.Location = new System.Drawing.Point(436, 164);
            this.TBXidentitficationCard.Name = "TBXidentitficationCard";
            this.TBXidentitficationCard.Size = new System.Drawing.Size(190, 29);
            this.TBXidentitficationCard.TabIndex = 57;
            // 
            // LBidentitficationCard
            // 
            this.LBidentitficationCard.AutoSize = true;
            this.LBidentitficationCard.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBidentitficationCard.Location = new System.Drawing.Point(362, 164);
            this.LBidentitficationCard.Name = "LBidentitficationCard";
            this.LBidentitficationCard.Size = new System.Drawing.Size(68, 25);
            this.LBidentitficationCard.TabIndex = 56;
            this.LBidentitficationCard.Text = "Cedula";
            // 
            // LBcreditCard
            // 
            this.LBcreditCard.AutoSize = true;
            this.LBcreditCard.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcreditCard.Location = new System.Drawing.Point(362, 225);
            this.LBcreditCard.Name = "LBcreditCard";
            this.LBcreditCard.Size = new System.Drawing.Size(68, 25);
            this.LBcreditCard.TabIndex = 58;
            this.LBcreditCard.Text = "Tarjeta";
            // 
            // TBXcreditCard
            // 
            this.TBXcreditCard.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXcreditCard.Location = new System.Drawing.Point(436, 221);
            this.TBXcreditCard.Name = "TBXcreditCard";
            this.TBXcreditCard.Size = new System.Drawing.Size(190, 29);
            this.TBXcreditCard.TabIndex = 59;
            // 
            // BTNaddClient
            // 
            this.BTNaddClient.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddClient.Location = new System.Drawing.Point(367, 324);
            this.BTNaddClient.Name = "BTNaddClient";
            this.BTNaddClient.Size = new System.Drawing.Size(259, 34);
            this.BTNaddClient.TabIndex = 60;
            this.BTNaddClient.Text = "Agregar";
            this.BTNaddClient.UseVisualStyleBackColor = true;
            // 
            // BTNcancel
            // 
            this.BTNcancel.Enabled = false;
            this.BTNcancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancel.Location = new System.Drawing.Point(367, 372);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(259, 34);
            this.BTNcancel.TabIndex = 61;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Visible = false;
            // 
            // CBXtypeOfPerson
            // 
            this.CBXtypeOfPerson.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXtypeOfPerson.FormattingEnabled = true;
            this.CBXtypeOfPerson.Location = new System.Drawing.Point(485, 105);
            this.CBXtypeOfPerson.Name = "CBXtypeOfPerson";
            this.CBXtypeOfPerson.Size = new System.Drawing.Size(141, 31);
            this.CBXtypeOfPerson.TabIndex = 62;
            // 
            // LBtypeOfPerson
            // 
            this.LBtypeOfPerson.AutoSize = true;
            this.LBtypeOfPerson.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtypeOfPerson.Location = new System.Drawing.Point(362, 107);
            this.LBtypeOfPerson.Name = "LBtypeOfPerson";
            this.LBtypeOfPerson.Size = new System.Drawing.Size(117, 25);
            this.LBtypeOfPerson.TabIndex = 63;
            this.LBtypeOfPerson.Text = "Tipo persona";
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "Codigo";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Nombre";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Tipo de persona";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // IdentificationCard
            // 
            this.IdentificationCard.DataPropertyName = "IdentificationCard";
            this.IdentificationCard.HeaderText = "Cedula";
            this.IdentificationCard.Name = "IdentificationCard";
            this.IdentificationCard.ReadOnly = true;
            // 
            // CreditCardNumber
            // 
            this.CreditCardNumber.DataPropertyName = "CreditCardNumber";
            this.CreditCardNumber.HeaderText = "Tarjeta de credito";
            this.CreditCardNumber.Name = "CreditCardNumber";
            this.CreditCardNumber.ReadOnly = true;
            // 
            // CreditLimit
            // 
            this.CreditLimit.DataPropertyName = "CreditLimit";
            this.CreditLimit.HeaderText = "Limite de credito";
            this.CreditLimit.Name = "CreditLimit";
            this.CreditLimit.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 465);
            this.Controls.Add(this.LBtypeOfPerson);
            this.Controls.Add(this.CBXtypeOfPerson);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.BTNaddClient);
            this.Controls.Add(this.TBXcreditCard);
            this.Controls.Add(this.LBcreditCard);
            this.Controls.Add(this.TBXidentitficationCard);
            this.Controls.Add(this.LBidentitficationCard);
            this.Controls.Add(this.NUDcreditLimit);
            this.Controls.Add(this.LBcreditLimit);
            this.Controls.Add(this.LBclient);
            this.Controls.Add(this.TBXclientName);
            this.Controls.Add(this.LBclientName);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNsearchClient);
            this.Controls.Add(this.TBXsearchClient);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.DTGVclients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVclients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDcreditLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBclient;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNsearchClient;
        private System.Windows.Forms.TextBox TBXsearchClient;
        private System.Windows.Forms.DataGridView DTGVclients;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Label LBclientName;
        private System.Windows.Forms.TextBox TBXclientName;
        private System.Windows.Forms.NumericUpDown NUDcreditLimit;
        private System.Windows.Forms.Label LBcreditLimit;
        private System.Windows.Forms.TextBox TBXidentitficationCard;
        private System.Windows.Forms.Label LBidentitficationCard;
        private System.Windows.Forms.Label LBcreditCard;
        private System.Windows.Forms.TextBox TBXcreditCard;
        private System.Windows.Forms.Button BTNaddClient;
        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.ComboBox CBXtypeOfPerson;
        private System.Windows.Forms.Label LBtypeOfPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificationCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}