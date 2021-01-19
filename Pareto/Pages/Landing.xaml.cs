using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pareto.Pages
{
    public partial class Landing : ContentPage
    {
        public Landing()
        {
            InitializeComponent();
        }

        async void Signup_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Pages.BookLoan());

        }
    }
}
