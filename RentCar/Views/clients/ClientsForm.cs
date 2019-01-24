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



        }
    }
}
