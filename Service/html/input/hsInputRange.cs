////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputRange : ahsTextedInputs
    {
        public int Min { get; set; }

        public int Max { get; set; }

        public int Step { get; set; }

        public override string GetStringAttributes()
        {
            SetAttribute("type", hmInputTypesEnum.range.ToString());
            if (Min != 0)
                SetAttribute("min", Min.ToString());

            if (Max != 0)
                SetAttribute("max", Max.ToString());

            if (Step != 0)
                SetAttribute("step", Step.ToString());

            return base.GetStringAttributes();
        }
    }
}
