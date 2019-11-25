////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputRange : ahsTextedInputs
    {
        public int Min { get; set; } = 0;

        public int Max { get; set; } = 100;

        public int Step { get; set; } = 1;

        public override string GetStringAttributes()
        {
            SetAttribute("type", hmInputTypesEnum.range.ToString());

            SetAttribute("min", Min.ToString());
            SetAttribute("max", Max.ToString());
            SetAttribute("step", Step.ToString());
            
            if (string.IsNullOrWhiteSpace(Value))
                Value = Min.ToString();

            return base.GetStringAttributes();
        }
    }
}
