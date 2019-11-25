////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputFile : ahsValuableDataInputs
    {
        public hsInputFile()
        {
            SetAttribute("type", hmInputTypesEnum.file.ToString());
        }
    }
}
