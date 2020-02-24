using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIW
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label = new Label
            {
                Text = "https://products.ksb.com/global/"
            };
            

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Device.OpenUri(new Uri(((Label)s).Text));
            };
            label.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeadEntry());
        }
    }
}
