using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGifts.ConfigObjects;
namespace CustomGifts
{
    public class Config : IConfig
    {
        [Description("Enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug")]
        public bool Debug { get; set; } = false;

        [Description("Can gifts be Weapons")]
        public bool CanGiftsBeWeapons { get; set; } = true;

        [Description("Can Gifts Be Items")]
        public bool CanGiftsBeItems { get; set; } = true;

        [Description("Can Gifts Be Ammo")]
        public bool CanGiftsBeAmmo { get; set; } = true;

        [Description("Gift Weapons List. Must Be an itemType or there will be errors")]
        public List<ItemType> WeaponsTypes { get; set; } = new List<ItemType>
        {
            ItemType.GunFSP9,
            ItemType.GunCOM18,
            ItemType.GunCOM15,
            ItemType.GrenadeHE,
            ItemType.GrenadeFlash,
        };
        [Description("Gift Item List")]
        public List<ChanceList> ItemsTypes { get; set; } = new List<ChanceList>
        {
            new ChanceList
            {
                Item = ItemType.GunFSP9,
                Chance = 100,
            },
            new ChanceList
            {
                Item=ItemType.Adrenaline,
                Chance=100,
            },
            new ChanceList
            {
                Item=ItemType.Ammo9x19,
                Chance=100,
            },
            new ChanceList
            {
                Item=ItemType.Flashlight,
                Chance=100,
            },
            new ChanceList
            {
                Item=ItemType.GunFRMG0,
                Chance=1,
            },
            new ChanceList
            {
                Item=ItemType.Medkit,
                Chance=75,
            },
        };

        [Description("Gift Ammo List")]
        public List<AmmoType> AmmoTypes { get; set; } = new List<AmmoType>
            {
                AmmoType.Nato9,
                AmmoType.Nato556,
                AmmoType.Nato762,
                AmmoType.Ammo44Cal,
                AmmoType.Ammo12Gauge,
            };

    }
}
