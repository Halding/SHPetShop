using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SH.PetShop.Core.IServices;
using SH.PetShop.Core.Models;

namespace SH.PetShop.UI
{
    public class Menu
    {
        private readonly IPetService _service;
        private Util _ = new Util();
        private StringContants SC = new StringContants();
        private int _menuSeleceted;
        
        public string[] menuItems =
        {
          "List All Pets",
          "Add New Pet",
          "Delete a Pet",
          "Search for Pet",
          "Edit Pet",
          "Exit"
            
        };

        public Menu(IPetService service)
        {
            _service = service;
        }

        public void ShowMenu()
        {
            Console.Clear();
            SC.WelcomeMes();
            for (int i = 0; i < menuItems.Length; i++)
            {
                _.CWL($"Press ({i + 1}) {menuItems[i]}");
            }

            string strInput = _.CRL();
            int intInput;
            while (!int.TryParse(strInput,out intInput))
            {
                _.CWL(StringContants.IntInvalid);
                strInput = _.CRL();
            }

            _menuSeleceted = intInput;
        }

        public void MenuSwitch()
        {
            while (_menuSeleceted != 6)
            {
                switch (_menuSeleceted)
                {
                
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case  5:
                        break;
                    default:
                    _.CWL(StringContants.IntInvalid);
                    _.CRL();
                        break;
                }
                
                
            }
            
        }

        public void PrintPetList()
        {
            List<Pet> petList = _service.GetAllPets();

            foreach (var pet in petList)
            {
                _.CWL($"Id: {pet.Id} Name:{pet.Name} PetType:{pet.Type} Color:{pet.Color} Birthday:{pet.Birthday} SoldDate:{pet.SoldDate} Price:{pet.Price}");
            }

            _.CRL();
        }

        public void AddPet()
        {
            bool addMorePet = true;

            while (addMorePet)
            {
                _.CWL(StringContants.AddPetMes);
                _.CWL(StringContants.AddPetName);
                string strNameInput = _.CRL();
                _.CWL(StringContants.AddPetTypeToPet);
                
            }

        }
        
        
        
    }
}