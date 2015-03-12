using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class McuSessionMethods
    {
        public static Task EjectAsync(this McuSession mcuSession,
            string uri, EjectOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginEject,
                mcuSession.EndEject, uri, options, null);
        }
    }
}
