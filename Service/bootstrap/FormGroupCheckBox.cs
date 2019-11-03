using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class FormGroupCheckBox : FormGroupManager
    {
        public bool IsInline { get; set; }

        public FormGroupCheckBox()
        {
            AddCSS("form-check");
            if(IsInline)
                AddCSS("form-check-inline");
        }
    }
}
