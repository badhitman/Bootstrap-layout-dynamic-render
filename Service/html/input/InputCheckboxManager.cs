////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputCheckboxManager : AbstractCheckedInputManager
    {
        public InputCheckboxManager()
        {

        }

        public override string GetStringAttributes()
        {
            if (string.IsNullOrWhiteSpace(CacheAttributes))
            {
                SetAttribute("type", InputTypesEnum.checkbox.ToString());
            }

            return base.GetStringAttributes();
        }
    }
}
