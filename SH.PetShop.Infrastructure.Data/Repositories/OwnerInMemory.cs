using System.Collections.Generic;
using SH.PetShop.Core.Models;
using SH.PetShop.Domain.IRepositories;

namespace SH.PetShop.Infrastructure.Data.Repositories
{
    public class OwnerInMemory : IOwnerRepositstorie
    {
        private PetInMemory _petInMemory = new PetInMemory();

        private static List<Owner> _ownersList = new List<Owner>();
        private static int _id = 0;

        public List<Owner> ReadAllOwner()
        {
            return _ownersList;
        }

        public Owner AddOwner(string name, List<int> petId)
        {
            Owner owner = new Owner()
            {
                OwnerId = _id++,
                Name = name,
                PetId = petId
            };
            
            _ownersList.Add(owner);
            return owner;
        }

        public Owner DeleteOwner(int ownerId)
        {
            Owner owner = new Owner();
            owner = _ownersList.Find(o => o.OwnerId == ownerId);
            _ownersList.Remove(owner);

            return owner;
        }

        public Owner AddPetToOwner(int ownerId,Pet pet)
        {
            var owner = _ownersList.Find(o => o.OwnerId == ownerId);
            owner.PetId.Add(pet.Id);

            return owner;
        }

        public List<Pet> GetAllPetsFromOwner(int ownerId)
        {
            List<Pet> ownerPetList = new List<Pet>();
            var owner = _ownersList.Find(o => o.OwnerId == ownerId);

            foreach (var tal in owner.PetId)
            {
                Pet pet = _petInMemory.GetPetById(tal);
                ownerPetList.Add(pet);
                
            }

            return ownerPetList;
        }
    }
}