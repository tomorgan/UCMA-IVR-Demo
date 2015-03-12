using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class InstantMessagingFlowMethods
    {
        public static Task SendFailureDeliveryNotificationAsync(this 
            InstantMessagingFlow flow, InstantMessageId messageId,
            int responseCode)
        {
            return Task.Factory.FromAsync(flow.BeginSendFailureDeliveryNotification,
                flow.EndSendFailureDeliveryNotification, messageId,
                responseCode, null);
        }

        public static Task<SendInstantMessageResult> SendInstantMessageAsync(this 
            InstantMessagingFlow flow, string textBody)
        {
            return Task<SendInstantMessageResult>.Factory.FromAsync(flow.BeginSendInstantMessage,
                flow.EndSendInstantMessage, textBody, null);
        }

        public static Task<SendInstantMessageResult> SendInstantMessageAsync(this 
            InstantMessagingFlow flow, ContentType contentType, 
            byte[] body)
        {
            return Task<SendInstantMessageResult>.Factory.FromAsync(flow.BeginSendInstantMessage,
                flow.EndSendInstantMessage, contentType, body, null);
        }

        public static Task SendSuccessDeliveryNotificationAsync(this 
            InstantMessagingFlow flow, InstantMessageId messageId)
        {
            return Task.Factory.FromAsync(flow.BeginSendSuccessDeliveryNotification,
                flow.EndSendSuccessDeliveryNotification, messageId,
                null);
        }
    }
}
