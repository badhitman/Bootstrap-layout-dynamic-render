////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class bsNavbarText : ahsDom
    {
        public override string ViewComponentName => nameof(brNavbarText);

        public string Header { get; set; }
        
        public bsNavbarText(string SetHeader)
        {
            Header = SetHeader;
        }
    }
}
