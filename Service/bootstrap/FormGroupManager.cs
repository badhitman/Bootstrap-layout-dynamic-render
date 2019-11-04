using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class FormGroupManager : AbstractCustomInputManager
    {
        public override string GetStringCSS
        {
            get
            {
                AddCSS("form-group");

                return base.GetStringCSS;
            }
        }
    }
}
