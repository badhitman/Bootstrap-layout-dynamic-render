using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class InputGroupPrependManager : AbstractInputGroupCuttingManager
    {
        public override string GetStringCSS()
        {
            //get
            //{
                AddCSS("input-group-prepend");
                return base.GetStringCSS();
            //}
        }
    }
}
