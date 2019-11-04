////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class NavbarTextManager : AbstractDomManager
    {
        public override string ViewComponentName => nameof(NavbarText);

        public string Header { get; set; }
        
        public NavbarTextManager(string SetHeader)
        {
            Header = SetHeader;
        }
    }
}
