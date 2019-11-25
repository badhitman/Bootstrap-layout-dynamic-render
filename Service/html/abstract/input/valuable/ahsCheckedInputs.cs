////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public abstract class ahsCheckedInputs : ahsInputs
    {
        public bool IsChecked { get; set; }

        public override string GetStringAttributes()
        {
            if (string.IsNullOrWhiteSpace(CacheAttributes))
            {
                if (IsChecked)
                    SetAttribute("checked", "checked");
                else
                    RemoveAttribute("checked");
            }

            return base.GetStringAttributes();
        }
    }
}
