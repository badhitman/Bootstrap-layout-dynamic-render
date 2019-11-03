using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class InputGroupPrependManager : DivBaseManager
    {
        public override string StringCSS
        {
            get
            {
                AddCSS("input-group-prepend");
                return base.StringCSS;
            }
        }
    }
}
