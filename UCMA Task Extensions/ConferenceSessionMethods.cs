using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class ConferenceSessionMethods
    {
        public static Task EjectAsync(this ConferenceSession session, 
            ConversationParticipant participant)
        {
            return Task.Factory.FromAsync(session.BeginEject,
                session.EndEject, participant, null);
        }

        public static Task EjectAsync(this ConferenceSession session,
            ConversationParticipant participant, EjectOptions options)
        {
            return Task.Factory.FromAsync(session.BeginEject,
                session.EndEject, participant, options, null);
        }

        public static Task<ConferenceSessionExtendedProperties> GetExtendedPropertiesAsync(
            this ConferenceSession session)
        {
            return Task<ConferenceSessionExtendedProperties>.Factory.FromAsync(
                session.BeginGetExtendedProperties, 
                session.EndGetExtendedProperties, null);
        }

        public static Task JoinAsync(this ConferenceSession session,
            ConferenceJoinOptions options)
        {
            return Task.Factory.FromAsync(session.BeginJoin,
                session.EndJoin, options, null);
        }

        public static Task JoinAsync(this ConferenceSession session,
            MeetNowOptions options)
        {
            return Task.Factory.FromAsync(session.BeginJoin,
                session.EndJoin, options, null);
        }

        public static Task JoinAsync(this ConferenceSession session,
            string conferenceUri, ConferenceJoinOptions options)
        {
            return Task.Factory.FromAsync(session.BeginJoin,
                session.EndJoin, conferenceUri, options, null);
        }

        public static Task LockConferenceAsync(this ConferenceSession session)
        {
            return Task.Factory.FromAsync(session.BeginLockConference,
                session.EndLockConference, null);
        }

        public static Task LockConferenceAsync(this ConferenceSession session,
            LockConferenceOptions options)
        {
            return Task.Factory.FromAsync(session.BeginLockConference,
                session.EndLockConference, options, null);
        }

        public static Task ModifyConferenceConfigurationAsync(this ConferenceSession session,
            ConferenceAccessLevel accessLevel, LobbyBypass lobbyBypass, 
            AutomaticLeaderAssignment automaticLeaderAssignment)
        {
            return Task.Factory.FromAsync(session.BeginModifyConferenceConfiguration,
                session.EndModifyConferenceConfiguration, accessLevel, lobbyBypass, 
                automaticLeaderAssignment, null);
        }

        //public static Task ModifyConferenceConfigurationAsync(this ConferenceSession session,
        //    ConferenceAccessLevel accessLevel, LobbyBypass lobbyBypass, 
        //    AutomaticLeaderAssignment automaticLeaderAssignment,
        //    ModifyConferenceConfigurationOptions options)
        //{
        //    return Task.Factory.FromAsync(session.BeginModifyConferenceConfiguration,
        //        session.EndModifyConferenceConfiguration, accessLevel, lobbyBypass,
        //        automaticLeaderAssignment, options, null);
        //}

        public static Task ModifyRole(this ConferenceSession session,
            ConversationParticipant participant,
            ConferencingRole role)
        {
            return Task.Factory.FromAsync(session.BeginModifyRole, 
                session.EndModifyRole, participant, role, null);
        }

        public static Task ModifyRole(this ConferenceSession session,
            ConversationParticipant participant,
            ConferencingRole role, ModifyRoleOptions options)
        {
            return Task.Factory.FromAsync(session.BeginModifyRole,
                session.EndModifyRole, participant, role, options, null);
        }

        public static Task TerminateConferenceAsync(this ConferenceSession session)
        {
            return Task.Factory.FromAsync(session.BeginTerminateConference,
                session.EndTerminateConference, null);
        }

        public static Task UnlockConferenceAsync(this ConferenceSession session)
        {
            return Task.Factory.FromAsync(session.BeginUnlockConference,
                session.EndUnlockConference, null);
        }

        public static Task UnlockConferenceAsync(this ConferenceSession session,
            UnlockConferenceOptions options)
        {
            return Task.Factory.FromAsync(session.BeginUnlockConference,
                session.EndUnlockConference, options, null);
        }
    }
}
