using System.ComponentModel;
using Xamarin.Forms;
using Pareto.ViewModels;

namespace Pareto.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}