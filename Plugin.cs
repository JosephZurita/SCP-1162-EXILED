using Exiled.API.Features;
using System;
namespace SCP1162
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "SCP1162";
        public override string Name => "SCP1162";
        public override string Author => "xRoier(retired),JosephZurita";
        public EventHandlers EventHandlers;
        public override Version Version { get; } = new Version(9, 5, 0);
        public override Version RequiredExiledVersion { get; } = new Version(9, 5, 0);

        public override void OnEnabled()
        {
            /* Null Item is not a valid item type to add so remove if in the config */
            Config.ItemDrops.Remove(ItemType.None);
            EventHandlers = new EventHandlers(this);
            Exiled.Events.Handlers.Server.RoundStarted += EventHandlers.OnRoundStart;
            Exiled.Events.Handlers.Player.DroppingItem += EventHandlers.OnItemDropped;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandlers.OnRoundStart;
            Exiled.Events.Handlers.Player.DroppingItem -= EventHandlers.OnItemDropped;
            EventHandlers = null;
            base.OnDisabled();
        }
    }
}