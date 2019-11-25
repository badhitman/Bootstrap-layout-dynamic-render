////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsFormGroupSingle : absFormGroup
    {
        public bmCustomInput CustomInput { get; protected set; } = new bmCustomInput();

        public bool IsHorisontal { get; set; } = false;

        public override string GetStringCSS()
        {
            if (CustomInput.Input.GetType().IsSubclassOf(typeof(ahsCheckedInputs)) && !IsHorisontal)
                AddCSS("form-check");
            else
                RemoveCSS("form-check");

            if (IsHorisontal)
                AddCSS("row");
            else
                RemoveCSS("row");

            return (base.GetStringCSS() + CustomInput.AddedClassesCSS?.Trim()).Trim();
        }
    }
}
