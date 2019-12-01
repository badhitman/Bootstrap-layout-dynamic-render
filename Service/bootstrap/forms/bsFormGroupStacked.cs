////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System.Collections.Generic;
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsFormGroupStacked : absFormGroup
    {
        public List<bmInput> CustomInputs { get; protected set; } = new List<bmInput>();

        public bool IsInline { get; set; } = false;

        public override string GetStringCSS()
        {
            if (IsInline)
                AddCSS("form-row");
            else
                RemoveCSS("form-row");

            return base.GetStringCSS();
        }
    }
}
