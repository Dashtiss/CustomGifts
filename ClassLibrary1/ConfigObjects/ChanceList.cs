using Exiled.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGifts.ConfigObjects
{
    public class ChanceList
    {
        public ItemType ItemItem { get; set; } = ItemType.None;
        public AmmoType AmmoType { get; set; } = AmmoType.None;

        public int Chance { get; set; }
    }
}}
}
