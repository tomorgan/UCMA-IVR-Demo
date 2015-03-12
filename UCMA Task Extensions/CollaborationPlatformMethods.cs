using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration;

namespace LyncAsyncExtensionMethods
{
    public static class CollaborationPlatformMethods
    {
        public static Task ChangeCertificateAsync(this CollaborationPlatform platform, 
            string certificateIssuerName, byte[] certificateSerialNumber)
        {
            return Task.Factory.FromAsync(platform.BeginChangeCertificate,
                platform.EndChangeCertificate, certificateIssuerName, 
                certificateSerialNumber, null);
        }

        public static Task ChangeCertificateAsync(this CollaborationPlatform platform,
            X509Certificate certificate)
        {
            return Task.Factory.FromAsync(platform.BeginChangeCertificate,
                platform.EndChangeCertificate, certificate, null);
        }

        public static Task StartupAsync(this CollaborationPlatform platform)
        {
            return Task.Factory.FromAsync(platform.BeginStartup,
                platform.EndStartup, null);
        }

        public static Task ShutdownAsync
            (this CollaborationPlatform platform)
        {
            return Task.Factory.FromAsync(platform.BeginShutdown,
                platform.EndShutdown, null);
        }
    }
}
