using CarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Services_BLL
{
    public interface IOwnerService
    {
        void AddOwner(Owner owner);
        void BuyCar(int id, Car car);
        Owner GetById(int id);
        List<Owner> GetOwners();
    }
}
