using System;
using Pareto.iOS;
using Pareto.MyControls;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
[assembly: ExportRenderer(typeof(PlaceholderDatePicker),
    typeof(PlaceholderDatePickerRenderer),
    new[] { typeof(VisualMarker.MaterialVisual) })]
namespace Pareto.iOS
{
    public class PlaceholderDatePickerRenderer : MaterialDatePickerRenderer,
            IMaterialEntryRenderer
    {
        string IMaterialEntryRenderer.Placeholder
        {
            get
            {
                if (Element is PlaceholderDatePicker datePicker
                    && !string.IsNullOrEmpty(datePicker.Placeholder))
                {
                    return datePicker.Placeholder;
                }

                return string.Empty;
            }
        }
    }
}
