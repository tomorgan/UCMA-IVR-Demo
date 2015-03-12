using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.AudioVideo;

namespace LyncAsyncExtensionMethods
{
    public static class SpeechSynthesisConnectorMethods
    {
        public static Task<int> ReadAsync(this SpeechSynthesisConnector connector,
            byte[] buffer, int offset, int count)
        {
            return Task<int>.Factory.FromAsync(connector.BeginRead,
                connector.EndRead, buffer, offset, count, null);
        }

        public static Task WriteAsync(this SpeechSynthesisConnector connector,
            byte[] buffer, int offset, int count)
        {
            return Task.Factory.FromAsync(connector.BeginWrite,
                connector.EndWrite, buffer, offset, count, null);
        }
    }
}
