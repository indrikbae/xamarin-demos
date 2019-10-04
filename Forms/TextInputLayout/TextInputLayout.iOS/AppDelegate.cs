#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Syncfusion.XForms.iOS.Core;
using Syncfusion.XForms.iOS.TextInputLayout;
using Syncfusion.XForms.iOS.MaskedEdit;
using Syncfusion.SfNumericTextBox.XForms.iOS;
using Syncfusion.XForms.iOS.Buttons;
using Syncfusion.SfAutoComplete.XForms.iOS;
using Syncfusion.XForms.iOS.ComboBox;
using Syncfusion.SfNumericUpDown.XForms.iOS;

namespace SampleBrowser.SfTextInputLayout.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            Syncfusion.ListView.XForms.iOS.SfListViewRenderer.Init();
            SampleBrowser.Core.iOS.CoreSampleBrowser.Init(UIScreen.MainScreen.Bounds, app.StatusBarFrame.Size.Height);
            SfButtonRenderer.Init();
            SfTextInputLayoutRenderer.Init();
            SfMaskedEditRenderer.Init();
            SfNumericTextBoxRenderer.Init();
            SfNumericUpDownRenderer.Init();
            SfAutoCompleteRenderer.Init();
            SfComboBoxRenderer.Init();
            return base.FinishedLaunching(app, options);
        }
    }
}
