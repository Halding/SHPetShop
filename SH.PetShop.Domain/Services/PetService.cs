using System;
using System.Collections.Generic;
using SH.PetShop.Core.IServices;
using SH.PetShop.Core.Models;
using SH.PetShop.Domain.IRepositories;

namespace SH.PetShop.Domain.Services
{
    public class PetService : IPetService
    {
        public PetService(IPetRepositstorie repo)
        {
            
        }

        public List<Pet> GetAllPets()
        {
            throw new NotImplementedException();
        }

        public Pet CreatePet(string name, string color, DateTime birthday, DateTime soldDate, double price)
        {
            throw new NotImplementedException();
        }

        public Pet DeletePet(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> SearchPetByType(PetType type)
        {
            throw new NotImplementedException();
        }

        public List<Pet> SearchPetName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Pet> SortByPrice(List<Pet> list)
        {
            throw new NotImplementedException();
        }

        public Pet EditPet(int id)
        {
            throw new NotImplementedException();
        }
    }
}