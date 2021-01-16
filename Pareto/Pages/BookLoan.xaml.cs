using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pareto.Pages
{
    public partial class BookLoan : ContentPage
    {
        public BookLoan()
        {
            InitializeComponent();
        }

        async void Submit_Tapped(object sender, System.EventArgs e)
        {
            await DisplayAlert("Success!", "Loan Booked successfully. You will be contacted for further actions", "OK");
            await Navigation.PushAsync(new Landing());
        }
    }
}
