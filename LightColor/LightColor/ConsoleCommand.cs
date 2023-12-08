using System;
using System.Collections.Generic;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using Interactables.Interobjects;
using Lights;
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

                Exiled.API.Features.Player player = Exiled.API.Features.Player.Get(sender);
                if (player == null)
                {
                    response = "You need join a any server";
                    return false;
                }

                if (!sender.CheckPermission("lightcolor*"))
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

                    Color lightColor = light.NetworkOverrideColor;

                    if (lightColor == Color.red || lightColor == Color.blue || lightColor == Color.yellow || lightColor == Color.magenta || lightColor == Color.green || lightColor == Color.gray || lightColor == Color.cyan || lightColor == Color.white)
                    {
                        Map.ChangeLightsColor(Color.clear);
                    }
                }

                string message1 = Plugin.Instance.Config.LightsRed;
                string message2 = Plugin.Instance.Config.LightsBlue;
                string message3 = Plugin.Instance.Config.LightsCyan;
                string message4 = Plugin.Instance.Config.LightsGray;
                string message5 = Plugin.Instance.Config.LightsGreen;
                string message6 = Plugin.Instance.Config.LightsMagenta;
                string message7 = Plugin.Instance.Config.LightsYellow;
                string message8 = Plugin.Instance.Config.LightsDefault;

                var a = arguments.At(0);
                if (a == message1)
                {
                    Map.ChangeLightsColor(Color.red);
                    response = "Successful";
                    return true;
                }
                if (a == message2)
                {
                    Map.ChangeLightsColor(Color.blue);
                    response = "Successful";
                    return true;
                }
                if (a == message3)
                {
                    Map.ChangeLightsColor(Color.cyan);
                    response = "Successful";
                    return true;
                }
                if (a == message4)
                {
                    Map.ChangeLightsColor(Color.gray);
                    response = "Successful";
                    return true;
                }
                if (a == message5)
                {
                    Map.ChangeLightsColor(Color.green);
                    response = "Successful";
                    return true;
                }
                if (a == message6)
                {
                    Map.ChangeLightsColor(Color.magenta);
                    response = "Successful";
                    return true;
                }
                if (a == message7)
                {
                    Map.ChangeLightsColor(Color.yellow);
                    response = "Successful";
                    return true;
                }
                if (a == message8)
                {
                    Map.ChangeLightsColor(Color.clear);
                    response = "Successful";
                    return true;
                }

                response = "Lights Successful changed";
                return true;
            }
        }
    }
}