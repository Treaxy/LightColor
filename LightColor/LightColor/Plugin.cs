using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled;
using Exiled.Events;
using Exiled.Events.EventArgs;
using Exiled.Events.Features;
using PlayerRoles;
using Playerev = Exiled.Events.Handlers.Player;
using SRV = Exiled.Events.Handlers.Server;
using AnomalyHub;
using TMPro;
using LightColor;
using Exiled.CreditTags;
using Config = LightColor.Config;

namespace Lights
{

    public sealed class Plugin : Plugin<Config>
    {
        public override string Author => "Treaxy";

        public override string Name => "LightColorPlugin";

        public override Version Version => new Version(0, 1, 3);

        public override string Prefix => Name;

        public static Plugin Instance;

        public override void OnEnabled()
        {
            Instance = this;

            RegisterEvents();

            base.OnEnabled();
            Log.Info("Successfully Active, By Treaxy");
        }

        public override void OnDisabled()
        {
            UnregisterEvents();

            Instance = null;

            base.OnDisabled();
            Log.Info("Successfully DeActive, By Treaxy");
        }

        private void RegisterEvents()
        {
            base.OnEnabled();
            Log.Info("REGISTERED");
        }

        private void UnregisterEvents()
        {
            base.OnDisabled();
            Log.Info("UNREGISTERED");

        }
    }

}