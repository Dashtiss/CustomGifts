﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using Player = Exiled.Events.Handlers.Player;

namespace CustomGifts
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "CustomGifts";

        public override string Prefix => "CustGifts";

        public override string Author => "Dashtiss";

        private PlayerEvents PlayerEvents;
        public override void OnEnabled()
        {
            PlayerEvents = new PlayerEvents();
            Player.EscapingPocketDimension += PlayerEvents.OnEscapingPocketDimension;
            Log.Warn("Custom Gifts");
            base.OnEnabled();
        }

        public void OnDisable()
        {
            PlayerEvents = null;
            Player.EscapingPocketDimension -= PlayerEvents.OnEscapingPocketDimension;
            base.OnDisabled();
        }
    }
}
