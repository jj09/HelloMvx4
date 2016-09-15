// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HelloMvx4.iOS
{
    [Register ("SecondView")]
    partial class SecondView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FirstNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LastNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FirstNameLabel != null) {
                FirstNameLabel.Dispose ();
                FirstNameLabel = null;
            }

            if (LastNameLabel != null) {
                LastNameLabel.Dispose ();
                LastNameLabel = null;
            }
        }
    }
}