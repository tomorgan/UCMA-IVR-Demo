using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.PinManagement;

namespace LyncAsyncExtensionMethods
{
    public static class ApplicationPinServicesMethods
    {
        public static Task<PinVerificationResult> VerifyPinAsync(this 
            ApplicationPinServices aps, string uriToVerify, string pin,
            VerifyPinOptions options)
        {
            return Task<PinVerificationResult>.Factory.FromAsync(
                aps.BeginVerifyPin, aps.EndVerifyPin, uriToVerify,
                pin, options, null);
        }
    }
}
