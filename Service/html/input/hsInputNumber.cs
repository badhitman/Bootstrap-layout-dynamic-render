////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputNumber : ahsTextedInputs
    {
        public hsInputNumber()
        {
            SetAttribute("type", hmInputTypesEnum.number.ToString());
        }
    }
}
