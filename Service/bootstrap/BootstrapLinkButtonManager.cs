using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class BootstrapLinkButtonManager : LinkBasicManager
    {
        public ButtonSettingsModel ButtonSettings { get; private set; } = new ButtonSettingsModel();

        public BootstrapLinkButtonManager(ButtonSettingsModel SetButtonSettings)
        {
            ButtonSettings = SetButtonSettings;
        }

        public override string GetStringAttributes()
        {
            SetAttribute("role", "button");
            
            AddCSS(new BootstrapButtonManager("") { ButtonSettings = ButtonSettings }.GetStringCSS());
            return base.GetStringAttributes();
        }
    }
}
