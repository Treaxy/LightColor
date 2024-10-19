using System;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Loader;
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

            public string Description => "Map Light Color changer";

            public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
            {
                if (!sender.CheckPermission("LightChanger"))
                {
                    response = "You need 'LightChanger' permission to use this command!";
                    return false;
                }
                try
                {
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
                    response = "Lights Successfuly changed";
                    return true;
                }
                catch (Exception ex) 
                {
                    Log.Error("ConsoleCommand: "+ex.Message.ToString());
                    response = "Error Occurred! Look your console to see error.";
                    return false;
                }
            }
        }
    }
}