////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputReset : ahsInputs
    {
        public hsInputReset()
        {
            SetAttribute("type", hmInputTypesEnum.reset.ToString());
        }
    }
}
