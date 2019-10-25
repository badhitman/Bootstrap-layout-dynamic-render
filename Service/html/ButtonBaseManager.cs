////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html;
using BootstrapViewComponentsRazorLibrary.Models.html;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class ButtonBaseManager : AbstractDomManager
    {
        public ButtonTypesEnum ButtonType { get; set; } = ButtonTypesEnum.button;

        public string Header { get; set; }

        public override string ViewComponentName => nameof(ButtonBase);

        public ButtonBaseManager(string SetHeader)
        {
            Header = SetHeader;
        }
    }
}
