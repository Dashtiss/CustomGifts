using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using System.Collections.Generic;
using System;

namespace CustomGifts
{
    public class PlayerEvents
    {
        private readonly Gifts Gifts;
        private readonly Random Random;
        public void OnEscapingPocketDimension(EscapingPocketDimensionEventArgs ev)
        {
            Log.Info($"{ev.Player.Nickname} is escaping from the pocket dimension and will be teleported at {ev.TeleportPosition}");
        
            if (!ev.Player.IsInventoryFull) {
                Log.Debug($"Player {ev.Player.Nickname} has an open slot, put item in");
                ItemType item = Gifts.GetRandomItem();
                ev.Player.AddItem(item);
                ev.Player.Broadcast(5, $"You escaped so here is a gift, {item}");
            }
            else
            {

                Log.Debug("Player doesnt have an open slot, giving ammo");
                AmmoType Ammo = Gifts.GetRandomAmmo();
                ushort AmmoAmmount = (ushort)Random.Next(10, 50);
                ev.Player.AddAmmo(Ammo, AmmoAmmount);
                ev.Player.Broadcast(5, $"You escaped so here is a gift, {Ammo}");
            }
        }
    }
}
