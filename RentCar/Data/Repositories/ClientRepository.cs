using RentCar.Data.Core;
using RentCar.Models;
namespace RentCar.Data.Repositories
{
    public class ClientRepository :Repository<Client>,IClientRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public ClientRepository(RentCarContex context)
            :base(context)
        {

        }
    }
}
