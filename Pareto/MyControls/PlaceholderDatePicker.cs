using System;
using Xamarin.Forms;

namespace Pareto.MyControls
{
    public class PlaceholderDatePicker : DatePicker
    {
        public static readonly BindableProperty PlaceholderProperty
            = BindableProperty.Create(nameof(Placeholder), typeof(string),
                typeof(PlaceholderDatePicker), default(string));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }
    }
}
