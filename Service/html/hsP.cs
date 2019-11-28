////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsP : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrP);

        public string Text { get; set; }

        public hsP(string SetText)
        {
            Text = SetText;
        }
    }
}
