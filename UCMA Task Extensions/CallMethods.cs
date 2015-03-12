using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;
using Microsoft.Rtc.Signaling;

namespace LyncAsyncExtensionMethods
{
    public static class CallMethods
    {
        public static Task<CallMessageData> AcceptAsync(this Call call)
        {
            return Task<CallMessageData>.Factory.FromAsync(call.BeginAccept,
                call.EndAccept, null);
        }

        public static Task<CallMessageData> AcceptAsync(this Call call,
            CallAcceptOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(call.BeginAccept,
                call.EndAccept, options, null);
        }

        public static Task<CallMessageData> EstablishAsync(this Call call)
        {
            return Task<CallMessageData>.Factory.FromAsync(
                call.BeginEstablish, call.EndEstablish,
                null);
        }

        public static Task<CallMessageData> EstablishAsync(this Call call,
            CallEstablishOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(
                call.BeginEstablish, call.EndEstablish,
                options, null);
        }

        public static Task<CallMessageData> EstablishAsync(this Call call,
            string destinationUri, CallEstablishOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(
                call.BeginEstablish, call.EndEstablish,
                destinationUri, options, null);
        }

        public static Task TerminateAsync(this Call call)
        {
            return Task.Factory.FromAsync(call.BeginTerminate,
                call.EndTerminate, null);
        }

        public static Task TerminateAsync(this Call call, 
            CallTerminateOptions options)
        {
            return Task.Factory.FromAsync(call.BeginTerminate,
                call.EndTerminate, options, null);
        }

        public static Task TerminateAsync(this Call call,
            IEnumerable<SignalingHeader> headers)
        {
            return Task.Factory.FromAsync(call.BeginTerminate,
                call.EndTerminate, headers, null);
        }
    }
}
