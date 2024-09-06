using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using UnityEngine;
using PlayerRoles;
using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled.API.Extensions;

namespace SCP1162
{
    public class EventHandlers
    {
        private Plugin plugin;

        private Vector3 scp1162Pos;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnItemDropped(DroppingItemEventArgs ev)
        {

            if (!ev.IsAllowed || Vector3.Distance(ev.Player.Position, scp1162Pos) >= 8.2f) return;

            if (plugin.Config.UseHints)
                ev.Player.ShowHint(plugin.Config.ItemDropMessage, plugin.Config.ItemDropMessageDuration);
            else
                ev.Player.Broadcast(plugin.Config.ItemDropMessageDuration, plugin.Config.ItemDropMessage, Broadcast.BroadcastFlags.Normal, true);

            ev.Player.RemoveItem(ev.Item);

            Item newItem = Item.Create(plugin.Config.ItemDrops[Random.Range(0, plugin.Config.ItemDrops.Count)]);

            ev.Player.AddItem(newItem);
            ev.Player.DropItem(newItem);
        }

        public void OnRoundStart()
        {
            scp1162Pos = plugin.Config.UseOld173Spawn ? Room.Get(RoomType.Lcz173).transform.TransformPoint(17f, 12.5f, 8.2f) : RoleTypeId.Scp173.GetRandomSpawnLocation().Position;
        }
    }
}