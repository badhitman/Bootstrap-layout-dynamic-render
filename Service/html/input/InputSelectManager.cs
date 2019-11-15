////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html.input;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputSelectManager : AbstractInputManager
    {
        public override string ViewComponentName => nameof(SelectBase);

        public List<InputOptionSelectManager> Options { get; private set; } = new List<InputOptionSelectManager>();

        public bool IsMultiple { get; set; } = false;

        public void AddItem(string header_option, string value_option)=> Options.Add(new InputOptionSelectManager() { Header = header_option, Value = value_option });

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
