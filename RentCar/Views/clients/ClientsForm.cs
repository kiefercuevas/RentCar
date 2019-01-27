using RentCar.Data;
using RentCar.Models;
using RentCar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Views.clients
{
    public partial class ClientsForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private Client Client { get; set; }
        private string Action { get; set; }
        public ClientsForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Client = new Client();
        }

        

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            LoadClientData();
            if (Global.Variables[Global.rol].ToString() != "ADMIN")
                BTNdelete.Enabled = false;
        }

        private void LoadClientData()
        {
            var data = GetClientViewModels(_context.Clients.GetClientsWithAll(v => v.State == true));
            DTGVclients.AutoGenerateColumns = false;
            DTGVclients.DataSource = data;
            LoadPersonTypes(_context.PersonTypes.GetAll());
        }

        public IEnumerable<ClientViewModel> GetClientViewModels(IEnumerable<Client> clients)
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            foreach (var client in clients)
            {
                clientViewModels.Add(new ClientViewModel()
                {
                    ClientID = client.ClientID,
                    CreditCardNumber = client.CreditCardNumber,
                    CreditLimit = client.CreditLimit,
                    IdentificationCard = client.IdentificationCard,
                    ClientName = client.Name,
                    State = client.State,
                    Title = client.PersonType.Title
                });
            }
            return clientViewModels;
        }

        public void LoadPersonTypes(IEnumerable<PersonType> personTypes)
        {
            if (personTypes.Count() > 0)
            {
                Dictionary<int, string> personTypeData = new Dictionary<int, string>();

                foreach (var personType in personTypes)
                    personTypeData.Add(personType.PersonTypeID, personType.Title);

                CBXtypeOfPerson.DataSource = new BindingSource(personTypeData, null);
                CBXtypeOfPerson.DisplayMember = "Value";
                CBXtypeOfPerson.ValueMember = "Key";
            }
            else
            {
                CBXtypeOfPerson.DataSource = null;
                CBXtypeOfPerson.Items.Clear();
                CBXtypeOfPerson.Items.Add("No hay tipos de personas");
            }
        }



        private void DTGVclients_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVclients.Rows.Count > 0 && DTGVclients.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVclients.CurrentRow.Cells["ClientID"].Value);
                Client = _context.Clients
                    .GetClientsWithAll(c => c.ClientID == id)
                    .FirstOrDefault();

                EditClient();
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
                BTNaddClient.Text = "Editar";
            }


        }

        private void BTNsearchClient_Click(object sender, EventArgs e)
        {
            string param = TBXsearchClient.Text.ToLower();
            if (!string.IsNullOrEmpty(param))
            {
                IEnumerable<Client> clients = _context.Clients
                    .GetClientsWithAll(v => v.State == true &&
                     (v.CreditCardNumber.Contains(param) ||
                     v.CreditLimit.ToString().Contains(param) ||
                     v.IdentificationCard.Contains(param) ||
                     v.Name.Contains(param) ||
                     v.PersonType.Title.Contains(param)));

                DTGVclients.DataSource = GetClientViewModels(clients);
            }
        }

        private int GetSourceId(ComboBox comboBox)
        {
            if (comboBox.DataSource != null)
                return ((KeyValuePair<int, string>)comboBox.SelectedItem).Key;
            else
                return 0;
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            Reset();
            LoadClientData();
        }

        private void Reset()
        {
            TBXclientName.Text = null;
            TBXcreditCard.Text = null;
            TBXidentitficationCard.Text = null;
            TBXsearchClient.Text = null;
            NUDcreditLimit.Value = 0;

            BTNaddClient.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            Client = new Client();
            LoadPersonTypes(_context.PersonTypes.GetAll());
        }

        private string ValidateClientName()
        {
            string clientName = TBXclientName.Text;
            if (!string.IsNullOrEmpty(clientName))
                return "";
            else
                return "El nombre del cliente no puede estar vacio";
        }

        private string ValidateClientIdentificationCard()
        {
            string identiticationCard = TBXidentitficationCard.Text;
            string pattern = @"^\d{11}$|^\d{3}-\d{7}-\d{1}$";

            if (!string.IsNullOrEmpty(identiticationCard)){
                if (identiticationCard.Length == 11 || identiticationCard.Length == 13){
                    if (Regex.IsMatch(identiticationCard, pattern))
                    {
                        if (IsValidIdentificationCard(identiticationCard))
                            if (_context.Clients.Count(c => c.IdentificationCard == identiticationCard && c.State == true && c.ClientID != Client.ClientID) == 0 )
                            {
                                return "";
                            }
                            else
                                return "ya existe un cliente con esa cedula";
                        else
                            return "La cedula no es valida";
                    }
                    else
                        return "La cedula no cumple con el formato valido";
                }
                else
                    return "La cedula debe tener 11 o 13 digitos si incluye - ";
            }
            else
                return "La cedula del cliente no puede estar vacia";
        }


        private bool IsValidIdentificationCard(string identiticationCard)
        {
            var newIDC = identiticationCard.Replace("-",string.Empty).Trim();
            int verificatorDigit = Convert.ToInt32(newIDC.Substring(newIDC.Length - 1, 1));
            int IDClenght = newIDC.Length - 1;
            int []weight = {1,2,1,2,1,2,1,2,1,2};
            int total = 0;
            int division = 0;
            int result = 0;

            for (int i = 0;i< IDClenght; i++)
            {
                int mult = Convert.ToInt32(newIDC.Substring(i,1)) * weight[i];
                if (mult < 10)
                    total += mult;
                else
                    total += Convert.ToInt32(mult.ToString().Substring(0,1)) + Convert.ToInt32(mult.ToString().Substring(1,1));
            }

            division = total % 10;
            if (division != 0)
                result = 10 - division;
            else
                result = 0;

            if (result == verificatorDigit)
                return true;
            else
                return false;
        }

        private string ValidateClientCreditCard()
        {
            string CreditCard = TBXcreditCard.Text;
            string pattern = @"^\d{12}$";

            if (!string.IsNullOrEmpty(CreditCard))
            {
                if (CreditCard.Length == 12)
                {
                    if (Regex.IsMatch(CreditCard, pattern)){
                        return "";
                    }
                    else
                        return "La tarjeta de credito no cumple con el formato valido";
                }
                else
                    return "La tarjeta de credito debe tener 12";
            }
            else
                return "La tarjeta de credito del cliente no puede estar vacia";
        }

        private string ValidateCreditLimit()
        {
            var creditLimit = NUDcreditLimit.Value;
            if (creditLimit < 999999999)
            {
                return "";
            }
            else
                return "Ha excedido el limite de credito de 999999999";
        }

        private string GetErrors()
        {
            string clientName = ValidateClientName();
            string IdentificationCard = ValidateClientIdentificationCard();
            string creditCard = ValidateClientCreditCard();
            string creditLimit = ValidateCreditLimit();
            

            if (string.IsNullOrWhiteSpace(clientName))
            {
                if (string.IsNullOrWhiteSpace(IdentificationCard))
                {
                    if (string.IsNullOrWhiteSpace(creditCard))
                    {
                        if (string.IsNullOrWhiteSpace(creditLimit))
                        {
                            return "";
                        }
                        else
                            return creditLimit;
                    }
                    else
                        return creditCard;
                }
                else
                    return IdentificationCard;
            }
            else
                return clientName;
        }


        public void EditClient()
        {
            TBXclientName.Text = Client.Name;
            TBXcreditCard.Text = Client.CreditCardNumber;
            TBXidentitficationCard.Text = Client.IdentificationCard;
            NUDcreditLimit.Value = (decimal)Client.CreditLimit;
            CBXtypeOfPerson.SelectedIndex = CBXtypeOfPerson.FindString(Client.PersonType.Title);
        }

        private void SaveClient()
        {
            try
            {
                if (_context.Complete() > 0)
                {
                    MessageBox.Show("Se ha " + Action + " el cliente Correctamente");
                    LoadClientData();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVclients.Rows.Count > 0 && DTGVclients.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVclients.CurrentRow.Cells["ClientID"].Value);
                var client = _context.Clients.Get(id);

                switch (MessageBox.Show("Esta seguro de que desea Eliminar el cliente " + client.Name, "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        client.State = false;
                        if (_context.Complete() > 0)
                        {
                            var result = MessageBox.Show("El cliente ha sido eliminado correctamente");
                            if (result == DialogResult.OK)
                            {
                                LoadClientData();
                                Reset();
                            }
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private void BTNaddClient_Click(object sender, EventArgs e)
        {
            string errors = GetErrors();

            if (string.IsNullOrEmpty(errors))
            {
                if (Client.ClientID == 0)
                {
                    SetClient(Client);
                    _context.Clients.Add(Client);
                    Action = "Agregado";
                }
                else
                {
                    Client clientToEdit  = _context.Clients.Get(Client.ClientID);
                    SetClient(clientToEdit);
                    Action = "Editado";
                }
                SaveClient();
            }
            else
                MessageBox.Show(errors);
        }

        private void SetClient(Client client)
        {
            client.PersonTypeID = GetSourceId(CBXtypeOfPerson);

            client.Name = TBXclientName.Text;
            client.CreditCardNumber = TBXcreditCard.Text;
            client.CreditLimit = (float)NUDcreditLimit.Value;

            client.IdentificationCard = TBXidentitficationCard.Text;
            client.State = true;
        }
    }
}
