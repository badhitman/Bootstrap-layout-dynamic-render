﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html.input;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputSelectManager : AbstractInputManager
    {
        public override string ViewComponentName => nameof(SelectBase);

        public void AddOption(string header, string value)
        {

        }
    }
}