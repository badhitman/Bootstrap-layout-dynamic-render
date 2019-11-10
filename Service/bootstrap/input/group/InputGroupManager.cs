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
        /// <summary>
        /// Wrapping:
        /// Input groups wrap by default via flex-wrap: wrap in order to accommodate custom form field validation within an input group. You may disable this with .flex-nowrap.
        /// </summary>
        public bool IsFlexNowrap { get; set; } = false;

        /// <summary>
        /// Sizing:
        /// Add the relative form sizing classes to the.input-group itself and contents within will automatically resize—no need for repeating the form control size classes on each element.
        /// Sizing on the individual input group elements isn’t supported.
        /// </summary>
        public TwinSizingEnum InputGroupSize = TwinSizingEnum.NULL;

        InputGroupPrependManager Prepend { get; set; }

        InputGroupAppendManager Append { get; set; }

        public override string ViewComponentName => nameof(InputGroupBase);

        public override string GetStringCSS()
        {
            //get
            //{
                if (IsFlexNowrap)
                    AddCSS("flex-nowrap");

                AddCSS("input-group");

                if (InputGroupSize != TwinSizingEnum.NULL)
                    AddCSS("input-group-" + InputGroupSize.ToString());

                return base.GetStringCSS();
            //}
        }
    }
}
