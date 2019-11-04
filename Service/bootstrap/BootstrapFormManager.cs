////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class BootstrapFormManager : FormManager
    {
        public bool IsInlineForm { get; set; } = false;

        public bool IsWasValidated { get; set; } = false;

        public override string GetStringCSS
        {
            get
            {
                if (IsInlineForm)
                    AddCSS("form-inline");

                if (IsWasValidated)
                    AddCSS("was-validated");

                return base.GetStringCSS;
            }
        }
    }
}
