using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;
using Microsoft.Rtc.Collaboration.AudioVideo;

namespace LyncAsyncExtensionMethods
{
    public static class AudioVideoMcuSessionMethods
    {
        public static Task AddToDefaultRoutingAsync(this 
            AudioVideoMcuSession mcuSession, ParticipantEndpoint endpoint,
            AddToDefaultRoutingOptions options)
        {
            return Task.Factory.FromAsync(
                mcuSession.BeginAddToDefaultRouting,
                mcuSession.EndAddToDefaultRouting,
                endpoint, options, null);
        }

        public static Task DialOutAsync(this AudioVideoMcuSession mcuSession,
            string uri)
        {
            return Task.Factory.FromAsync(mcuSession.BeginDialOut,
                mcuSession.EndDialOut, uri, null);
        }

        public static Task DialOutAsync(this AudioVideoMcuSession mcuSession,
            string uri, McuDialOutOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginDialOut,
                mcuSession.EndDialOut, uri, options, null);
        }

        public static Task DisableMuteAllModeAsync(this AudioVideoMcuSession mcuSession)
        {
            return Task.Factory.FromAsync(mcuSession.BeginDisableMuteAllMode,
                mcuSession.EndDisableMuteAllMode, null);
        }

        public static Task DisableMuteAllModeAsync(this AudioVideoMcuSession mcuSession,
            DisableMuteAllModeOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginDisableMuteAllMode,
                mcuSession.EndDisableMuteAllMode, options, null);
        }

        public static Task EnableMuteAllModeAsync(this AudioVideoMcuSession mcuSession)
        {
            return Task.Factory.FromAsync(mcuSession.BeginEnableMuteAllMode,
                mcuSession.EndEnableMuteAllMode, null);
        }

        public static Task EnableMuteAllModeAsync(this AudioVideoMcuSession mcuSession,
            EnableMuteAllModeOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginEnableMuteAllMode,
                mcuSession.EndEnableMuteAllMode, options, null);
        }

        public static Task ModifyAttendanceAnnouncementsAsync(this AudioVideoMcuSession mcuSession,
            AttendanceAnnouncementsStatus status)
        {
            return Task.Factory.FromAsync(mcuSession.BeginModifyAttendanceAnnouncements,
                mcuSession.EndModifyAttendanceAnnouncements, status,
                null);
        }

        public static Task MuteAsync(this AudioVideoMcuSession mcuSession,
            ParticipantEndpoint endpoint)
        {
            return Task.Factory.FromAsync(mcuSession.BeginMute,
                mcuSession.EndMute, endpoint,
                null);
        }

        public static Task MuteAsync(this AudioVideoMcuSession mcuSession,
            ParticipantEndpoint endpoint, MuteOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginMute,
                mcuSession.EndMute, endpoint, options,
                null);
        }

        public static Task ModifyAttendanceAnnouncementsAsync(this AudioVideoMcuSession mcuSession,
            AttendanceAnnouncementsStatus status, ModifyAttendanceAnnouncementOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginModifyAttendanceAnnouncements,
                mcuSession.EndModifyAttendanceAnnouncements, status,
                options, null);
        }

        public static Task RemoveFromDefaultRoutingAsync(this 
            AudioVideoMcuSession mcuSession, ParticipantEndpoint endpoint,
            RemoveFromDefaultRoutingOptions options)
        {
            return Task.Factory.FromAsync(
                mcuSession.BeginRemoveFromDefaultRouting,
                mcuSession.EndRemoveFromDefaultRouting,
                endpoint, options, null);
        }

        public static Task TransferAsync(this AudioVideoMcuSession mcuSession,
            AudioVideoCall call, McuTransferOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginTransfer,
                mcuSession.EndTransfer, call, options,
                null);
        }

        public static Task UnmuteAsync(this AudioVideoMcuSession mcuSession,
            ParticipantEndpoint endpoint)
        {
            return Task.Factory.FromAsync(mcuSession.BeginUnmute,
                mcuSession.EndUnmute, endpoint,
                null);
        }

        public static Task UnmuteAsync(this AudioVideoMcuSession mcuSession,
            ParticipantEndpoint endpoint, UnmuteOptions options)
        {
            return Task.Factory.FromAsync(mcuSession.BeginUnmute,
                mcuSession.EndUnmute, endpoint, options,
                null);
        }
    }
}
