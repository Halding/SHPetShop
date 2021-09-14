using System.Collections.Generic;
using SH.PetShop.Core.IServices;
using SH.PetShop.Core.Models;
using SH.PetShop.Domain.IRepositories;

namespace SH.PetShop.Domain.Services
{
    public class OwnerService : IOwnerService
    {

        private IOwnerRepositstorie _repo;

        public OwnerService(IOwnerRepositstorie repo)
        {
            _repo = repo;
        }

        public List<Owner> GetAllOwner()
        {
            return _repo.ReadAllOwner();
        }

        public Owner CreateOwner(string name, List<int> petId)
        {
            return _repo.AddOwner(name, petId);
        }

        public Owner DeleteOwner(int ownerId)
        {
            return _repo.DeleteOwner(ownerId);
        }

        public Owner AddPetToOwner(int ownerId, Pet pet)
        {
            return _repo.AddPetToOwner(ownerId, pet);
        }

        public Owner GetOwnerById(int ownerId)
        {
            throw new System.NotImplementedException();
        }

        public List<Pet> GetListOfPetFromOwner(int ownerId)
        {
            return _repo.GetAllPetsFromOwner(ownerId);
        }
    }
}