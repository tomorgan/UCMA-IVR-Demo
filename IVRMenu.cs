using Microsoft.Rtc.Collaboration.AudioVideo;
using System;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;

namespace UCMA_IVR_Demo
{
    class IVRMenu
    {
        SpeechSynthesisConnector _speechSynthesisConnector = new SpeechSynthesisConnector();
        SpeechAudioFormatInfo audioformat = new SpeechAudioFormatInfo(16000, AudioBitsPerSample.Sixteen, System.Speech.AudioFormat.AudioChannel.Mono);
        SpeechSynthesizer _speechSynthesizer;
        private AudioVideoFlow _flow;
        private LyncServer _server;

        public void StartWithWelcome(AudioVideoFlow flow, LyncServer server)
        {
            _flow = flow;
            _server = server;
           //attach speech synthasis to audio flow
            _speechSynthesisConnector.AttachFlow(_flow);

            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.SetOutputToAudioStream(_speechSynthesisConnector, audioformat);
            _speechSynthesizer.SelectVoice("Microsoft Hazel Desktop");  //slightly more english

            var toneController = new ToneController(); //this is for the DTMF tones
            toneController.AttachFlow(_flow);
           
            _speechSynthesisConnector.Start();

            _speechSynthesizer.Speak("Welcome to Nor-Dove.");
            SpeakMenuOptions();
            toneController.ToneReceived += toneController_ToneReceived;
        }

        private void SpeakMenuOptions()
        {
            _speechSynthesizer.SpeakAsync("Press 1 to hear the time. Press 2 to join a conference, or press 3 to hear some music.");
        }

        private async void toneController_ToneReceived(object sender, ToneControllerEventArgs e)
        {
            _speechSynthesizer.SpeakAsyncCancelAll();
            ContinuousMusicPlayer.Instance._player.DetachFlow(_flow);
            switch (e.Tone)
            {
                case 1:
                    _speechSynthesizer.Speak(string.Format("It's {0} on {1}", DateTime.Now.ToShortTimeString(), DateTime.Now.ToLongDateString()));
                    SpeakMenuOptions();
                    break;
                case 2:
                    _speechSynthesizer.Speak("Joining conference.");
                    _speechSynthesisConnector.DetachFlow();
                    await _server.AddCallerToConference(_flow.Call);
                    break;
                case 3:
                    ContinuousMusicPlayer.Instance._player.AttachFlow(_flow);
                    break;
            }
        }
    }
}
