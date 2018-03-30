using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WMPLib;

namespace MediaEnglish
{
    public delegate void StatusChangeHandler();

    public delegate void OpenStatusChangeHandler(WMPOpenState status);

    public delegate void PlayStatusChangeHandler(WMPPlayState status);

    public class MyMedia
    {
        private WindowsMediaPlayer Player { get; set; }

        public event OpenStatusChangeHandler OpenStatusChange;
        public event PlayStatusChangeHandler PlayStatusChange;


        public WMPPlayState PlayState
        {
            get { return Player.playState; }
        }

        public MyMedia()
        {
            Player = new WindowsMediaPlayer();
            MediaConfig();
        }


        public double During
        {
            get { return Player.currentMedia.duration; }
        }

        public int PositionPercent
        {
            get { return (int) (Player.controls.currentPosition / (float) Player.currentMedia.duration * 100); }
        }

        public double CurrentPosition
        {
            get { return Player.controls.currentPosition; }
            set { Player.controls.currentPosition = value; }
        }

        public void PlayFile(string url)
        {
            Player.URL = url;
            Play();
        }

        public string FileName
        {
            get { return Player.URL; }
            set { Player.URL = value; }
        }

        public void Stop()
        {
            Player.controls.stop();
        }

        public void Play()
        {
            Player.controls.play();
        }

        public void Pause()
        {
            Player.controls.pause();
        }

        public void MediaConfig()
        {
            Player.settings.autoStart = true;
            //Player.settings.setMode("loop",true);

            Player.PlayStateChange += Player_PlayStateChange;
            Player.OpenStateChange += Player_OpenStateChange;
        }

        private void Player_PlayStateChange(int NewState)
        {
            PlayStatusChange((WMPPlayState) NewState);
        }

        private void Player_OpenStateChange(int NewState)
        {
            OpenStatusChange((WMPOpenState) NewState);
        }

        public void ResetBind()
        {
        }


        public IWMPMedia CurrentMedia
        {
            get { return Player.currentMedia; }
            set { Player.currentMedia = value; }
        }

        public IWMPMedia NewMedia(string url)
        {
            return Player.newMedia(url);
        }


        public void Next()
        {
            Player.controls.next();
        }

        public void Previous()
        {
            Player.controls.previous();
        }

        public double Seek
        {
            get { return Player.controls.currentPosition; }
            set { Player.controls.currentPosition = value; }
        }

        public bool isPlaying
        {
            get { return Player.playState == WMPPlayState.wmppsPlaying; }
        }

        public bool isOpenMedia
        {
            get { return Player.openState == WMPOpenState.wmposMediaOpen; }
        }
    }
}