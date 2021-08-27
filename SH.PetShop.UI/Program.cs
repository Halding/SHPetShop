using System;
using SH.PetShop.Core.IServices;
using SH.PetShop.Domain.IRepositories;
using SH.PetShop.Domain.Services;
using SH.PetShop.Infrastructure.Data.Repositories;

namespace SH.PetShop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            IPetRepositstorie petRepo = new PetInMemory();
            IPetTypeRepositorie petTypeRepo = new PetTypeInMemory();
            
            IPetService petService = new PetService(petRepo);
            IPetTypeService petTypeService = new PetTypeService(petTypeRepo);
                
            var menu = new Menu(petService,petTypeService);
            menu.ShowMenu();
            menu.MenuSwitch();

        }
    }
}