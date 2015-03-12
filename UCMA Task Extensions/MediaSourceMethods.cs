using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.AudioVideo;

namespace LyncAsyncExtensionMethods
{
    public static class MediaSourceMethods
    {
        public static Task PrepareSourceAsync(this 
            MediaSource source, MediaSourceOpenMode mode)
        {
            return Task.Factory.FromAsync(
                source.BeginPrepareSource, 
                source.EndPrepareSource, mode, null);
        }
    }
}
