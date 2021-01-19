using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace Pareto.Pages
{
    public partial class BookLoan : ContentPage
    {

        public Pareto.Models.LoanSubmitModel SubmitModel { get; set; }
        public BookLoan()
        {
            InitializeComponent();
            SubmitModel = new Models.LoanSubmitModel();
            BindingContext = this;
        }

        async void Submit_Tapped(object sender, System.EventArgs e)
        {
            var originalText = Submit.Text;
            try
            {
                if (!ValidateForm())
                {
                    Submit.Text = originalText;
                    Submit.IsEnabled = true;
                    return;
                }

                Submit.Text = "Please wait.....";
                SubmitModel.dateOfBirth = SubmitModel.dateOfBirthOrig.ToString("yyyy-MM-dd");
                SterlingMobile.Services.APIService api = new SterlingMobile.Services.APIService();

                var result = await api.Post<Pareto.Models.LoanSubmitResponse>(SubmitModel, Services.Settings.AppSettings.ParetoBaseURL, null);
                if (result.isSuccess)
                {
                    await DisplayAlert("Success!!!", result.model?.message ?? "Loan Booked successfully. You will be contacted for further actions", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Sorry!!!", result.model?.message ?? "Loan was not booked successfully.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Sorry!!!", "An unusual error occured", "OK");
                Debug.WriteLine(ex);
            }
            finally
            {
                Submit.Text = originalText;
                Submit.IsEnabled = true;
            }

        }

        private bool ValidateForm()
        {
            var check = stackReg.Children.OfType<Entry>().ToList();
            foreach (var item in check)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    DisplayAlert("Required!!", $"{item.Placeholder} is needed to continue", "OK");
                    return false;
                }
            }
            return true;
        }
    }
}
