using RentCar.Data.Core;
using RentCar.Models;
namespace RentCar.Data.Repositories
{
    public class PersonTypeRepository :Repository<PersonType>,IPersonTypeRepository
    {
        public RentCarContex _RentCarContex
        {
            get { return _Context as RentCarContex; }
        }
        public PersonTypeRepository(RentCarContex context)
            : base(context)
        {

        }
    }
}
