// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace IOSHEXtoRGB
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel blueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton convertButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel greenLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField hexTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel redLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (blueLabel != null) {
                blueLabel.Dispose ();
                blueLabel = null;
            }

            if (convertButton != null) {
                convertButton.Dispose ();
                convertButton = null;
            }

            if (greenLabel != null) {
                greenLabel.Dispose ();
                greenLabel = null;
            }

            if (hexTextField != null) {
                hexTextField.Dispose ();
                hexTextField = null;
            }

            if (redLabel != null) {
                redLabel.Dispose ();
                redLabel = null;
            }
        }
    }
}