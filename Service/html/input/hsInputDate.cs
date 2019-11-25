////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputDate : ahsTextedInputs
    {
        public hsInputDate()
        {
            SetAttribute("type", hmInputTypesEnum.date.ToString());
        }
    }
}
