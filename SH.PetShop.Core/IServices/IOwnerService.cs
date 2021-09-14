using System.Collections.Generic;
using SH.PetShop.Core.Models;

namespace SH.PetShop.Core.IServices
{
    public interface IOwnerService
    {
        List<Owner> GetAllOwner();

        Owner CreateOwner(string name, List<int> petId);

        Owner DeleteOwner(int ownerId);

        Owner AddPetToOwner(int ownerId, Pet pet);

        Owner GetOwnerById(int ownerId);

        List<Pet> GetListOfPetFromOwner(int ownerId);
    }
}