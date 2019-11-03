////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputFileManager : AbstractInputDataValuableManager
    {
        public InputFileManager()
        {
            SetAttribute("type", InputTypesEnum.file.ToString());
        }
    }
}
