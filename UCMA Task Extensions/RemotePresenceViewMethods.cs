using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.Presence;

namespace LyncAsyncExtensionMethods
{
    public static class RemotePresenceViewMethods
    {
        public static Task TerminateAsync(this 
            RemotePresenceView view)
        {
            return Task.Factory.FromAsync(
                view.BeginTerminate,
                view.EndTerminate,
                null);
        }
    }
}
