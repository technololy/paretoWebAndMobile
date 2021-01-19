using System;
using Xamarin.Forms;

namespace Pareto.MyControls
{
    public class ButtonTrigger : TriggerAction<Button>
    {
        public ButtonTrigger()
        {
        }

        protected async override void Invoke(Button sender)
        {
            await sender.ScaleTo(0.95, 50, Easing.CubicOut);
            await sender.ScaleTo(1, 50, Easing.CubicIn);
            //sender.IsEnabled = false;

        }
    }
}
