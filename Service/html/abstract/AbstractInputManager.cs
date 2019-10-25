////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractInputManager : AbstractDomManager
    {
        public InputTypesEnum InputType { get; set; }

        protected AbstractInputManager(InputTypesEnum SetInputType)
        {
            InputType = SetInputType;
        }
    }
}
