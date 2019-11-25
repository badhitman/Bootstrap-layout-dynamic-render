////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public abstract class absFormGroup : ahsNestedTools
    {
        public override string ViewComponentName => nameof(brFormGroup);

        public override string GetStringCSS()
        {
            if (!ContainsClassCSS(delegate (string s) { return s == "form-row"; }))
                AddCSS("form-group");

            return base.GetStringCSS();
        }
    }
}
