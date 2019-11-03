using BootstrapViewComponentsRazorLibrary.Components.html.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class SelectManager : AbstractInputsManager
    {
        public override string ViewComponentName => nameof(SelectBase);

        public void AddOption(string header, string value)
        {

        }
    }
}
