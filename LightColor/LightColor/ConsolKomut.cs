using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;
using Exiled.API.Features;
using Exiled.API.Features.Toys;
using Exiled.Events.EventArgs.Map;
using Exiled.Permissions.Extensions;
using Lights;
using UnityEngine;
using Console = GameCore.Console;
using Light = UnityEngine.Light;

namespace AnomalyHub
{
    internal class Consolkomut
    {
        [CommandHandler(typeof(ClientCommandHandler))] //OYUN İCİ KOMUTU SİKİM SOKUM

        public class lightcolor : ICommand //KOMUT
        {
            public string Command => "LightColor"; //KOMUT İSMİ

            public string[] Aliases => new string[] { "lightcolor" }; //AA

            public string Description => "Işıkları Değiştirebiliyon iste"; //ACIKLAMA


            public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response) //BISEYLER
            {

                Exiled.API.Features.Player player = Exiled.API.Features.Player.Get(sender); //PLAYER
                if (player == null) //NULL CHECK
                {
                    response = "Oyunda olman lazım";
                    return false;
                }

                if (!player.CheckPermission("LightChanger*"))
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
                string message8 = Plugin.Instance.Config.LightsWhite;

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
                    Map.ChangeLightsColor(Color.white);
                    response = "Successful";
                    return true;
                }

                response = "Lights Successful changed"; // OYLESINE
                return true;
            }
        }
    }
}