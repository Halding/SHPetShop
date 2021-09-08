using System;
using System.Collections.Generic;
using SH.PetShop.Core.Models;

namespace SH.PetShop.Core.IServices
{
    public interface IPetService
    {
        List<Pet> GetAllPets();

        Pet CreatePet(string name,PetType type,string color,DateTime birthday,DateTime soldDate,double price);

        Pet DeletePet(int id);

        List<Pet> SearchPetByType(string type);

        List<Pet> SearchPetName(string name);

        List<Pet> SortByPrice(List<Pet> list);

        Pet EditPet(int id);

    }
}