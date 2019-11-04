////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputSearchManager : AbstractTextedInputManager
    {
        public InputSearchManager()
        {
            SetAttribute("type", InputTypesEnum.search.ToString());
        }
    }
}
