using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;
using Microsoft.Rtc.Collaboration.Presence;
using Microsoft.Rtc.Signaling;

namespace LyncAsyncExtensionMethods
{
    public static class LocalEndpointMethods
    {
        public static Task<SipResponseData> EstablishAsync(this 
            LocalEndpoint endpoint)
        {
            return Task<SipResponseData>.Factory.FromAsync(
                endpoint.BeginEstablish,
                endpoint.EndEstablish, null);
        }

        public static Task<SipResponseData> EstablishAsync(this 
            LocalEndpoint endpoint, 
            IEnumerable<SignalingHeader> additionalHeaders)
        {
            return Task<SipResponseData>.Factory.FromAsync(
                endpoint.BeginEstablish,
                endpoint.EndEstablish, additionalHeaders, null);
        }

        public static Task<ProvisioningData> GetProvisioningDataAsync(this 
            LocalEndpoint endpoint)
        {
            return Task<ProvisioningData>.Factory.FromAsync(
                endpoint.BeginGetProvisioningData, 
                endpoint.EndGetProvisioningData,
                null);
        }

        public static Task TerminateAsync(this LocalEndpoint endpoint)
        {
            return Task.Factory.FromAsync(endpoint.BeginTerminate,
                endpoint.EndTerminate, null);
        }
    }
}
