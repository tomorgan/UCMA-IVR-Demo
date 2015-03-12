using LyncAsyncExtensionMethods;
using Microsoft.Rtc.Collaboration.AudioVideo;
using System;
using System.Threading.Tasks;


namespace UCMA_IVR_Demo
{
    class Program
    {
        private static LyncServer _server;

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;  //quick and dirty error handling :)
            _server = new LyncServer();
            _server.LyncServerReady += server_LyncServerReady;
            _server.IncomingCall += server_IncomingCall;
            Task t = _server.Start();
            

            Console.ReadLine();
            var stopping = _server.Stop();
            stopping.Wait();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        private static void server_LyncServerReady(object sender, EventArgs e)
        {
            Console.WriteLine("Lync Server Ready");
        }
        

        static void server_IncomingCall(object sender, Microsoft.Rtc.Collaboration.CallReceivedEventArgs<Microsoft.Rtc.Collaboration.AudioVideo.AudioVideoCall> e)
        {
            e.Call.AudioVideoFlowConfigurationRequested += Call_AudioVideoFlowConfigurationRequested;
            e.Call.AcceptAsync();
        }

        static void Call_AudioVideoFlowConfigurationRequested(object sender, AudioVideoFlowConfigurationRequestedEventArgs e)
        {
            e.Flow.StateChanged +=Flow_StateChanged;
        }

        static void Flow_StateChanged(object sender, Microsoft.Rtc.Collaboration.MediaFlowStateChangedEventArgs e)
        {
            if (e.State == Microsoft.Rtc.Collaboration.MediaFlowState.Active)
            {
               
                var flow = sender as AudioVideoFlow;
                var ivr = new IVRMenu();
                ivr.StartWithWelcome(flow, _server);
            }
        }

    
    }
}
