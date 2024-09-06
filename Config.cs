using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Exiled.API.Interfaces;

namespace SCP1162
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should debug messages be displayed?")]
        public bool Debug { get; set; } = false;

        [Description("Use Hints instead of Broadcast?")]
        public bool UseHints { get; set; } = true;

        [Description("Use Old SCP-173 Spawn in Light Containment?")]
        public bool UseOld173Spawn { get; set; } = true;

        [Description("Change the message that displays when you drop an item through SCP-1162.")]
        public string ItemDropMessage { get; set; } = "<i>You try to drop the item through <color=yellow>SCP-1162</color> to get another...</i>";

        [Description(" How long a message will be shown for.")]
        public ushort ItemDropMessageDuration { get; set; } = 5;

        [Description("The list of item which can drop.")]
        public List<ItemType> ItemDrops { get; set; } = Enum.GetValues(typeof(ItemType)).Cast<ItemType>().ToList();

    }
}