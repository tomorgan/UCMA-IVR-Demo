using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.AudioVideo;

namespace LyncAsyncExtensionMethods
{
    public static class AudioVideoMcuRoutingMethods
    {
        public static Task UpdateAudioRoutesAsync(this 
            AudioVideoMcuRouting routing, IEnumerable<IncomingAudioRoute> 
            incomingRoutes, IEnumerable<OutgoingAudioRoute> outgoingRoutes)
        {
            return Task.Factory.FromAsync(
                routing.BeginUpdateAudioRoutes,
                routing.EndUpdateAudioRoutes,
                outgoingRoutes, incomingRoutes, null);
        }
    }
}
