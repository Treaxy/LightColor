using System;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using UnityEngine;
using MapGeneration;
using PlayerRoles;
using RemoteAdmin;

namespace LightColor

{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]

    public class ChangeLight : ICommand, IUsageProvider
    {
        public string Command => "ChangeLight";

        public string[] Aliases => new[] { "clight" };

        public string Description => "Change light";

        public string[] Usage { get; } = new string[4]
        {
            "global/room/reset",
            "r",
            "g",
            "b"
        };

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("LightChanger"))
            {
                response = "You don't have the permission";
                return false;
            }
            if (arguments.Count <= 0)
            {
                response = "No arguments given";
                return false;
            }


            switch (arguments.At(0))
            {
                case "global":
                case "room":
                    if (arguments.Count < 4)
                    {
                        response = "Not enough argument to change the color";
                        return false;
                    }
                    try
                    {
                        float red, green, blue;
                        Color color;
                        color = float.TryParse(arguments.At(1), out red)
                            ? (float.TryParse(arguments.At(2), out green)
                            ? (float.TryParse(arguments.At(3), out blue)
                            ? new Color(red, green, blue)
                            : throw new ArgumentException("3rd argument"))
                            : throw new ArgumentException("2nd argument"))
                            : throw new ArgumentException("1st argument");


                        if (arguments.At(0) == "room")
                        {
                            if (Player.Get(sender) == null)
                            {
                                response = "You need to be a player";
                                return false;
                            }
                            Player player = Player.Get(sender);
                            if (player.CurrentRoom == null)
                            {
                                response = "You are not in a room that supports changing lights color";
                                return false;
                            }                            
                            player.CurrentRoom.RoomLightController.NetworkOverrideColor = color;
                            response = "Light changed in your current room";
                            return true;
                        }
                        else
                        {
                            Map.ChangeLightsColor(color);
                            response = "Light changed in the whole facility";
                            return true;
                        }

                    }
                    catch (ArgumentException ex)
                    {
                        response = "The " + ex.Message + " had problem being processed";
                        return false;
                    }
                case "reset":
                    Map.ChangeLightsColor(Color.clear);
                    response = "Lights reset";
                    return true;
                default:
                    response = "No subcommand recognized";
                    return false;
            }
        }
    }
}