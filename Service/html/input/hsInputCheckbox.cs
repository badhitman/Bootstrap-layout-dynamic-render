////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputCheckbox : ahsCheckedInputs
    {
        public override string GetStringAttributes()
        {
            if (string.IsNullOrWhiteSpace(CacheAttributes))
            {
                SetAttribute("type", hmInputTypesEnum.checkbox.ToString());
            }

            return base.GetStringAttributes();
        }
    }
}
