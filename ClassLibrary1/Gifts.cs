using Exiled.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGifts
{
    public class Gifts
    {
        private Config config;
        public ItemType GetRandomItem()
        {
            Random random = new Random();
            List<ItemType> itemTypes = config.ItemsTypes;

            // Generate a random index within the range of the list
            int randomIndex = random.Next(0, itemTypes.Count);

            // Get the random ItemType from the list
            ItemType randomItemType = itemTypes[randomIndex];
            return randomItemType;
        }
        public AmmoType GetRandomAmmo()
        {
            System.Random random = new System.Random();
            List<AmmoType> AmmoTypes = config.AmmoTypes;
            // Create a Random object to generate random numbers


            // Generate a random index within the range of the list
            int randomIndex = random.Next(0, AmmoTypes.Count);

            // Get the random ItemType from the list
            AmmoType given = AmmoTypes[randomIndex];
            return given;
        }
        public ItemType GetRandomWeapon()
        {
            System.Random random = new System.Random();
            List<ItemType> itemTypes = config.ItemsTypes;

            // Generate a random index within the range of the list
            int randomIndex = random.Next(0, itemTypes.Count);

            // Get the random ItemType from the list
            ItemType given = itemTypes[randomIndex];
            return given;
        }
        public string GetRandomGiftIdea()
        {
            Random random = new Random();
            List<string> giftsideas = new List<string>()
            {
                "Items",
                "Ammo",
                "Weapons"

            };

            // Generate a random index within the range of the list
            int randomIndex = random.Next(0, giftsideas.Count);

            // Get the random ItemType from the list
            string randomItemType = giftsideas[randomIndex];
            return randomItemType;
        }
    }
}
