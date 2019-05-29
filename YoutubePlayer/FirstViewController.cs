using System;
using Foundation;
using UIKit;
using NativeLibrary;

namespace YoutubePlayer
{
    public partial class FirstViewController : UIViewController
    {
        public FirstViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //NSDictionary dict;
            //dict["playsinline"] = 1;
            var dict = new NSDictionary("playsinline", 1, "controls", 0, "autoplay", 1, "loop", 1);
            bool loaded = Video1.LoadWithVideoId("JNsKvZo6MDs", dict);
            //aladdin is foyufD52aog, gorillas dancing 7B6FkBqkZ1g

            //if (loaded == true)
            //Video1.PlayVideoAt(10);
            //Progress1.


        }

        partial void PauseButton1_TouchUpInside(UIButton sender)
        {
            Video1.PauseVideo();
        }

        partial void PlayButton1_TouchUpInside(UIButton sender)
        {
            Video1.PlayVideo();
            //Video1.pl
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


    }
}