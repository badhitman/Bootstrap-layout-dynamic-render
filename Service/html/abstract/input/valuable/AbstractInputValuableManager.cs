////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public abstract class AbstractInputValuableManager : AbstractInputManager
    {
        public InputTypesEnum InputType { get; set; }

        

        public AbstractInputValuableManager(InputTypesEnum SetInputType)
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
