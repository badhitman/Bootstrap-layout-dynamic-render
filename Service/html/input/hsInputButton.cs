////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputButton : ahsValuableDataInputs
    {
        public hsInputButton()
        {
            SetAttribute("type", hmInputTypesEnum.button.ToString());
        }
    }
}
