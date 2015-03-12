using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class LobbyManagerMethods
    {
        public static Task<LobbyOperationResponse> AdmitLobbyParticipantsAsync(this LobbyManager mgr,
            IEnumerable<ConversationParticipant> lobbyParticipants, LobbyAdmitOptions options)
        {
            return Task<LobbyOperationResponse>.Factory.FromAsync(mgr.BeginAdmitLobbyParticipants,
                mgr.EndAdmitLobbyParticipants, lobbyParticipants, options,
                null);
        }

        public static Task<LobbyOperationResponse> DenyLobbyParticipantsAsync(this LobbyManager mgr,
            IEnumerable<ConversationParticipant> lobbyParticipants, LobbyDenyOptions options)
        {
            return Task<LobbyOperationResponse>.Factory.FromAsync(mgr.BeginDenyLobbyParticipants,
                mgr.EndDenyLobbyParticipants, lobbyParticipants, options,
                null);
        }
    }
}
