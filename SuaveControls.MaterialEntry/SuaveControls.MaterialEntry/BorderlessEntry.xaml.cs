using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuaveControls.MaterialEntry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BorderlessEntry : Entry
    {
        public BorderlessEntry()
        {
            InitializeComponent();
        }
    }
}