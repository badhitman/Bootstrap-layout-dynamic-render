////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputHiddenManager : AbstractInputDataValuableManager
    {
        public InputHiddenManager()
        {
            SetAttribute("type", InputTypesEnum.hidden.ToString());
        }
    }
}
