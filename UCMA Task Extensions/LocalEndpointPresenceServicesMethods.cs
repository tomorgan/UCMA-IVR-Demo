using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;
using Microsoft.Rtc.Collaboration.Presence;

namespace LyncAsyncExtensionMethods
{
    public static class LocalEndpointPresenceServicesMethods
    {
        public static Task<IEnumerable<RemotePresentityNotification>> PresenceQueryAsync(
            this LocalEndpointPresenceServices presenceServices, IEnumerable<string> targets, string[] categories,
            EventHandler<RemotePresentitiesNotificationEventArgs> queryResultHandler)
        {
            return Task<IEnumerable<RemotePresentityNotification>>.Factory.FromAsync(
                presenceServices.BeginPresenceQuery,
                presenceServices.EndPresenceQuery,
                targets, categories,
                queryResultHandler, null);
        }

        public static Task RefreshRemotePresenceViews(this 
            LocalEndpointPresenceServices presenceServices)
        {
            return Task.Factory.FromAsync(presenceServices.BeginRefreshRemotePresenceViews,
                presenceServices.EndRefreshRemotePresenceViews, null);
        }
    }
}
