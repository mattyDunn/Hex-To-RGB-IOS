using System;

using UIKit;

namespace IOSHEXtoRGB
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            convertButton.TouchUpInside += ConvertButton_TouchUpInside;
        }

        void ConvertButton_TouchUpInside(object sender, EventArgs e)
        {
            //Finds the input in the HEX text Field
            string hexValue = hexTextField.Text;
            //Seperates the Hex Value into Red Blue and Green
            string redHex = hexValue.Substring(0, 2);
            string greenHex = hexValue.Substring(2, 2);
            string blueHex = hexValue.Substring(4, 2);


            //Turns the String value into and int
            //Turns Hex to RGB
            int redValue = int.Parse(redHex, System.Globalization.NumberStyles.HexNumber);
            int greenValue = int.Parse(greenHex, System.Globalization.NumberStyles.HexNumber);
            int blueValue = int.Parse(blueHex, System.Globalization.NumberStyles.HexNumber);

            //Changes Labels to the RGB value
            redLabel.Text = redValue.ToString();
            greenLabel.Text = greenValue.ToString();
            blueLabel.Text = blueValue.ToString();

            //Changes Background Color to that of the RGB
            ColorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }




    }
}
