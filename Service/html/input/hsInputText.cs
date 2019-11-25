////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputText : ahsTextedInputs
    {
        public hsInputText()
        {
            SetAttribute("type", hmInputTypesEnum.text.ToString());
        }
    }
}
