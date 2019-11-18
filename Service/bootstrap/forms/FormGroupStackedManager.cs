using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.forms;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class FormGroupStackedManager : AbstractFormGroupManager
    {
        public List<CustomInputModel> CustomInputs { get; protected set; } = new List<CustomInputModel>();

        public bool IsInline { get; set; } = false;

        public override string GetStringCSS()
        {
            if (IsInline)
                AddCSS("form-row");
            else
                RemoveCSS("form-row");

            return base.GetStringCSS();
        }
    }
}
