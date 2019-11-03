using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class InputGroupManager : AbstractCustomInputManager
    {
        public bool IsFlexNowrap { get; set; } = false;

        public TwinSizingEnum InputGroupSize = TwinSizingEnum.NULL;

        InputGroupPrependManager Prepend { get; set; }

        InputGroupAppendManager Append { get; set; }

        public override string ViewComponentName => nameof(InputGroupBase);

        public override string StringCSS
        {
            get
            {
                if (IsFlexNowrap)
                    AddCSS("flex-nowrap");

                AddCSS("input-group");

                if (InputGroupSize != TwinSizingEnum.NULL)
                    AddCSS("input-group-" + InputGroupSize.ToString());

                return base.StringCSS;
            }
        }
    }
}
