////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputUrlManager : AbstractTextedInputManager
    {
        public InputUrlManager()
        {
            SetAttribute("type", InputTypesEnum.url.ToString());
        }
    }
}
