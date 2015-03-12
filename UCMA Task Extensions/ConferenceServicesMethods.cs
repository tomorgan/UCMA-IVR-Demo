using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;
using Microsoft.Rtc.Collaboration.ConferenceManagement;
using Microsoft.Rtc.Signaling;

namespace LyncAsyncExtensionMethods
{
    public static class ConferenceServicesMethods
    {
        public static Task CancelConferenceAsync(this 
            ConferenceServices cs, string conferenceId)
        {
            return Task.Factory.FromAsync(
                cs.BeginCancelConference,
                cs.EndCancelConference, conferenceId, null);
        }

        public static Task CancelConferenceAsync(this 
            ConferenceServices cs, string conferenceId, 
            SchedulingTemplate schedulingTemplate)
        {
            return Task.Factory.FromAsync(
                cs.BeginCancelConference,
                cs.EndCancelConference, conferenceId, schedulingTemplate,
                null);
        }

        public static Task<bool> CheckPasscodeIsOptional(this 
            ConferenceServices cs, RealTimeAddress conferenceAddress)
        {
            return Task<bool>.Factory.FromAsync(
                cs.BeginCheckPasscodeIsOptional,
                cs.EndCheckPasscodeIsOptional, conferenceAddress, null);
        }

        public static Task<Conference> GetConferenceAsync(this 
            ConferenceServices cs, string conferenceId)
        {
            return Task<Conference>.Factory.FromAsync(
                cs.BeginGetConference,
                cs.EndGetConference, conferenceId, null);
        }

        public static Task<Collection<ConferenceSummary>> GetConferenceSummariesAsync(this 
            ConferenceServices cs)
        {
            return Task<Collection<ConferenceSummary>>.Factory.FromAsync(
                cs.BeginGetConferenceSummaries,
                cs.EndGetConferenceSummaries, null);
        }

        public static Task<Collection<ConferenceSummary>> GetConferenceSummariesAsync(this 
            ConferenceServices cs, SchedulingTemplate schedulingTemplate)
        {
            return Task<Collection<ConferenceSummary>>.Factory.FromAsync(
                cs.BeginGetConferenceSummaries,
                cs.EndGetConferenceSummaries, schedulingTemplate, null);
        }

        public static Task<string> GetConferenceUriByPhoneConferenceId(this 
            ConferenceServices cs, string phoneConferenceId)
        {
            return Task<string>.Factory.FromAsync(
                cs.BeginGetConferenceUriByPhoneConferenceId,
                cs.EndGetConferenceUriByPhoneConferenceId, 
                phoneConferenceId, null);
        }

        public static Task<ConferencingCapabilities> GetConferencingCapabilities(this 
            ConferenceServices cs)
        {
            return Task<ConferencingCapabilities>.Factory.FromAsync(
                cs.BeginGetConferencingCapabilities,
                cs.EndGetConferencingCapabilities,
                null);
        }

        public static Task<Conference> ScheduleConferenceAsync(this 
            ConferenceServices cs, ConferenceScheduleInformation information)
        {
            return Task<Conference>.Factory.FromAsync(
                cs.BeginScheduleConference,
                cs.EndScheduleConference, information, null);
        }

        public static Task<Conference> UpdateConferenceAsync(this 
            ConferenceServices cs, ConferenceScheduleInformation information)
        {
            return Task<Conference>.Factory.FromAsync(
                cs.BeginUpdateConference,
                cs.EndUpdateConference, information, null);
        }

        public static Task<bool> VerifyPasscodeAsync(this 
            ConferenceServices cs, RealTimeAddress conferenceAddress,
            string passcode)
        {
            return Task<bool>.Factory.FromAsync(
                cs.BeginVerifyPasscode,
                cs.EndVerifyPasscode, conferenceAddress, passcode, null);
        }
    }
}
