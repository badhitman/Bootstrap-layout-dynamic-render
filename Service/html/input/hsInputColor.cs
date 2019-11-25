////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputColor : ahsTextedInputs
    {
        public hsInputColor()
        {
            SetAttribute("type", hmInputTypesEnum.color.ToString());
        }
    }
}
