using System;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using UnityEngine;

namespace LightColor
{
    internal class ConsoleCommand
    {
        [CommandHandler(typeof(RemoteAdminCommandHandler))]

        public class lightcolor : ICommand
        {
            public string Command => "LightColor";

            public string[] Aliases => new[] { "lcc" };

            public string Description => "Map LightColor changer";

            public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
            {

                if (!sender.CheckPermission("LightChanger"))
                {
                    response = null;
                    return false;
                }

                foreach (RoomLightController light in RoomLightController.Instances)
                {
                    if (light == null)
                    {
                        continue;
                    }

                    Map.ChangeLightsColor(Color.clear);
                }

                Color color = arguments.Count == 0
                    ? Color.clear
                    : Plugin.Instance.Config.Colors.TryGetValue(arguments.At(0), out Color col)
                        ? col
                        : Color.clear;

                Map.ChangeLightsColor(color);

                response = "Lights Successful changed";
                return true;
            }
        }
    }
}