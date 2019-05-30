// WARNING
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
    [Register ("SecondViewController")]
    partial class SecondViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SearchButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SearchResults { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Text1 { get; set; }

        [Action ("SearchButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SearchButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (SearchButton != null) {
                SearchButton.Dispose ();
                SearchButton = null;
            }

            if (SearchResults != null) {
                SearchResults.Dispose ();
                SearchResults = null;
            }

            if (Text1 != null) {
                Text1.Dispose ();
                Text1 = null;
            }
        }
    }
}