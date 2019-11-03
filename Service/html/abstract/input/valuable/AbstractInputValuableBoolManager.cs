////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public abstract class AbstractInputValuableBoolManager : AbstractInputValuableManager
    {
        public bool IsChecked { get; set; }

        public AbstractInputValuableBoolManager(InputTypesEnum SetInputType) : base(SetInputType) { }

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
