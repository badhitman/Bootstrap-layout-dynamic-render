////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public abstract class absFormGroup : ahsNestedTools
    {
        public override string ViewComponentName => nameof(brFormGroup);
        
        public static bool UseCustomisation { get; set; } = false;

        public override string GetStringCSS()
        {
            if (this is bsFormGroupStacked && (this as bsFormGroupStacked).IsInline) // в этом случае в наследнике ("bsFormGroupStacked") будет добавлен "form-row"
            {
                RemoveCSS("form-group");
            }
            else
            {
                AddCSS("form-group");
            }

            return base.GetStringCSS();
        }
    }
}
