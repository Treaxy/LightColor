using Exiled.API.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace LightColor
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
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
            { "purple", new Color(0.5f, 0, 0.5f) },
            { "pink", new Color(1, 0.75f, 0.8f) },
            { "brown", new Color(0.5f, 0.25f, 0) },
            { "teal", new Color(0, 0.5f, 0.5f) },
            { "lime", new Color(0.5f, 1, 0) },
            { "navy", new Color(0, 0, 0.5f) },
            { "gold", new Color(1, 0.84f, 0) },
            { "silver", new Color(0.75f, 0.75f, 0.75f) },
            { "indigo", new Color(0.294f, 0, 0.51f) },
            { "lavender", new Color(0.9f, 0.9f, 0.98f) },
            { "default", Color.clear }
        };
    }
}