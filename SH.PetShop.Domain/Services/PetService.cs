using System;
using System.Collections.Generic;
using SH.PetShop.Core.IServices;
using SH.PetShop.Core.Models;
using SH.PetShop.Domain.IRepositories;

namespace SH.PetShop.Domain.Services
{
    public class PetService : IPetService
    {

        private IPetRepositstorie _repo;
        
        public PetService(IPetRepositstorie repo)
        {
            _repo = repo;
        }

        public List<Pet> GetAllPets()
        {
            return _repo.GetAllPets();
        }

        public Pet CreatePet(string name, PetType type, string color, DateTime birthday, DateTime soldDate, double price)
        {
            return _repo.AddPet(name, type,color,price,birthday,soldDate );
        }

        public Pet DeletePet(int id)
        {
            return _repo.RemovePet(id);
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