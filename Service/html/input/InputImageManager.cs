////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputImageManager : AbstractInputDataValuableManager
    {
        public string Src => Value;

        public InputImageManager()
        {
            SetAttribute("type", InputTypesEnum.image.ToString());
        }
    }
}
