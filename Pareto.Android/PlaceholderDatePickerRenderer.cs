using System;
using Android.Content;
using Pareto.Droid;
using Pareto.MyControls;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(PlaceholderDatePicker),
    typeof(PlaceholderDatePickerRenderer),
    new[] { typeof(VisualMarker.MaterialVisual) })]
namespace Pareto.Droid
{
    public class PlaceholderDatePickerRenderer : MaterialDatePickerRenderer
    {
        public PlaceholderDatePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null && Element is PlaceholderDatePicker datePicker
                && !string.IsNullOrWhiteSpace(datePicker.Placeholder))
            {
                Control.HintEnabled = true;
                Control.Hint = datePicker.Placeholder;
            }
        }
    }
}
