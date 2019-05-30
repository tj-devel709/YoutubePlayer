using System;
using Foundation;
using UIKit;
using NativeLibrary;

namespace YoutubePlayer
{
    public partial class FirstViewController : UIViewController
    {
        public bool Rewinding { get; set; }

        public FirstViewController(IntPtr handle) : base(handle)
        {
        }
        

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           
            var dict = new NSDictionary("playsinline", 1, "controls", 0, "autoplay", 1, "loop", 1);
            bool loaded = Video1.LoadWithVideoId("JNsKvZo6MDs", dict);
            Video1.Delegate = new MyYTPlayerViewDelegate(Slider1);
         

            NSTimer timer = NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromSeconds(1), delegate { Rewind(); });

            //aladdin is foyufD52aog, gorillas dancing 7B6FkBqkZ1g
        }


        public class MyYTPlayerViewDelegate : YTPlayerViewDelegate
        {
            [Weak] UISlider Slide;
            public MyYTPlayerViewDelegate(UISlider slider)
            {
                Slide = slider;
            }

            override public void PlayerViewDidPlayTime(YTPlayerView playerView, float playTime)
            {
                Slide.SetValue(playTime / ((float)playerView.Duration()), true);
            }

        }


        partial void PauseButton1_TouchUpInside(UIButton sender)
        {
            Rewinding = false;
            Video1.PauseVideo();
            Video1.SetPlaybackRate(1);
        }

        partial void Slider_Slided(UISlider sender)
        {
            Rewinding = false;
            Video1.SetPlaybackRate(1);

            bool ShouldBePaused = false;

            if (Video1.PlayerState() != YTPlayerState.Playing)
                ShouldBePaused = true;
                   
            Video1.SeekToSeconds( ((float)sender.Value) * (float)Video1.Duration(), true);

            if (ShouldBePaused)
                Video1.PauseVideo();
            else
                Video1.PlayVideo();
        }

        partial void PlayButton1_TouchUpInside(UIButton sender)
        {
            Rewinding = false;
            Video1.SetPlaybackRate(1);
            Video1.PlayVideo();
        }
       
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }


        partial void Rewind1_TouchUpInside(UIButton sender)
        {
            Rewinding = true;
            Rewind();
        }

        public void Rewind()
        {
            if (Rewinding)
            {
                //Video1.SetPlaybackRate(-5);
                Video1.SetPlaybackRate(1);
                float curTime = Slider1.Value * (float)Video1.Duration();
                float timeIncrements = 4; //(float)Video1.Duration() / 20;

                if (curTime < 4){
                    Video1.SeekToSeconds(0, true);
                    Rewinding = false;
                    return;
                }

                Video1.SeekToSeconds(curTime - timeIncrements, true);
                Video1.PauseVideo();

            }
           
        }


        partial void FF1_TouchUpInside(UIButton sender)
        {
            Rewinding = false;
            Video1.SetPlaybackRate(2);
        }
    }
}