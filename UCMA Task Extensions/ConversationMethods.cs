using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class ConversationMethods
    {
        public static Task EscalateToConferenceAsync(this 
            Conversation conversation)
        {
            return Task.Factory.FromAsync(
                conversation.BeginEscalateToConference, 
                conversation.EndEscalateToConference,
                null);
        }

        public static Task TerminateAsync(this 
            Conversation conversation)
        {
            return Task.Factory.FromAsync(
                conversation.BeginTerminate,
                conversation.EndTerminate,
                null);
        }

        public static Task UpdatePropertiesAsync(this 
            Conversation conversation, ConversationProperties properties)
        {
            return Task.Factory.FromAsync(
                conversation.BeginUpdateProperties,
                conversation.EndUpdateProperties, properties,
                null);
        }
    }
}
