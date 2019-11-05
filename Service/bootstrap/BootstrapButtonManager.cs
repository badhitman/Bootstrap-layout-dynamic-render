using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class BootstrapButtonManager : ButtonBaseManager
    {
        public ButtonSettingsModel ButtonSettings { get; set; } = new ButtonSettingsModel();

        public BootstrapButtonManager(string SetHeader, ButtonSettingsModel Settings=null) : base(SetHeader)
        {
            if (!(Settings is null))
                ButtonSettings = Settings;

            AddCSS("btn");
        }

        public override string GetStringCSS()
        {
            //get
            //{
                if (ButtonSettings.BackgroundColorTheme != BackgroundColorThemesEnum.NULL)
                    AddCSS("btn-" + (ButtonSettings.IsOutlineStyle ? "outline-" : "") + ButtonSettings.BackgroundColorTheme.ToString());

                if (ButtonSettings.SizeButton != TwinSizingEnum.NULL)
                    AddCSS("btn-" + ButtonSettings.BackgroundColorTheme.ToString());

                if (ButtonSettings.IsBlockBtn)
                    AddCSS("btn-block");

                if (ButtonSettings.IsActive)
                {
                    AddCSS("active");
                    SetAttribute("aria-pressed", "true");
                }

                if (ButtonSettings.ToggleActiveState)
                {
                    SetAttribute("data-toggle", "button");
                    SetAttribute("autocomplete", "off");
                    SetAttribute("aria-pressed", "true");
                }

                return base.GetStringCSS();
            //}
        }
    }
}
