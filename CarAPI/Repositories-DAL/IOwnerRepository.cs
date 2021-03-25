using CarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Repositories_DAL
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();

        Owner GetOwnerById(int id);
        void AddOwner(Owner owner);

    }
}
