using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace LightColor
{
    public class Config : IConfig
    {
        [Description("Plugin is Enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Debug is Enabled?")]
        public bool Debug { get; set; } = false;
        [Description("Setting of command name defeult ussage: .lightcolor red")]
        public string LightsRed { get; set; } = "red";
        [Description("Setting of command name defeult ussage: .lightcolor blue")]
        public string LightsBlue { get; set; } = "blue";
        [Description("Setting of command name defeult ussage: .lightcolor green")]
        public string LightsGreen { get; set; } = "green";
        [Description("Setting of command name defeult ussage: .lightcolor yellow")]
        public string LightsYellow { get; set; } = "yellow";
        [Description("Setting of command name defeult ussage: .lightcolor gray")]
        public string LightsGray { get; set; } = "gray";
        [Description("Setting of command name defeult ussage: .lightcolor cyan")]
        public string LightsCyan { get; set; } = "cyan";
        [Description("Setting of command name defeult ussage: .lightcolor magenta")]
        public string LightsMagenta { get; set; } = "magenta";
        [Description("Setting of command name defeult ussage: .lightcolor white")]
        public string LightsWhite { get; set; } = "white";
    }
}
