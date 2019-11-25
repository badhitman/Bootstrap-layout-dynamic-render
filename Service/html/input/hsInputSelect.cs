////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using System.Collections.Generic;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputSelect : ahsInputs
    {
        public override string ViewComponentName => nameof(hrSelect);

        public List<hsInputOptionSelect> Options { get; private set; } = new List<hsInputOptionSelect>();

        public bool IsMultiple { get; set; } = false;

        public hsInputOptionSelect AddItem(string header_option, string value_option)
        {
            hsInputOptionSelect InputOptionSelect = new hsInputOptionSelect() { Header = header_option, Value = value_option };
            Options.Add(InputOptionSelect);
            return InputOptionSelect;
        }

        public override string GetStringAttributes()
        {
            if (IsMultiple)
                SetAttribute("multiple", null);
            else
                RemoveAttribute("multiple");

            return base.GetStringAttributes();
        }
    }
}
