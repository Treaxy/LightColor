using System;
using Exiled.API.Features;

namespace LightColor
{

    public sealed class Plugin : Plugin<Config>
    {
        public override string Author => "Treaxy, Modified by Antoniofo";

        public override string Name => "LightColorPlugin";

        public override Version Version => new Version(2, 0, 0);

        public override string Prefix => "light_color";        

        public override void OnEnabled()
        {            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {            
            base.OnDisabled();
        }
    }
}