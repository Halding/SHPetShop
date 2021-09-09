using System;
using System.Collections.Generic;
using System.Drawing;
using SH.PetShop.Core.Models;
using SH.PetShop.Domain.IRepositories;

namespace SH.PetShop.Infrastructure.Data.Repositories
{
    public class PetInMemory : IPetRepositstorie
    {
        private static int _id = 1;
        private static List<Pet> _petList = new List<Pet>();
        

        public Pet AddPet(string name, PetType type, string color, double price, DateTime birthday, DateTime soldTime)
        {
            Pet pet = new Pet()
            {
                Id = _id++,
                Name = name,
                Type = type,
                Color = color,
                Price = price,
                Birthday = birthday,
                SoldDate = soldTime
            };
            _petList.Add(pet);
            return pet;
        }

        public List<Pet> GetAllPets()
        {
            return _petList;
        }

        public Pet RemovePet(int id)
        {
            var pet = _petList.Find(p => p.Id == id);
            _petList.Remove(pet);
            return pet;
        }

        public Pet GetPetById(int id)
        {
            var pet = _petList.Find(p => p.Id == id);
            return pet;
        }
        
    }
}