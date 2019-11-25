////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputHidden : ahsValuableDataInputs
    {
        public hsInputHidden()
        {
            SetAttribute("type", hmInputTypesEnum.hidden.ToString());
        }
    }
}
