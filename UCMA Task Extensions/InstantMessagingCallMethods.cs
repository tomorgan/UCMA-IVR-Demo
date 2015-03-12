using Microsoft.Rtc.Collaboration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyncAsyncExtensionMethods
{
    public static class InstantMessagingCallMethods
    {
        public static Task<CallMessageData> EstablishAsync(this InstantMessagingCall call,
            ToastMessage toastMessage, CallEstablishOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(
                call.BeginEstablish, call.EndEstablish,
                toastMessage, options, null);
        }

        public static Task<CallMessageData> EstablishAsync(this InstantMessagingCall call,
            string destinationUri, ToastMessage toastMessage, CallEstablishOptions options)
        {
            return Task<CallMessageData>.Factory.FromAsync(
                call.BeginEstablish, call.EndEstablish,
                destinationUri, toastMessage, options, null);
        }
    }
}
