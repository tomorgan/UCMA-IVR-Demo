using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.PinManagement;

namespace LyncAsyncExtensionMethods
{
    public static class UserPinServicesMethods
    {
        public static Task<UpdatePinResult> UpdatePinAsync(this 
            UserPinServices ups, string pin,
            UpdatePinOptions options)
        {
            return Task<UpdatePinResult>.Factory.FromAsync(
                ups.BeginUpdatePin, ups.EndUpdatePin, 
                pin, options, null);
        }
    }
}
