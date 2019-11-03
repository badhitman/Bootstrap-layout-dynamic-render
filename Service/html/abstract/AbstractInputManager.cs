////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractInputManager : AbstractInputsManager
    {
        public InputTypesEnum InputType { get; set; }

        protected AbstractInputManager(InputTypesEnum SetInputType)
        {
            InputType = SetInputType;
        }

        public override string StringAttributes
        {
            get
            {
                SetAttribute("type", InputType.ToString());
                SetAttribute("aria-label", InputType.ToString().Substring(0, 1).ToUpper() + InputType.ToString().Substring(1) + " input");
                return base.StringAttributes;
            }
        }
    }
}
