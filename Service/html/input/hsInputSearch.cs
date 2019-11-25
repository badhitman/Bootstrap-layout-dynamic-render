////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputSearch : ahsTextedInputs
    {
        public hsInputSearch()
        {
            SetAttribute("type", hmInputTypesEnum.search.ToString());
        }
    }
}
