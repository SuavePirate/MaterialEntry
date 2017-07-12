using SuaveControls.MaterialEntry.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SuaveControls.MaterialEntry;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]

namespace SuaveControls.MaterialEntry.iOS
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        public static void Init() { }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
