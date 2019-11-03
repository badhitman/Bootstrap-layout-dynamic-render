using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class FormGroupRowManager : FormGroupManager
    {
        public FormGroupRowManager()
        {
            AddCSS("row align-items-center", true);
        }
    }
}
