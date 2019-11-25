////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputTime : ahsTextedInputs
    {
        public hsInputTime()
        {
            SetAttribute("type", hmInputTypesEnum.time.ToString());
        }
    }
}
