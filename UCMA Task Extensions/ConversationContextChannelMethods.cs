using System;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class ConversationContextChannelMethods
    {
        public static Task EstablishAsync(this ConversationContextChannel channel,
            Guid applicationId, ConversationContextChannelEstablishOptions options)
        {
            return Task.Factory.FromAsync(channel.BeginEstablish,
                channel.EndEstablish, applicationId, options, null);
        }

        public static Task SendDataAsync(this ConversationContextChannel channel,
            ContentType contentType, byte[] contentBody)
        {
            return Task.Factory.FromAsync(channel.BeginSendData,
                channel.EndSendData, contentType, contentBody, null);
        }

        public static Task TerminateAsync(this ConversationContextChannel channel)
        {
            return Task.Factory.FromAsync(channel.BeginTerminate,
                channel.EndTerminate, null);
        }
    }
}
