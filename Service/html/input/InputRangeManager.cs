////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputRangeManager : AbstractTextedInputManager
    {
        public int Min { get; set; } = 0;

        public int Max { get; set; } = 100;

        public int Step { get; set; } = 1;

        public override string GetStringAttributes()
        {
            SetAttribute("type", InputTypesEnum.range.ToString());

            SetAttribute("min", Min.ToString());
            SetAttribute("max", Max.ToString());
            SetAttribute("step", Step.ToString());

            return base.GetStringAttributes();
        }
    }
}
