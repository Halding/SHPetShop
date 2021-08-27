using System;

namespace SH.PetShop.UI
{
    public class StringContants
    {
        public const string WelcomeText = "__________Welcome to PetshopMenu__________";
        public const string IntInvalid = "The input was not or Number or something else when wrong tryagain";
        public const string AddPetMes = "Hello to add a pet Please enter the following infomation.";
        public const string AddPetName = "Please Enter the name of the Pet";
        public const string AddPetTypeToPet = "Choose what PetType from the List";
        public const string ChooseByIdPetType = "Enter ID of the PetType you Pet is";
        public const string AddPetColor = "Pleaser enter the Color of your Pet";
        public const string InvalidDateTIme = "You input was Invalid Datetime Format is: DD-MM-YYYY.  try again";
        public const string AddPetSoldDate = "Please Enter the SoldDate of your pet in the Format: DD-MM-YYYY rememeber \"-\" ";
        public const string AddPetPrice = "Please enter the Price of the pet Only in Numbers";
        public const string BackToMain = "Press 0  to get back to Main";
        public const string AddMorePet = "Press 1 to Add one more pet";
        public  const string RemovePetById = "Please enter the ID of the pet you want to remove";

        public const string AddPetBirthday =
            "Please Enter the Birthday of your pet in the Format: DD-MM-YYYY rememeber \"-\" ";
        
        public void WelcomeMes()
        {
            
            Console.WriteLine($"{WelcomeText}");
            Console.WriteLine("                             .-.");
            Console.WriteLine("(___________________________()6 `-,");
            Console.WriteLine("(   ______________________   /''\"`");
            Console.WriteLine("//\\\\                      //\\\\");
            Console.WriteLine("\"\" \"\"                     \"\" \"\"");
            Console.WriteLine();
        }
        
        
    }
    
    
    
   
    
}