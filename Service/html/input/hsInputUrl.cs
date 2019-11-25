////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputUrl : ahsTextedInputs
    {
        public hsInputUrl()
        {
            SetAttribute("type", hmInputTypesEnum.url.ToString());
        }
    }
}
