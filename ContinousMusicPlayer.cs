using Microsoft.Rtc.Collaboration.AudioVideo;

namespace UCMA_IVR_Demo
{
    public class ContinuousMusicPlayer
    {
        private static ContinuousMusicPlayer instance;
        public Player _player;
        private ContinuousMusicPlayer() {
            CreatePlayer();
        }
        
        public static ContinuousMusicPlayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContinuousMusicPlayer();
                }
                return instance;
            }
        }

        private void CreatePlayer()
        {
            var source = new WmaFileSource("music.wma");
            source.EndPrepareSource(source.BeginPrepareSource(MediaSourceOpenMode.Buffered, null, null));
            _player = new Player();
            _player.SetSource(source);
            
            _player.SetMode(PlayerMode.Manual);
            _player.StateChanged += player_StateChanged;
            _player.Start();
        }

        void player_StateChanged(object sender, PlayerStateChangedEventArgs e)
        {
            if (e.State == PlayerState.Stopped)
            {
                _player.Start();
            }
        }
    }
}
