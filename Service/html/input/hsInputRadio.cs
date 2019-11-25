////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputRadio : ahsCheckedInputs
    {
        public string Value { get; set; }
        
        public hsInputRadio()
        {
            SetAttribute("type", hmInputTypesEnum.radio.ToString());
        }

        public override string GetStringAttributes()
        {
            SetAttribute("value", Value);
            return base.GetStringAttributes();
        }
    }
}
