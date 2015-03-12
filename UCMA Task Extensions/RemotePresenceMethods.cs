using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.Presence;

namespace LyncAsyncExtensionMethods
{
    public static class RemotePresenceMethods
    {
        public static Task AddTargetsAsync(this 
            RemotePresence presence, 
            ICollection<RemotePresentitySubscriptionTarget> targets)
        {
            return Task.Factory.FromAsync(
                presence.BeginAddTargets, presence.EndAddTargets, targets,
                null);
        }

        public static Task<IEnumerable<RemotePresentityNotificationData>> PresenceQueryAsync(
            this RemotePresence presence, IEnumerable<string> targets, string[] categories,
            EventHandler<RemotePresenceNotificationEventArgs> queryResultHandler)
        {
            return Task<IEnumerable<RemotePresentityNotificationData>>.Factory.FromAsync(
                presence.BeginPresenceQuery,
                presence.EndPresenceQuery,
                targets, categories, queryResultHandler, null);
        }

        public static Task RefreshAsync(this 
            RemotePresence presence)
        {
            return Task.Factory.FromAsync(
                presence.BeginRefresh, presence.EndRefresh,
                null);
        }

        public static Task RemoveAllTargetsAsync(this 
            RemotePresence presence)
        {
            return Task.Factory.FromAsync(
                presence.BeginRemoveAllTargets, presence.EndRemoveAllTargets,
                null);
        }

        public static Task RemoveTargetAsync(this 
            RemotePresence presence, string uri)
        {
            return Task.Factory.FromAsync(
                presence.BeginRemoveTarget, 
                presence.EndRemoveTarget, uri, null);
        }
    }
}
