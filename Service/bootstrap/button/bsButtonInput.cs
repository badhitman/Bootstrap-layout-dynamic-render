////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsButtonInput : bsButton
    {
        public bmButtonInputTypesEnum InputType { get; set; }

        public bsButtonInput(string SetHeader, bmButtonInputTypesEnum SetInputType = bmButtonInputTypesEnum.button) : base(SetHeader)
        {
            InputType = SetInputType;
        }

        public override string GetStringAttributes()
        {
            //SetAttribute("type", InputType.ToString().ToLower());
            SetAttribute("value", Header);
            return base.GetStringAttributes();
        }
    }
}
