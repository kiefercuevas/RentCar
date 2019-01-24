using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class ClientViewModel
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string IdentificationCard { get; set; }
        public string CreditCardNumber { get; set; }
        public float CreditLimit { get; set; }
        public bool State { get; set; }
        public string Title { get; set; }
    }
}
