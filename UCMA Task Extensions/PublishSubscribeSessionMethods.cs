using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.Presence;

namespace LyncAsyncExtensionMethods
{
    public static class PublishSubscribeSessionMethods
    {
        public static Task RefreshAsync(this 
            PublishSubscribeSession pss)
        {
            return Task.Factory.FromAsync(
                pss.BeginRefresh, pss.EndRefresh,
                null);
        }

        public static Task SubscribeAsync(this 
            PublishSubscribeSession pss)
        {
            return Task.Factory.FromAsync(
                pss.BeginSubscribe, pss.EndSubscribe,
                null);
        }

        public static Task UnsubscribeAsync(this 
            PublishSubscribeSession pss)
        {
            return Task.Factory.FromAsync(
                pss.BeginUnsubscribe, pss.EndUnsubscribe,
                null);
        }
    }
}
