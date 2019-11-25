////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputImage : ahsValuableDataInputs
    {
        public string Src => Value;

        public hsInputImage()
        {
            SetAttribute("type", hmInputTypesEnum.image.ToString());
        }
    }
}
