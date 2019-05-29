using System;

using UIKit;

namespace YoutubePlayer
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

         

           

    }

    partial void SearchButton_TouchUpInside(UIButton sender)
    {
        Text1.ResignFirstResponder();
        string VidId = Text1.Text;
        bool Loaded = Video2.LoadWithVideoId(VidId);
        if(Loaded == false)
            {
                Text1.Text = "Invalid Video ID";
            }

    }




        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

