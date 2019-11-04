////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html;
using BootstrapViewComponentsRazorLibrary.Models.html;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class ButtonBaseManager : AbstractDomManager
    {
        public ButtonTypesEnum ButtonType { get; set; } = ButtonTypesEnum.button;

        public string Header { get; set; }

        public override string ViewComponentName => nameof(HtmlRenderButton);

        public ButtonBaseManager(string SetHeader)
        {
            Header = SetHeader;
        }

        public override string StringAttributes
        {
            get
            {
                if (ButtonType != ButtonTypesEnum.NULL)
                    SetAttribute("type", ButtonType.ToString());

                return base.StringAttributes;
            }
        }
    }
}
