using System;
using Exiled.API.Features;
using Config = LightColor.Config;

namespace Lights
{

    public sealed class Plugin : Plugin<Config>
    {
        public override string Author => "Treaxy";

        public override string Name => "LightColorPlugin";

        public override Version Version => new Version(0, 2, 4);

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