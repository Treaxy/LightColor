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
using UnityEngine;
using Console = GameCore.Console;
using Light = UnityEngine.Light;

namespace LightColor
{
    internal class Consolkomut
    {
        [CommandHandler(typeof(ClientCommandHandler))] //OYUN İCİ KOMUTU SİKİM SOKUM

        public class lightcolor : ICommand //KOMUT
        {
            public string Command => "LightColor"; //KOMUT İSMİ

            public string[] Aliases => Array.Empty<string>();

            public string Description => "Işıkları Değiştirebiliyon iste"; //ACIKLAMA


            public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response) //BISEYLER
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
                
                // Color color = Plugin.Instance.Config.Colors.TryGetValue()
                Color color = arguments.Count == 0
                    ? Color.white
                    : Plugin.Instance.Config.Colors.TryGetValue(arguments.At(0), out Color col)
                        ? col
                        : Color.white;
                
                Map.ChangeLightsColor(color);
                response = "Lights Successful changed"; // OYLESINE
                return true;
            }
        }
    }
}