using System;
using System.Collections.Generic;
using SH.PetShop.Core.Models;

namespace SH.PetShop.Domain.IRepositories
{
    public interface IPetRepositstorie
    {
        Pet AddPet(string name,PetType type,string color,double price,DateTime birthday,DateTime soldTime);

        List<Pet> GetAllPets();

        Pet RemovePet(int id);

        Pet GetPetById(int id);


    }
}