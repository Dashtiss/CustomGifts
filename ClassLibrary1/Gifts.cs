using CustomGifts.ConfigObjects;
using Exiled.API.Enums;
using System;
using System.Collections.Generic;

namespace CustomGifts
{
    public class Gifts
    {
        private readonly Config config;
        private readonly Random random;

        public Gifts(Config config)
        {
            this.config = config;
            random = new Random();
        }

        public ItemType GetRandomItem()
        {
            List<ChanceList> itemTypes = config.ItemsTypes;


            while (true)
            {
                int ChanceValue = random.Next(1, 101);

                int randomIndex = random.Next(0, itemTypes.Count);
                ItemType item = itemTypes[randomIndex].Item;
                int Chance = itemTypes[randomIndex].Chance;
                if (ChanceValue <= Chance)
                {
                    return item;
                }
                else
                {
                    continue;
                }
            }
        }

        public AmmoType GetRandomAmmo()
        {
            List<ChanceList> ammoTypes = config.AmmoTypes;


            while (true)
            {
                int ChanceValue = random.Next(1, 101);

                int randomIndex = random.Next(0, ammoTypes.Count);
                AmmoType ammo = ammoTypes[randomIndex].AmmoType;
                int Chance = ammoTypes[randomIndex].Chance;
                if (ChanceValue <= Chance)
                {
                    return ammo;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
