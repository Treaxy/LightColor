using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using UnityEngine;

namespace LightColor
{
    public class Config : IConfig
    {
        [Description("Plugin is Enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Debug is Enabled?")]
        public bool Debug { get; set; } = false;
        public Dictionary<string, Color> Colors { get; set; } = new Dictionary<string, Color>()
        {
            { "red", Color.red },
            { "blue", Color.blue },
            { "cyan", Color.cyan },
            { "gray", Color.gray },
            { "green", Color.green },
            { "magenta", Color.magenta },
            { "yellow", Color.yellow },
            { "orange", new Color(1, 0.5f, 0) },
            { "default", Color.clear }
        };
    }
}