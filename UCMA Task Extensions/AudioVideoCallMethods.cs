using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;
using Microsoft.Rtc.Collaboration.AudioVideo;
using Microsoft.Rtc.Signaling;

namespace LyncAsyncExtensionMethods
{
    public static class AudioVideoCallMethods
    {
        public static Task EstablishEarlyMediaAsync(this AudioVideoCall call)
        {
            return Task.Factory.FromAsync(
                call.BeginEstablishEarlyMedia, call.EndEstablishEarlyMedia,
                null);
        }

        public static Task EstablishEarlyMediaAsync(this AudioVideoCall call,
            CallProvisionalResponseOptions options)
        {
            return Task.Factory.FromAsync(
                call.BeginEstablishEarlyMedia, call.EndEstablishEarlyMedia,
               options, null);
        }

        public static Task EstablishEarlyMediaAsync(this AudioVideoCall call,
            int responseCode, CallProvisionalResponseOptions options)
        {
            return Task.Factory.FromAsync(
                call.BeginEstablishEarlyMedia, call.EndEstablishEarlyMedia,
                responseCode, options, null);
        }

        public static Task<CallParkResponseData> ParkAsync(this AudioVideoCall call,
            CallParkOptions options)
        {
            return Task<CallParkResponseData>.Factory.FromAsync(
                call.BeginPark, call.EndPark,
                options, null);
        }

        public static Task<CallMessageData> SendMessageAsync(
            this AudioVideoCall call, MessageType messageType,
            ContentDescription contentDescription,
            CallSendMessageRequestOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(call.BeginSendMessage,
                call.EndSendMessage, messageType, 
                contentDescription, options, null);
        }

        public static Task<CallMessageData> TransferAsync(
            this AudioVideoCall call, Call callToReplace)
        {
            return Task<CallMessageData>.Factory.FromAsync(call.BeginTransfer,
                call.EndTransfer, callToReplace, null);
        }

        public static Task<CallMessageData> TransferAsync(
            this AudioVideoCall call, string targetUri)
        {
            return Task<CallMessageData>.Factory.FromAsync(call.BeginTransfer,
                call.EndTransfer, targetUri, null);
        }

        public static Task<CallMessageData> TransferAsync(
            this AudioVideoCall call, Call callToReplace, CallTransferOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(call.BeginTransfer,
                call.EndTransfer, callToReplace, options, null);
        }

        public static Task<CallMessageData> TransferAsync(
            this AudioVideoCall call, string targetUri, CallTransferOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(call.BeginTransfer,
                call.EndTransfer, targetUri, options, null);
        }
    }
}
