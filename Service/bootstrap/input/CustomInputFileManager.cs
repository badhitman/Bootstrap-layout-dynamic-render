using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class CustomInputFileManager : CustomInputManager
    {
        public override string StringCSS
        {
            get
            {
                AddCSS("custom-file");
                return base.StringCSS;
            }
        }
    }
}
