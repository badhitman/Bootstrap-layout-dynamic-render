using BootstrapAspDynamicRender.components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapAspDynamicRender.service
{
    public class hsSmall : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrSmall);

        public string Text { get; set; }

        public hsSmall(string SetText)
        {
            Text = SetText;
        }
    }
}
