﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace YoutubePlayer
{
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FF1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PauseButton1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PlayButton1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Rewind1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider Slider1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        NativeLibrary.YTPlayerView Video1 { get; set; }

        [Action ("FF1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FF1_TouchUpInside (UIKit.UIButton sender);

        [Action ("PauseButton1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PauseButton1_TouchUpInside (UIKit.UIButton sender);

        [Action ("PlayButton1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PlayButton1_TouchUpInside (UIKit.UIButton sender);

        [Action ("Rewind1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Rewind1_TouchUpInside (UIKit.UIButton sender);

        [Action ("Slider_Slided:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Slider_Slided (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (FF1 != null) {
                FF1.Dispose ();
                FF1 = null;
            }

            if (PauseButton1 != null) {
                PauseButton1.Dispose ();
                PauseButton1 = null;
            }

            if (PlayButton1 != null) {
                PlayButton1.Dispose ();
                PlayButton1 = null;
            }

            if (Rewind1 != null) {
                Rewind1.Dispose ();
                Rewind1 = null;
            }

            if (Slider1 != null) {
                Slider1.Dispose ();
                Slider1 = null;
            }

            if (Video1 != null) {
                Video1.Dispose ();
                Video1 = null;
            }
        }
    }
}