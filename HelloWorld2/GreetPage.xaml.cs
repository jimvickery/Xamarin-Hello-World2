using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld2
{
    public partial class GreetPage : ContentPage
    {
       

        public GreetPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Testing While Watching TV", "OK");
        }

    }
}
