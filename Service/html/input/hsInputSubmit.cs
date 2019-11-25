////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputSubmit : ahsValuableDataInputs
    {
        public hsInputSubmit()
        {
            SetAttribute("type", hmInputTypesEnum.submit.ToString());
        }
    }
}
