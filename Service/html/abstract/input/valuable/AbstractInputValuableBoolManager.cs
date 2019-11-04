////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public abstract class AbstractInputValuableBoolManager : AbstractInputManager
    {
        public bool IsChecked { get; set; }

        public override string StringAttributes
        {
            get
            {
                if (IsChecked)
                    SetAttribute("checked", "checked");

                return base.StringAttributes;
            }
        }
    }
}
