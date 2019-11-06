﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputCheckboxManager : AbstractInputValuableBoolManager
    {
        public InputCheckboxManager()
        {
            SetAttribute("type", InputTypesEnum.checkbox.ToString());
        }
    }
}