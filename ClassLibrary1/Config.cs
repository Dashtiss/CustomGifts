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

        [Description("Can Gifts Be Items")]
        public bool CanGiftsBeItems { get; set; } = true;

        [Description("Can Gifts Be Ammo")]
        public bool CanGiftsBeAmmo { get; set; } = true;
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
        public List<ChanceList> AmmoTypes { get; set; } = new List<ChanceList>
            {
                new ChanceList
                {
                    AmmoType=AmmoType.Nato9,
                    Chance=75,
                },
                new ChanceList
                {
                    AmmoType=AmmoType.Ammo44Cal,
                    Chance=75
                },
                new ChanceList
                {
                    AmmoType=AmmoType.Nato556,
                    Chance=50
                },
                new ChanceList
                {
                    AmmoType=AmmoType.Nato762,
                    Chance=50
                },
                new ChanceList
                {
                    AmmoType=AmmoType.Ammo12Gauge,
                    Chance=10
                },
            };

    }
}
