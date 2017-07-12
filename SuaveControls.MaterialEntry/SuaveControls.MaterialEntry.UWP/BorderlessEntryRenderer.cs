using SuaveControls.MaterialEntry.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using SuaveControls.MaterialEntry;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace SuaveControls.MaterialEntry.UWP
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        public static void Init() { }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.Margin = new Windows.UI.Xaml.Thickness(0);
                Control.Padding = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}
