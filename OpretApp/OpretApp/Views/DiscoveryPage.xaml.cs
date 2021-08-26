using OpretApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpretApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        DiscoveryButtonView lastElementSelected = new DiscoveryButtonView();
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

        public void OnClicked(object sender, EventArgs e)
        {
            lastElementSelected.BackgroundColor = Color.White;
            var elementSelected = (DiscoveryButtonView)sender;
            elementSelected.BackgroundColor = Color.FromHex("#F9A602");
            lastElementSelected = elementSelected;
        }

    }
}