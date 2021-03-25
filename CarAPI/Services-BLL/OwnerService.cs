using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Services_BLL
{
    public class OwnerService : IOwnerService
    {
        private IOwnerRepository OwnerRepository { get; set; }
        public OwnerService(IOwnerRepository ownerRepository )
        {
            OwnerRepository = ownerRepository;
        }

        public List<Owner> GetOwners()
        {
            return OwnerRepository.GetAllOwners();
        }

        public void AddOwner(Owner owner)
        {
            OwnerRepository.AddOwner(owner);
        }

        
        public Owner GetById(int id)
        {
            return OwnerRepository.GetOwnerById(id);
        }

        public void BuyCar(int id,Car car)
        {
            var owner = OwnerRepository.GetOwnerById(id);
            owner.Car = car;
            car.Owner = owner;
        }
    }
}