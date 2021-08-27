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
        private readonly IPetTypeService _petTypeService;
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

        public Menu(IPetService service, IPetTypeService typeService)
        {
            _service = service;
            _petTypeService = typeService;

        }

        public void ShowMenu()
        {
            Console.Clear();
            SC.WelcomeMes();
            for (int i = 0; i < menuItems.Length; i++)
            {
                _.CWL($"Press ({i + 1}) {menuItems[i]}");
            }
            _menuSeleceted = IntInput();
        }

        public void MenuSwitch()
        {
            while (_menuSeleceted != 6)
            {
                switch (_menuSeleceted)
                {
                
                    case 1:
                        PrintPetList();
                        break;
                    case 2:
                        AddPet();
                        break;
                    case 3:
                        RemovePet();
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
                ShowMenu();
            }
            
        }

        public void RemovePet()
        {
            _.CWL(StringContants.RemovePetById);
            int intInput = IntInput();
            _service.DeletePet(intInput);
        }

        public void PrintPetList()
        {
            List<Pet> petList = _service.GetAllPets();

            foreach (var pet in petList)
            {
                _.CWL($"Id: {pet.Id} Name:{pet.Name} PetType:{pet.Type.Name} Pettype ID:{pet.Type.Id} Color:{pet.Color} Birthday:{pet.Birthday} SoldDate:{pet.SoldDate} Price:{pet.Price}");
            }

            _.CRL();
        }

        public double DoubleInput()
        {
            double doInput;
            string strInput = _.CRL();
            while (!double.TryParse(strInput,out doInput))
            {
                _.CWL(StringContants.IntInvalid);
                strInput = _.CRL();
            }
            return doInput;
        }

        public int IntInput()
        {
            int intinput;
            string strInput = _.CRL();
            while (!int.TryParse(strInput,out intinput))
            {
                _.CWL(StringContants.IntInvalid);
                strInput = _.CRL();
            }

            return intinput;
        }
        public DateTime DateTimeInput()
        {
            DateTime DtInput;
            string strInput = _.CRL();
            while (!DateTime.TryParse(strInput,out DtInput))
            {
                _.CWL(StringContants.InvalidDateTIme);
                strInput = _.CRL();
            }

            return DtInput;
        }
        

        public void PrintPetTypeList()
        {
            List<PetType> petTypesList = _petTypeService.GetAllPetTypes();

            foreach (var petType in petTypesList)
            {
                _.CWL($"Name: {petType.Name} Id:{petType.Id}");
            }
            _.CWL("");
        }

        public void AddPet()
        {
            bool addMorePet = true;

            while (addMorePet)
            {
                // Message of add pet and add petname and save input
                _.CWL(StringContants.AddPetMes);
                _.CWL(StringContants.AddPetName);
                string strNameInput = _.CRL();
                
                // Message of Add pettype and save input
                _.CWL(StringContants.AddPetTypeToPet);
                _.CWL(StringContants.ChooseByIdPetType);
                PrintPetTypeList();
                PetType petType = _petTypeService.GetPetTypeById(IntInput());
                
                // Message of add pet Color And save input
                _.CWL($"\n{StringContants.AddPetColor}");
                string strColorInput = _.CRL();
                
                // Message of add pet birthday and save input
                _.CWL(StringContants.AddPetBirthday);
                DateTime birthday = DateTimeInput();
                
                // message of add pet solddate and save input
                _.CWL(StringContants.AddPetSoldDate);
                DateTime solddDate = DateTimeInput();
                
                // message of add price and save input
                _.CWL(StringContants.AddPetPrice);
                double price = DoubleInput();
                
                // Add the pet to List and Print the added pet.
                _service.CreatePet(strNameInput, petType, strColorInput, birthday, solddDate, price);
                _.CWL($"you have added the pet Name:{strNameInput} PetType:{petType.Name} Pettype ID {petType.Id}  Color:{strColorInput} Birthday:{birthday} SoldTime{solddDate} Price: {price}");
                _.CWL("");
                
                _.CWL($"{StringContants.AddMorePet} \n{StringContants.BackToMain}");
                int intAddMore = IntInput();

                if (intAddMore != 1)
                {
                    addMorePet = false;
                }

            }

        }
        
        
        
    }
}