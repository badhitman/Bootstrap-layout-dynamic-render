////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputTel : ahsTextedInputs
    {
        public hsInputTel()
        {
            SetAttribute("type", hmInputTypesEnum.tel.ToString());
        }
    }
}
