////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputEmail : ahsTextedInputs
    {
        public hsInputEmail()
        {
            SetAttribute("type", hmInputTypesEnum.email.ToString());
        }
    }
}
