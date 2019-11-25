////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputPassword : ahsTextedInputs
    {
        public hsInputPassword()
        {
            SetAttribute("type", hmInputTypesEnum.password.ToString());
        }
    }
}
