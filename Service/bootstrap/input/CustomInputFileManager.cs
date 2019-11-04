////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class CustomInputFileManager : AbstractCustomInputManager
    {
        public override string GetStringCSS
        {
            get
            {
                AddCSS("custom-file");
                return base.GetStringCSS;
            }
        }
    }
}
