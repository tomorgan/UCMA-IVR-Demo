using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class ConferenceInvitationMethods
    {
        public static Task AcceptAsync(this ConferenceInvitation invitation)
        {
            return Task.Factory.FromAsync(
                invitation.BeginAccept, invitation.EndAccept,
                null);
        }

        public static Task AcceptAsync(this ConferenceInvitation invitation,
            ConferenceInvitationAcceptOptions options)
        {
            return Task.Factory.FromAsync(
                invitation.BeginAccept, invitation.EndAccept, options,
                null);
        }

        public static Task<ConferenceInvitationResponse> DeliverAsync(this ConferenceInvitation invitation,
            string destinationUri)
        {
            return Task<ConferenceInvitationResponse>.Factory.FromAsync(
                invitation.BeginDeliver, invitation.EndDeliver,
                destinationUri,
                null);
        }

        public static Task<ConferenceInvitationResponse> DeliverAsync(this ConferenceInvitation invitation,
            string destinationUri, ConferenceInvitationDeliverOptions options)
        {
            return Task<ConferenceInvitationResponse>.Factory.FromAsync(
                invitation.BeginDeliver, invitation.EndDeliver, 
                destinationUri, options,
                null);
        }
    }
}
