using System;
using System.Threading;
using Exiled.API.Features;
using Exiled.Loader;

namespace LightColor
{

    public sealed class Plugin : Plugin<Config>
    {
        public override string Author => "Treaxy";

        public override string Name => "LightColor";

        public override Version Version => new Version(1,2,0);

        public override Version RequiredExiledVersion => new Version(8,12,2);

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