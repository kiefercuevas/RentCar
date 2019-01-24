using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RentCar.Data.Core;
using RentCar.Models;
using System.Data.Entity;
using System.Linq;
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

        public IEnumerable<Client> GetClientsWithAll(Expression<Func<Client, bool>> predicate)
        {
            return _RentCarContex.Clients
                .Include(c => c.PersonType)
                .Where(predicate).ToList();
        }
    }
}
