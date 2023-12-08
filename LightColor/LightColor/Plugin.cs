using System;
using Exiled.API.Features;
using LightColor;

namespace LightColor
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

            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            Instance = null;
            base.OnDisabled();
        }
    }

}