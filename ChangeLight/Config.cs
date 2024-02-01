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
    }
}