using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.Presence;

namespace LyncAsyncExtensionMethods
{
    public static class LocalOwnerPresenceMethods
    {
        public static Task AcknowledgeSubscriberAsync(this 
            LocalOwnerPresence lop, string subscriberId)
        {
            return Task.Factory.FromAsync(
                lop.BeginAcknowledgeSubscriber, 
                lop.EndAcknowledgeSubscriber,
                subscriberId, null);
        }

        public static Task DeletePresenceAsync(this 
            LocalOwnerPresence lop, 
            ICollection<PresenceCategory> categoryItems)
        {
            return Task.Factory.FromAsync(
                lop.BeginDeletePresence,
                lop.EndDeletePresence,
                categoryItems, null);
        }

        public static Task DeletePresenceAsync(this 
            LocalOwnerPresence lop,
            ICollection<PresenceCategoryWithMetaData> categories)
        {
            return Task.Factory.FromAsync(
                lop.BeginDeletePresence,
                lop.EndDeletePresence,
                categories, null);
        }

        public static Task PublishPresenceAsync(this 
            LocalOwnerPresence lop,
            ICollection<PresenceCategory> categoryItems)
        {
            return Task.Factory.FromAsync(
                lop.BeginPublishPresence,
                lop.EndPublishPresence,
                categoryItems, null);
        }

        public static Task PublishPresenceAsync(this 
            LocalOwnerPresence lop,
            ICollection<PresenceCategoryWithMetaData> categories)
        {
            return Task.Factory.FromAsync(
                lop.BeginPublishPresence,
                lop.EndPublishPresence,
                categories, null);
        }

        public static Task UpdateContainerMembershipAsync(this 
            LocalOwnerPresence lop,
            ICollection<ContainerUpdateOperation> operations)
        {
            return Task.Factory.FromAsync(
                lop.BeginUpdateContainerMembership,
                lop.EndUpdateContainerMembership,
                operations, null);
        }
    }
}
