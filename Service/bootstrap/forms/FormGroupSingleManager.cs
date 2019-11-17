using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.forms
{
    public class FormGroupSingleManager : AbstractFormGroupManager
    {
        public CustomInputModel CustomInput { get; protected set; } = new CustomInputModel();

        public bool IsHorisontal { get; set; } = false;

        public override string GetStringCSS()
        {
            if (CustomInput.Input.GetType().IsSubclassOf(typeof(AbstractCheckedInputManager)) && !IsHorisontal)
                AddCSS("form-check");

            if (IsHorisontal)
                AddCSS("row");

            return base.GetStringCSS();
        }
    }
}
