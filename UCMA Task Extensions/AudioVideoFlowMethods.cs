using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.AudioVideo;
using Microsoft.Rtc.Signaling;

namespace LyncAsyncExtensionMethods
{
    public static class AudioVideoFlowMethods
    {
        public static Task ApplyChangesAsync(this AudioVideoFlow flow,
            AudioVideoFlowTemplate template)
        {
            return Task.Factory.FromAsync(
                flow.BeginApplyChanges, flow.EndApplyChanges,
               template, null);
        }

        public static Task ApplyChangesAsync(this AudioVideoFlow flow,
            AudioVideoFlowTemplate template, 
            IEnumerable<SignalingHeader> headers)
        {
            return Task.Factory.FromAsync(
                flow.BeginApplyChanges, flow.EndApplyChanges,
               template, headers, null);
        }

        public static Task HoldAsync(this AudioVideoFlow flow,
            HoldType holdType,
            IEnumerable<SignalingHeader> headers)
        {
            return Task.Factory.FromAsync(
                flow.BeginHold, flow.EndHold,
               holdType, headers, null);
        }

        public static Task HoldAsync(this AudioVideoFlow flow,
            HoldType holdType)
        {
            return Task.Factory.FromAsync(
                flow.BeginHold, flow.EndHold,
               holdType, null);
        }

        public static Task RetrieveAsync(this AudioVideoFlow flow,
            IEnumerable<SignalingHeader> headers)
        {
            return Task.Factory.FromAsync(
                flow.BeginRetrieve, flow.EndRetrieve,
               headers, null);
        }

        public static Task RetrieveAsync(this AudioVideoFlow flow)
        {
            return Task.Factory.FromAsync(
                flow.BeginRetrieve, flow.EndRetrieve,
               null);
        }
    }
}
