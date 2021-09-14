using System.Collections.Generic;
using SH.PetShop.Core.Models;

namespace SH.PetShop.Domain.IRepositories
{
    public interface IOwnerRepositstorie
    {
        List<Owner> ReadAllOwner();

        Owner AddOwner(string name, List<int> petId);

        Owner DeleteOwner(int ownerId);

        Owner AddPetToOwner(int ownerId, Pet pet);

        List<Pet> GetAllPetsFromOwner(int ownerId);

    }
}