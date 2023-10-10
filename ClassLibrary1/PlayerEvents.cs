using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace CustomGifts
{
    public class PlayerEvents
    {
        private Gifts Gifts;
        public void OnEscapingPocketDimension(EscapingPocketDimensionEventArgs ev)
        {
            Config config = new Config();
            Gifts = new Gifts();
            Log.Info($"{ev.Player.Nickname} is escaping from the pocket dimension and will be teleported at {ev.TeleportPosition}");
            string idea = Gifts.GetRandomGiftIdea();
            if (idea == "Ammo")
            {
                System.Random random = new System.Random();
                // Get the random ItemType from the list
                AmmoType given = Gifts.GetRandomAmmo();
                if (given != null)
                {
                    ushort AmmoAmmount = (ushort)random.Next(1, 51);
                    ev.Player.AddAmmo(given, AmmoAmmount);
                    ev.Player.Broadcast(5, $"You Escaped and got {given}");
                }
            }
            else if (idea == "Weapons")
            {
                System.Random random = new System.Random();
                List<ItemType> WeaponsTypes = config.WeaponsTypes;

                // Generate a random index within the range of the list
                int randomIndex = random.Next(0, WeaponsTypes.Count);

                // Get the random ItemType from the list
                ItemType given = Gifts.GetRandomWeapon();
                if (given != null)
                {
                    ev.Player.AddItem(given);
                    ev.Player.Broadcast(5, $"You Escaped and got {given}");
                }
            }
            else if (idea == "Items")
            {
                ItemType given = Gifts.GetRandomItem();
                if (given != null)
                {
                    ev.Player.AddItem(given);
                    ev.Player.Broadcast(5, $"You Escaped and got {given}");
                }
            }
        }
    }
}
