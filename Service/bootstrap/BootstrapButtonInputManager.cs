using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class BootstrapButtonInputManager : BootstrapButtonManager
    {
        public BootstrapButtonInputTypesEnum InputType { get; set; }

        public BootstrapButtonInputManager(string SetHeader, BootstrapButtonInputTypesEnum SetInputType = BootstrapButtonInputTypesEnum.button) : base(SetHeader)
        {
            InputType = SetInputType;
        }

        public override string GetStringAttributes()
        {
            //SetAttribute("type", InputType.ToString().ToLower());
            SetAttribute("value", Header);
            return base.GetStringAttributes();
        }
    }
}
