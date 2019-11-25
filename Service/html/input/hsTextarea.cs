////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public class hsTextarea : ahsTextedBasicInputs
    {
        public override string GetStringAttributes()
        {
            if (SizeArea > 0)
                SetAttribute("rows", SizeArea.ToString());
            else
                RemoveAttribute("rows");

            return base.GetStringAttributes();
        }
    }
}
