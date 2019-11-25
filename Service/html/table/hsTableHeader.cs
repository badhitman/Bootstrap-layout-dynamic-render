////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsTableHeader : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrTableHeader);

        public void AddColumnHeader(string name_header)
        {
            Childs.Add(new hsTableTh() { Header = name_header });
        }
    }
}
