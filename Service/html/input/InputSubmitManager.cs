////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputSubmitManager : AbstractInputManager
    {
        public InputSubmitManager()
        {
            SetAttribute("type", InputTypesEnum.submit.ToString());
        }
    }
}
