using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class InstantMessagingMcuSessionMethods
    {
        public static Task DialOutAsync(this InstantMessagingMcuSession mcuSession,
            string uri)
        {
            return Task.Factory.FromAsync(mcuSession.BeginDialOut,
                mcuSession.EndDialOut, uri, null);
        }
    }
}
